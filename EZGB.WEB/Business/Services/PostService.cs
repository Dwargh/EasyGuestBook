using System;
using System.Collections.Generic;
using EZGB.DataAccess.Repositories;
using EZGB.Web.Business.Mappers;
using EZGB.Web.Business.Models;

namespace EZGB.Web.Business.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IPostMapper _postMapper;

        public PostService(IPostRepository postRepository, IPostMapper postMapper)
        {
            _postRepository = postRepository;
            _postMapper = postMapper;
        }

        //public PostModel GetPost(Guid id)
        //{
        //    var post = _postRepository.GetPost(id);
        //    return _postMapper.Map(post);
        //}

        public IList<PostModel> GetPosts()
        {
            var posts = _postRepository.GetPosts();
            return _postMapper.Map(posts);
        }

        public PostModel SavePost(PostModel model)
        {
            model.Date = DateTime.Now;
            var post = _postRepository.SavePost(_postMapper.Map(model));
            return _postMapper.Map(post);
        }
    }
}