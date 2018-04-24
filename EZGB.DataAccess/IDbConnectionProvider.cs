using System.Data;

namespace EZGB.DataAccess
{
    public interface IDbConnectionProvider
    {
        IDbConnection GetOpenConnection();
    }
}
