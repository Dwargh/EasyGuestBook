using System;
using System.Collections.Generic;
using EZGB.DataAccess.Models;
using EZGB.Web.Business.Models;

namespace EZGB.Web.Business.Mappers
{
    public interface IPostMapper
    {
        Post Map(PostModel model);
        PostModel Map(Post post);
        IList<PostModel> Map(IEnumerable<Post> posts);
    }
}
