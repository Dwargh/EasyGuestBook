using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EZGB.Web.Business.Models;
using EZGB.Web.Business.Services;

namespace EZGB.Web.Areas.App.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]
        public ViewResult Index()
        {
            var model = _postService.GetPosts();
            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            var model = new PostModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(PostModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Create",model);
            }
            var result = _postService.SavePost(model);
            return RedirectToAction("Index");
        }
    }
}