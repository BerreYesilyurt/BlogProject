using BusinessLayer.Concrete;
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
        CommentManager cm = new CommentManager();

        // GET: Comment
        public PartialViewResult CommentList(int id)
        {
            var commentList = cm.CommentBybLog(id);

            return PartialView(commentList);
        }

        [HttpGet] /*Sayfa yüklendiğinde çalışan kısım*/
        public PartialViewResult LeaveComment(int id)
        {
            ViewBag.id = id; /*id değerini taşırken hata verdiği için sayfa yüklenirken id değerini Viewbag ile taşımaya çalışıyoruz.*/

            return PartialView();
        }


        [HttpPost] 
        public PartialViewResult LeaveComment(Comment c )
        {
            cm.CommentAdd(c);

            return PartialView();
        }

    }
}