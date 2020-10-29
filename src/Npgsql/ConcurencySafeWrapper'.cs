using System.Threading;

namespace Npgsql
{
    internal struct ConcurencySafeWrapper<T>
    {
        public readonly SemaphoreSlim Semaphore;

        public T Value;

        public ConcurencySafeWrapper(T value)
        {
            Value = value;
            Semaphore = new SemaphoreSlim(1);
        }
    }
}
