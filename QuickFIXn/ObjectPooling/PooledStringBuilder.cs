using System;
using System.Text;

namespace QuickFix.ObjectPooling;

/// <summary>
/// A pooled StringBuilder that can be used to reduce memory allocations.
/// </summary>
internal readonly struct PooledStringBuilder : IDisposable
{
    private static readonly ObjectPool<StringBuilder> _pool = ObjectPool<StringBuilder>.BigShared;

    public StringBuilder Builder { get; }

    public PooledStringBuilder()
    {
        Builder = _pool.Get() ?? new StringBuilder(4096);
    }

    public override string ToString() => Builder.ToString();

    public void Dispose()
    {
        if (Builder.Length > 64 * 1024)
        {
            return;
        }

        Builder.Clear();
        _pool.Return(Builder);
    }
}
