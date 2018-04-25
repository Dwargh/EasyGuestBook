using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using DapperExtensions;
using EZGB.DataAccess.Models;

namespace EZGB.DataAccess.Repositories
{
    internal class PostRepository : RepositoryBase, IPostRepository
    {
        public PostRepository(IDbConnectionProvider connectionProvider)
            :base(connectionProvider)
        {
        }

        public IList<Post> GetPosts()
        {
            var result = new List<Post>();
            using (var connection = ConnectionProvider.GetOpenConnection())
            {
                result = connection.GetList<Post>().ToList();
            }
            return result;
        }

        public Post SavePost(Post post)
        {
            using (var connection = ConnectionProvider.GetOpenConnection())
            {
                connection.Insert(post);
            }
            return post;
        }
    }
}
