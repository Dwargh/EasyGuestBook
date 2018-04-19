using System.Data;

namespace EZGB.DataAccess
{
    public interface IConnectionProvider
    {
        IDbConnection GetOpenConnection();
    }
}
