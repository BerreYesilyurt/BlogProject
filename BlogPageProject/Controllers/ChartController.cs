﻿using BlogPageProject.Models;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogPageProject.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult VisualizeResult()
        {
            return Json(categorylist(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult VisualizeResult2()
        {
            return Json(blogList(), JsonRequestBehavior.AllowGet);
        }

        public List<Class1> categorylist()
        {
            List<Class1> c = new List<Class1>();
            c.Add(new Class1()
            {
                CategoryName = "Teknoloji",
                BlogCount = 14


            });

            c.Add(new Class1()
            {
                CategoryName = "Spor",
                BlogCount = 10
            });

            c.Add(new Class1()
            {
                CategoryName = "Kitap",
                BlogCount = 16
            });

            return c;
        }

        public List<Class2> blogList()
        {
            List<Class2> cs2 = new List<Class2>();
            using (var c = new Context())
            {
                cs2 = c.Blogs.Select(x => new Class2
                {
                    BlogName = x.BlogTitle,
                    Rating = x.BlogRating
                }).ToList();    


            }

            return cs2; 
        }

        public ActionResult Chart1()
        {

            return View();  
        }

        public ActionResult Chart2()
        {
            return View();
        }

        public ActionResult Chart3()
        {

            return View();
        }
    }
}