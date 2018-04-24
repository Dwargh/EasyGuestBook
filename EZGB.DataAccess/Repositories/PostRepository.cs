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

        //public Post GetPost(Guid id)
        //{
        //    Post result; 
        //    using (var connection = ConnectionProvider.GetOpenConnection())
        //    {
        //        result = connection.Get<Post>(id);
        //    }
        //    return result;
        //}

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
