using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace XSS.Example.Models
{
    public class Post
    {
        [Key]
        public int PId { get; set; }

        public string Title { get; set; }

        [AllowHtml]
        public string Content { get; set; }
    }
}