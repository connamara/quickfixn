namespace QuickFix.ObjectPooling;

/// <summary>
/// Object pooling base class.
/// </summary>
internal abstract class ObjectPool<T> where T : class
{
    private static readonly DefaultObjectPool<T> s_shared = new();
    private static readonly DefaultObjectPool<T> s_bigShared = new() { Capacity = 128 };

    /// <summary>
    /// Get an object from the pool. If no objects are available, return <see langword="null"/>.
    /// </summary>
    /// <returns>
    /// The object from the pool, or <see langword="null"/> if no objects are available.
    /// </returns>
    public abstract T? Get();

    /// <summary>
    /// Return an object to the pool. If the pool is full, the object will not be returned.
    /// </summary>
    /// <returns>
    /// <see langword="true"/> if the object was returned to the pool, <see langword="false"/> if the pool is full.
    /// </returns>
    public abstract bool Return(T item);

    /// <summary>
    /// A shared object pool with a default capacity.
    /// </summary>
    public static ObjectPool<T> Shared => s_shared;

    /// <summary>
    /// A shared object pool with a larger capacity.
    /// </summary>
    public static ObjectPool<T> BigShared => s_bigShared;

    /// <summary>
    /// Create a new object pool with the specified capacity.
    /// </summary>
    public static ObjectPool<T> Create(int capacity) => new DefaultObjectPool<T>() { Capacity = capacity };
}
