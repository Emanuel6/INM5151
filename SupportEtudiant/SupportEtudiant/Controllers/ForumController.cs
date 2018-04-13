using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SupportEtudiant.Controllers
{
    public class ForumController : Controller
    {
        // GET: Forum
        public ActionResult Index()
        {
            return View();
        }

        // GET
        public ActionResult ForumTopicList()
        {
            return View();
        }

        // GET
        public ActionResult ForumDiscussion()
        {
            return View();
        }
    }
}