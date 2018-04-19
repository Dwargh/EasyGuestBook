namespace EZGB.DataAccess.Repositories
{
    internal abstract class RepositoryBase
    {
        protected IConnectionProvider ConnectionProvider { get; private set; }

        protected RepositoryBase(IConnectionProvider connectionProvider)
        {
            ConnectionProvider = connectionProvider;
        }
    }
}