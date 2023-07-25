﻿using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogPageProject.Controllers
{

    public class AuthorController : Controller
    {
        BlogManager bm = new BlogManager();

        // GET: Author
        public PartialViewResult AuthorAbout(int id)
        {
            var authordetail = bm.GetBlogById(id);
            return PartialView(authordetail);
        }

        public PartialViewResult AuthorPopularPost(int id)
        {
            var blogauthorid = bm.GelAll().Where(x => x.BlogID == id).Select(y=>y.AuthorID).FirstOrDefault();
            ViewBag.blogauthorid = blogauthorid;

            var authorblogs = bm.GetBlogByAuthor(blogauthorid);

            return PartialView(authorblogs);
        }
    }
}