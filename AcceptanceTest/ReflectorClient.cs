using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

namespace AcceptanceTest;

internal class ReflectorClient : IReflector
{
    private static readonly Regex s_timeRegex = new(@"\<TIME([+-]\d+)\>", RegexOptions.Compiled);
    private static readonly Regex s_beginStringRegex = new(@"^8=.*?[\001]", RegexOptions.Compiled);
    private static readonly Regex s_bodyLengthRegex = new(@"[\001]9=.*?[\001]", RegexOptions.Compiled);
    private static readonly Regex s_checksumRegex = new(@"[\001]10=.*[\001]$", RegexOptions.Compiled);
    private static readonly Dictionary<string, Regex> s_expectPatterns = new()
    {
        { "10", new Regex(@"\d{3}", RegexOptions.Compiled) },
        { "42", new Regex(@"\d{8}-\d{2}:\d{2}:\d{2}", RegexOptions.Compiled) },
        { "52", new Regex(@"\d{8}-\d{2}:\d{2}:\d{2}|\d{8}-\d{2}:\d{2}:\d{2}[.]\d{3}", RegexOptions.Compiled) },
        { "60", new Regex(@"\d{8}-\d{2}:\d{2}:\d{2}", RegexOptions.Compiled) },
        { "122", new Regex(@"\d{8}-\d{2}:\d{2}:\d{2}", RegexOptions.Compiled) },
    };

    private readonly IPEndPoint _endPoint;
    private readonly ReflectorParser _parser;
    private readonly byte[] _readBuffer;

    private Socket? _socket;


    public ReflectorClient(IPEndPoint endPoint)
    {
        _endPoint = endPoint;
        _parser = new ReflectorParser();
        _readBuffer = new byte[1024];
    }

    public void Expect(string expectedMessage)
    {
        Assert.IsNotNull(_socket);

        string actualMessage;
        while (!_parser.ReadFixMessage(out actualMessage))
        {
            int bytesReceived = _socket.Receive(_readBuffer);

            if (bytesReceived == 0)
            {
                Assert.Fail("Socket was shut down by remote host.");
            }

            _parser.AddToStream(_readBuffer, bytesReceived);
        }

        expectedMessage = Decorate(expectedMessage);

        string[] expectedFields = expectedMessage[..^1].Split('\u0001');
        string[] actualFields = actualMessage[..^1].Split('\u0001');

        int mismatchIndex = 0;

        for (int fieldIndex = 0; fieldIndex < Math.Min(expectedFields.Length, actualFields.Length); fieldIndex++)
        {
            string[] expectedTagValue = expectedFields[fieldIndex].Split('=', 2);
            string[] actualTagValue = actualFields[fieldIndex].Split('=', 2);

            if (expectedTagValue[0] != actualTagValue[0])
            {
                AssertAtIndex(mismatchIndex);
            }

            mismatchIndex += expectedTagValue[0].Length + 1;

            if (s_expectPatterns.TryGetValue(expectedTagValue[0], out Regex? valueRegex))
            {
                if (!valueRegex.IsMatch(actualTagValue[1]))
                {
                    AssertAtIndex(mismatchIndex);
                }
            }
            else if (expectedTagValue[1] != actualTagValue[1])
            {
                AssertAtIndex(mismatchIndex);
            }

            mismatchIndex += actualTagValue[1].Length + 1;
        }

        if (expectedFields.Length != actualFields.Length)
        {
            AssertAtIndex(mismatchIndex);
        }

        void AssertAtIndex(int mismatchIndex)
        {
            StringBuilder sb = new();
            sb.AppendLine("");
            sb.AppendLine($"Expected: {expectedMessage.Replace("\u0001", "|")}");
            sb.AppendLine($"But was:  {actualMessage.Replace("\u0001", "|")}");
            sb.AppendLine($"          {new string(' ', mismatchIndex)}^");
            Assert.Fail(sb.ToString());
        }
    }

    public void Initiate(string initiateMessage)
    {
        string decoratedMessage = Decorate(initiateMessage);
        Assert.IsNotNull(_socket);
        _socket.Send(Encoding.Latin1.GetBytes(decoratedMessage));
    }

    /// <summary>
    /// Fills in timestamps and adds missing BodyLength/Checksum fields.
    /// </summary>
    /// <returns>The decorated message.</returns>
    private static string Decorate(string initiateMessage)
    {
        DateTime now = DateTime.UtcNow;

        initiateMessage = initiateMessage.Replace("<TIME>", now.ToString("yyyyMMdd-HH:mm:ss"));

        initiateMessage = s_timeRegex.Replace(
            initiateMessage,
            m => now.AddDays(int.Parse(m.Groups[1].Value)).ToString("yyyyMMdd-HH:mm:ss"));

        if (s_beginStringRegex.Match(initiateMessage) is not Match { Success: true } beginStringMatch)
        {
            // If the message does not start with BeginString (e.g. 8=FIX.4.0), then return it as is.
            return initiateMessage;
        }

        Match bodyLengthMatch = s_bodyLengthRegex.Match(initiateMessage);
        Match checksumMatch = s_checksumRegex.Match(initiateMessage);

        // Declared outside the switch due to cases sharing scope.
        int bodyLengthValue;
        byte checksumValue;

        switch ((bodyLengthMatch.Success, checksumMatch.Success))
        {
            case (true, true):
                // We already have both BodyLength and Checksum. Return the message as is.
                return initiateMessage;

            case (true, false):
                // We have BodyLength but no Checksum.
                checksumValue = Checksum(initiateMessage);
                return initiateMessage + "10=" + checksumValue.ToString().PadLeft(3, '0') + '\u0001';

            case (false, true):
                // No BodyLength, but we do have Checksum
                bodyLengthValue = checksumMatch.Index - beginStringMatch.Length + 1;
                return $"{beginStringMatch.Value}9={bodyLengthValue}\u0001{initiateMessage.AsSpan(beginStringMatch.Length)}";

            case (false, false):
                // Neither BodyLength nor Checksum

                bodyLengthValue = initiateMessage.Length - beginStringMatch.Length;
                string bodyLength = $"9={bodyLengthValue}\u0001";

                checksumValue = Checksum(initiateMessage + bodyLength);
                string checksum = $"10={checksumValue.ToString().PadLeft(3, '0')}\u0001";

                return $"{beginStringMatch.Value}{bodyLength}{initiateMessage.AsSpan(beginStringMatch.Length)}{checksum}";
        }

        static byte Checksum(string message)
        {
            byte checksum = 0;
            byte[] bytes = Encoding.Latin1.GetBytes(message);
            foreach (byte b in bytes)
            {
                checksum += b;
            }
            return checksum;
        }
    }

    public void InitiateConnect()
    {
        Assert.IsNull(_socket);

        _socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
        _socket.Connect(_endPoint);
    }

    public void InitiateDisconnect()
    {
        Assert.IsNotNull(_socket);

        ShutdownSocket();
    }

    public void ExpectDisconnect()
    {
        Assert.IsNotNull(_socket);

        int bytesRead = _socket.Receive(_readBuffer);
        Assert.AreEqual(0, bytesRead);

        ShutdownSocket();
    }

    private void ShutdownSocket()
    {
        if (_socket is not null)
        {
            _socket.Shutdown(SocketShutdown.Both);
            _socket.Dispose();
            _socket = null;
        }
    }

    public void Dispose()
    {
        ShutdownSocket();
    }
}