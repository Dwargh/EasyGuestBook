using EZGB.DataAccess.Models;
using DapperExtensions.Mapper;

namespace EZGB.DataAccess.Mappers
{
    public class PostMapper : ClassMapper<Post>
    {
        public PostMapper()
        {
            Table("Post");
            AutoMap();
        }
    }
}
