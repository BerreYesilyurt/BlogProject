﻿using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogPageProject.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager();
        // GET: Contact
        [AllowAnonymous]    
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult SendMessage()
        {

            return View();
        }

        [AllowAnonymous]    
        [HttpPost]
        public ActionResult SendMessage(Contact p)
        {
            cm.BLContactAdd(p);

            return View();
        }

        public ActionResult SendBox() {

            var messagelist = cm.GelAll();

            return View(messagelist);  
        
        }

        public ActionResult MessageDetails(int id)
        {
            Contact contact = cm.GetContactDetails(id);
            return View(contact);
        }
    }
}