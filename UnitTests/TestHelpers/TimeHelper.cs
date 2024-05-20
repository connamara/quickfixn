using System;
using QuickFix.Fields.Converters;

namespace UnitTests.TestHelpers;

public static class TimeHelper {
    public static DateTime MakeDateTime(int y, int m, int d, int h, int min, int s, int ms, int us, int ns) {
        // DateTime resolution is only to the tick, which is 100ns
        if (ns % 100 != 0)
            throw new ArgumentException("ns must be a multiple of 100", nameof(ns));

        // already includes ms
        DateTime dt = new DateTime(y, m, d, h, min, s, ms);
        long nanos = (us * DateTimeConverter.NanosPerMicro) + ns;
        long ticks = nanos / DateTimeConverter.NanosecondsPerTick;
        return dt.AddTicks(ticks);
    }

    public static DateTime MakeTimeOnly(int h, int m, int s, int ms, int us, int ns)
    {
        return MakeDateTime(1980, 1, 1, h, m, s, ms, us, ns);
    }
}
