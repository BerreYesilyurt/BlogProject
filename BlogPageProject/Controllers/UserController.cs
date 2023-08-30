using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BlogPageProject.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        UserProfileManager userProfile = new UserProfileManager();
        BlogManager bm = new BlogManager();

        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Partial1(string p)
        {
            p = (string)Session["Mail"];
            var profilevalues = userProfile.GetAuthorByMail(p);

            return PartialView(profilevalues);
        }

        public ActionResult BlogList(string p)
        {
            Context c = new Context();
            p = (string)Session["Mail"];
            int id = c.Authors.Where(x => x.Mail == p).Select(y => y.AuthorID).FirstOrDefault();
            var blogs = userProfile.GetBlogByAuthor(id);
            return View(blogs);
        }

        [HttpGet]
        public ActionResult UpdateBlogs(int id)
        {
            Blog blog = bm.FindBlog(id);
            Context c = new Context();

            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList(); /*Kategori tablosundaki verilerin listelenmesi*/

            ViewBag.values = values;

            List<SelectListItem> values2 = (from x in c.Authors.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.AuthorName,
                                                Value = x.AuthorID.ToString()
                                            }).ToList();
            ViewBag.values2 = values2;

            return View(blog);
        }

        [HttpPost]
        public ActionResult UpdateBlogs(Blog p)
        {
            bm.UpdateBlog(p);

            return RedirectToAction("BlogList");
        }


        [HttpGet]
        public ActionResult AddNewBlogs()
        {
            Context c = new Context();

            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList(); /*Kategori tablosundaki verilerin listelenmesi*/

            ViewBag.values = values;

            List<SelectListItem> values2 = (from x in c.Authors.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.AuthorName,
                                                Value = x.AuthorID.ToString()
                                            }).ToList();
            ViewBag.values2 = values2;


            return View();
        }

        [HttpPost]
        public ActionResult AddNewBlogs(Blog b)
        {
            bm.BlogAddBL(b);

            return RedirectToAction("BlogList");
        }

        public ActionResult UpdateUserProfile(Author p)
        {
            userProfile.EditAuthor(p);
            return RedirectToAction("Index");
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();  
            return RedirectToAction("AuthorLogin","Login");   
        }
    }

}