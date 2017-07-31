using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ImpotsTaxes.Models;

namespace ImpotsTaxes.Controllers
{
    public class MigrationController : Controller
    {
        //
        // GET: /Migration/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Assujetti()
        {
            //List<Person> lst = new List<Person>();
            Liste lst = new Liste();
            ViewBag.Assujetti = lst.AssujettiNoteMig();
            return View();
        }

        public ActionResult SelectionAssujetti()
        {
            return View();
        }

        public ActionResult NotePerception()
        {
            return View();
        }
    }
}
