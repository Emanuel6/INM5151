using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SupportEtudiant.Controllers
{
    public class GroupeController : Controller
    {
        // GET: Groupe
        public ActionResult Index()
        {
            return View();
        }

        // GET
        public ActionResult GroupeRepertoire()
        {
            return View();
        }

        // GET
        public ActionResult GroupeDiscussion()
        {
            return View();
        }
    }
}