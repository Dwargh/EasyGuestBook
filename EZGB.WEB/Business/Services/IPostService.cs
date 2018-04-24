using EZGB.Web.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZGB.Web.Business.Services
{
    public interface IPostService
    {
        //PostModel GetPost(Guid id);
        IList<PostModel> GetPosts();
        PostModel SavePost(PostModel model);
    }
}
