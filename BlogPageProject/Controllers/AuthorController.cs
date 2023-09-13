﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogPageProject.Controllers
{

    public class AuthorController : Controller
    {
        BlogManager blogmamager = new BlogManager(new EfBlogDal());
        AuthorManager authormanager=new AuthorManager(new EfAuthorDal());

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
            var blogauthorid = blogmamager.GetList().Where(x => x.BlogID == id).Select(y=>y.AuthorID).FirstOrDefault();
            ViewBag.blogauthorid = blogauthorid;

            var authorblogs = blogmamager.GetBlogByAuthor(blogauthorid);

            return PartialView(authorblogs);
        }

        public ActionResult AuthorList()
        {
            var authorlists=authormanager.GetList();

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
            AuthorManager author = new AuthorManager(new EfAuthorDal());
            AuthorValidator authorValidator = new AuthorValidator();
            ValidationResult results = authorValidator.Validate(p);
            if (results.IsValid)
            {


                author.TAdd(p);

                return RedirectToAction("AuthorList");

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();

        }

        [HttpGet]
        public ActionResult AuthorEdit(int id)
        {
            Author author = authormanager.GetById(id);
            return View(author);

        }

        [HttpPost]
        public ActionResult AuthorEdit(Author p)
        {
            AuthorValidator authorValidator = new AuthorValidator();
            ValidationResult results = authorValidator.Validate(p);
            if (results.IsValid)
            {
                authormanager.TUpdate(p);
                return RedirectToAction("AuthorList");

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
            

        }

    }
}