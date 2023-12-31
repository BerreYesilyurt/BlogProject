﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogPageProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentDal());

        [AllowAnonymous]
        // GET: Comment
        public PartialViewResult CommentList(int id)
        {
            var commentList = cm.CommentBybLog(id);

            return PartialView(commentList);
        }

        [AllowAnonymous]    
        [HttpGet] /*Sayfa yüklendiğinde çalışan kısım*/
        public PartialViewResult LeaveComment(int id)
        {
            ViewBag.id = id; /*id değerini taşırken hata verdiği için sayfa yüklenirken id değerini Viewbag ile taşımaya çalışıyoruz.*/

            return PartialView();
        }

        [AllowAnonymous]
        [HttpPost] 
        public PartialViewResult LeaveComment(Comment c )
        {
            c.CommentStatus = true;
            cm.TAdd(c);

            return PartialView();
        }


        public ActionResult AdminCommentListTrue()
        {
            var commentlist = cm.CommentByStatusTrue();

            return View(commentlist);  
        }

        public ActionResult StatusChangeToFalse(int id)
        {
            cm.CommentStatusChangeToFalse(id);
            return RedirectToAction("AdminCommentListTrue");
        }


        public ActionResult AdminCommentListFalse()
        {
            var commentlistfalse = cm.CommentStatusFalse();
            return View(commentlistfalse);  
        }

        public ActionResult StatusChangeToTrue(int id)
        {
            cm.CommentStatusChangeToTrue(id);
            return RedirectToAction("AdminCommentListFalse");
        }



    }
}