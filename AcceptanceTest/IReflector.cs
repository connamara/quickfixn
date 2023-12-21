using System;

internal interface IReflector : IDisposable
{
    void InitiateConnect();

    void Initiate(string initiateMessage);

    void Expect(string expectedMessage);

    void InitiateDisconnect();

    void ExpectDisconnect();
}
