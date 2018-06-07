using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMDB_MVC_Sudarshan.Models;

namespace IMDB_MVC_Sudarshan.Controllers
{
    public class ActorController : Controller
    {

        [HttpPost]
        public ActionResult AddNewActor(String name, String sex, String dob,String bio)
        {

            Actor actor = new Actor();
            actor.Name = name;
            actor.Sex = sex;
            actor.DOB = Convert.ToDateTime(dob);
            actor.Bio = bio;

            try
            {
                using (IMDBContext db = new IMDBContext())
                {
                    db.Actors.Add(actor);
                    db.SaveChanges();
                }

            }
            catch(Exception e)
            {

            }
            return Json(new { Success = true });
            
        }
    }
}