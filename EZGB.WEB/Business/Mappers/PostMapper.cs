using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EZGB.DataAccess.Models;
using EZGB.Web.Business.Models;

namespace EZGB.Web.Business.Mappers
{
    public class PostMapper : IPostMapper
    {
        public Post Map(PostModel model)
        {
            return Mapper.Map<Post>(model);
        }

        public PostModel Map(Post post)
        {
            return Mapper.Map<PostModel>(post);
        }

        public IList<PostModel> Map(IEnumerable<Post> posts)
        {
            return posts.Select(Map).ToList();
        }
    }
}