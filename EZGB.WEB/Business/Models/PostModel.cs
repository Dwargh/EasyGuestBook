using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EZGB.Web.Business.Models
{
    public class PostModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Heading is required.")]
        [MaxLength(1024,ErrorMessage ="Heading is too long.")]
        public string Heading { get; set; }

        [Required(ErrorMessage = "Message is required.")]
        public string Message { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "The given Email is invalid.")]
        public string Email { get; set; }

        public DateTime Date { get; set; }
    }
}