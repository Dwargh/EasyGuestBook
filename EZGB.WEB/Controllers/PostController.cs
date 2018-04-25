using EZGB.Web.Business.Models;
using EZGB.Web.Business.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace EZGB.Web.Controllers
{
    public class PostController : ApiController
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService = postService;
        }
        // GET api/post
        [HttpGet]
        [Route("api/Post")]
        public IHttpActionResult Get()
        {
            var models = _postService.GetPosts();
            return Ok(models);
        }

        // POST api/post
        [HttpPost]
        [Route("api/Post")]
        public IHttpActionResult Post([FromBody]PostModel value)
        {
            if(value.Id == Guid.Empty)
            {
                value = _postService.SavePost(value);

                return Created(Request.RequestUri,value);
            }
            return Ok();
        }
    }
}
