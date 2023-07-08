﻿using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogPageProject.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager();
        // GET: Category
        public ActionResult Index()
        {
            var categoryvalues = cm.GetAll();
            return View(categoryvalues);
        }
    }
}