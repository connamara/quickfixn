using System;
using System.Collections.Concurrent;
using System.Threading;

namespace QuickFix.ObjectPooling;

/// <summary>
/// Default object pool implementation.
/// </summary>
internal sealed class DefaultObjectPool<T> : ObjectPool<T> where T : class
{
    private T? _fastItem;
    private readonly ConcurrentQueue<T> _items = new();
    private int _numItems;

    internal int Capacity { get; init; } = Environment.ProcessorCount * 2;

    public override T? Get()
    {
        T? item = _fastItem;
        if (item == null || Interlocked.CompareExchange(ref _fastItem, null, item) != item)
        {
            if (_items.TryDequeue(out item))
            {
                Interlocked.Decrement(ref _numItems);
            }
        }

        return item;
    }

    public override bool Return(T item)
    {
        if (_fastItem != null || Interlocked.CompareExchange(ref _fastItem, item, null) != null)
        {
            if (Interlocked.Increment(ref _numItems) <= Capacity)
            {
                _items.Enqueue(item);
                return true;
            }

            Interlocked.Decrement(ref _numItems);
            return false;
        }

        return true;
    }
}
