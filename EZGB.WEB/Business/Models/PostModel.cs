using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EZGB.Web.Business.Models
{
    public class PostModel
    {
        public Guid Id { get; set; }
        public string Heading { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
}