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

    [AllowAnonymous]
   
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult AuthorLogin()
        {
            return View();
        }

        // Authentication sistemde giriş yapan kullanıcı var mı yok mu bunu kontrol etmemizi
        // ve sistemde giriş yapan kullanıcı varsa bazı linklerde gezebilsin ama diğerlerinde gezemesin gibi oturum kontrolü yapmamızı sağlar.
        [HttpPost]
        public ActionResult AuthorLogin(Author p)
        {
            Context c = new Context();
            var userinfo = c.Authors.FirstOrDefault(x => x.Mail == p.Mail && x.Password == p.Password);

            if (userinfo != null)
            {
                FormsAuthentication.SetAuthCookie(userinfo.Mail, false);
                Session["Mail"] = userinfo.Mail.ToString(); // Mail adındaki Session nesnesi, eşitliğin sağ tarafından gelen veriyi tutuyor.
                return RedirectToAction("Index", "User");
            }

            else
            {
                return RedirectToAction("AuthorLogin", "Login");
            }

        }

        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminLogin(Admin p)
        {
            Context c = new Context();
            var admininfo = c.Admins.FirstOrDefault(x => x.UserName == p.UserName && x.Password == p.Password);

            if (admininfo != null)
            {
                FormsAuthentication.SetAuthCookie(admininfo.UserName, false);
                Session["UserName"] = admininfo.UserName.ToString(); // Mail adındaki Session nesnesi, eşitliğin sağ tarafından gelen veriyi tutuyor.
                return RedirectToAction("AdminBlogList", "Blog");
            }

            else
            {
                return RedirectToAction("AdminLogin", "Login");
            }

        }

    }
}
