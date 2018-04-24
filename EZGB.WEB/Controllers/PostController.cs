using EZGB.Web.Business.Models;
using EZGB.Web.Business.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace EZGB.Web.Controllers
{
    public class GbPostController : ApiController
    {
        private readonly IPostService _postService;
        public GbPostController(IPostService postService)
        {
            _postService = postService;
        }
        // GET api/post
        [HttpGet]
        public IHttpActionResult Get()
        {
            var models = _postService.GetPosts();
            return Ok(models);
        }

        //// GET api/post/5
        //public PostModel Get(Guid? id)
        //{
        //    if (!id.HasValue)
        //    {
        //        return null;
        //    }
        //    var model = _postService.GetPost(id.Value);
        //    return model;
        //}

        // POST api/post
        [HttpPost]
        public IHttpActionResult Post([FromBody]PostModel value)
        {
            if(value.Id == Guid.Empty)
            {
                value = _postService.SavePost(value);

                return Created(Request.RequestUri,value);
            }
            return Ok();
        }

        ////PUT api/post/5
        //public void Put(Guid? id, [FromBody]string value)
        //{
        //}

        ////DELETE api/post/5
        //public void Delete(int id)
        //{
        //}
    }
}
