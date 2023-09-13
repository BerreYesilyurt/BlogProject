using BusinessLayer.Concrete;
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
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        // GET: Category

        [AllowAnonymous]
        public PartialViewResult BlogDetailsCategoryList()
        {
            var categoryvalues = cm.GetList();
            return PartialView(categoryvalues);
        }

        public ActionResult AdminCategoryList()
        {
            var categorylist = cm.GetList();

            return View(categorylist);
        }

        [HttpGet]
        public ActionResult AdminCategoryAdd()
        {
            return View();  
        }
        [HttpPost]
        public ActionResult AdminCategoryAdd(Category p)
        {
            CategoryValidator categoryValidator=new CategoryValidator();
            ValidationResult results=categoryValidator.Validate(p);
            if (results.IsValid)
            {
                cm.TAdd(p);
                return RedirectToAction("AdminCategoryList");

            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);  
                }
            }

            return View();  
            
        }

        [HttpGet]
        public ActionResult CategoryEdit(int id)
        {
            Category category = cm.GetById(id);
            return View(category);

        }

        [HttpPost]
        public ActionResult CategoryEdit(Category p)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(p);
            if (results.IsValid)
            {
                cm.TUpdate(p);
                return RedirectToAction("AdminCategoryList");

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

        public ActionResult CategoryDelete(int id)
        {
            cm.DeleteCategoryBL(id);

            return RedirectToAction("AdminCategoryList");

        }

        public ActionResult CategoryActive(int id)
        {
            cm.ActiveCategoryBL(id);

            return RedirectToAction("AdminCategoryList");

        }
    }
}