using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogPageProject.Controllers
{

    public class AuthorController : Controller
    {
        BlogManager blogmamager = new BlogManager();
        AuthorManager authormanager=new AuthorManager();

        // GET: Author
        [AllowAnonymous]
        public PartialViewResult AuthorAbout(int id)
        {
            var authordetail = blogmamager.GetBlogById(id);
            return PartialView(authordetail);
        }

        [AllowAnonymous]
        public PartialViewResult AuthorPopularPost(int id)
        {
            var blogauthorid = blogmamager.GelAll().Where(x => x.BlogID == id).Select(y=>y.AuthorID).FirstOrDefault();
            ViewBag.blogauthorid = blogauthorid;

            var authorblogs = blogmamager.GetBlogByAuthor(blogauthorid);

            return PartialView(authorblogs);
        }

        public ActionResult AuthorList()
        {
            var authorlists=authormanager.GetAll();

            return View(authorlists);
        }


        [HttpGet]
        public ActionResult AddAuthor()
        {
            return View();  
        }


        [HttpPost]
        public ActionResult AddAuthor(Author p)
        {
            AuthorManager author = new AuthorManager();

            author.AddAuthorBL(p);

            return RedirectToAction("AuthorList");
        }

        [HttpGet]
        public ActionResult AuthorEdit(int id)
        {
            Author author = authormanager.FindAuthor(id);
            return View(author);

        }

        [HttpPost]
        public ActionResult AuthorEdit(Author p)
        {
            authormanager.EditAuthor(p);
            return RedirectToAction("AuthorList");

        }

    }
}