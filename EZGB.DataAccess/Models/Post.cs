﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZGB.DataAccess.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Heading { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
}
