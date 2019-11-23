using System;
using System.Linq;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Exam_Aviran_Ben_David.Models;

namespace Exam_Aviran_Ben_David.Controllers
{
    public class RepositoryController : Controller
    {
        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Bookmark(GitRepository repository)
        {
            if(Session["bookmarkedRepositories"] == null)
            {
                Session.Add("bookmarkedRepositories", new List<GitRepository>());
            }

            List<GitRepository> bookmarkedRepositories = Session["bookmarkedRepositories"] as List<GitRepository>;

            if (bookmarkedRepositories.FirstOrDefault(rep => rep.name == repository.name) == null)
            {
                bookmarkedRepositories.Add(repository);
            }

            return Json(repository);
        }

        public ActionResult Bookmarked()
        {
            return View();
        }

        public JsonResult GetBookmarkedRepositories()
        {
            return Json(Session["bookmarkedRepositories"] as List<GitRepository>, JsonRequestBehavior.AllowGet);
        }
    }
}