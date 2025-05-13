using System;
using QuickFix.Fields.Converters;

namespace UnitTests.TestHelpers;

public static class TimeHelper {
    private const int NanosPerMicro = 1000;

    /// <summary>
    /// Helper for creating a DateTime down to nano precision
    /// </summary>
    /// <param name="y"></param>
    /// <param name="m"></param>
    /// <param name="d"></param>
    /// <param name="h"></param>
    /// <param name="min"></param>
    /// <param name="s"></param>
    /// <param name="ms"></param>
    /// <param name="us"></param>
    /// <param name="ns">Must be a multiple of 100; C# can't do anything more precise</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static DateTime MakeDateTime(int y, int m, int d, int h, int min, int s, int ms, int us, int ns) {
        // DateTime resolution is only to the tick, which is 100ns
        if (ns % 100 != 0)
            throw new ArgumentException("ns must be a multiple of 100", nameof(ns));

        // already includes ms
        DateTime dt = new(y, m, d, h, min, s, ms);
        long nanos = (us * NanosPerMicro) + ns;
        long ticks = nanos / DateTimeConverter.NanosecondsPerTick;
        return dt.AddTicks(ticks);
    }

    public static TimeOnly MakeTimeOnly(int h, int min, int s, int ms, int us, int ns) {
        // DateTime resolution is only to the tick, which is 100ns
        if (ns % 100 != 0)
            throw new ArgumentException("ns must be a multiple of 100", nameof(ns));

        // already includes ms
        TimeOnly timeOnly = new(h, min, s, ms);
        long nanos = (us * NanosPerMicro) + ns;
        long ticks = nanos / DateTimeConverter.NanosecondsPerTick;

        // TimeOnly has no AddTicks method!  Stupid!
        return new TimeOnly(timeOnly.Ticks + ticks);
    }
}
