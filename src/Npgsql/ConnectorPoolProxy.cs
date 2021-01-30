namespace Npgsql
{
    sealed class ConnectorPoolProxy
    {
        volatile ConnectorPool? _pool;

        public ConnectorPoolProxy(ConnectorPool pool) => _pool = pool;

        public ConnectorPool? TryGet() => _pool;

        public void Clear() => _pool = null;
    }
}
