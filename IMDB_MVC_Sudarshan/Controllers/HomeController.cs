using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMDB_MVC_Sudarshan.Models;

namespace IMDB_MVC_Sudarshan.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //IMDBContext db = new IMDBContext();
            //var s = db.Actors.ToList();

            //var producer = db.Producers
            //                .Include("Movies").ToList();

            //var m = db.Movies
            //        .Include("Actors").ToList();
            //foreach (var j in m)
            //{
            //    var p = j.Actors;
            //}
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}