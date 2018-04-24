namespace EZGB.DataAccess.Repositories
{
    internal abstract class RepositoryBase
    {
        protected IDbConnectionProvider ConnectionProvider { get; private set; }

        protected RepositoryBase(IDbConnectionProvider connectionProvider)
        {
            ConnectionProvider = connectionProvider;
        }
    }
}