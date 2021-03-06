﻿using System;
using EZGB.DataAccess.Models;
using System.Collections.Generic;

namespace EZGB.DataAccess.Repositories
{
    public interface IPostRepository
    {
        IList<Post> GetPosts();
        Post SavePost(Post post);
    }
}
