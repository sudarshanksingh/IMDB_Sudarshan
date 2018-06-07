using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMDB_MVC_Sudarshan.Models;

namespace IMDB_MVC_Sudarshan.Controllers
{
    public class ProducerController : Controller
    {
        [HttpPost]
        public ActionResult AddNewProducer (String name , String sex, String dob , String bio)
        {
            Producer producer = new Producer();
            producer.Name = name;
            producer.Sex = sex;
            producer.DOB = Convert.ToDateTime(dob);
            producer.Bio = bio;

            try
            {
                using (IMDBContext db = new IMDBContext())
                {
                    db.Producers.Add(producer);
                    db.SaveChanges();
                }

            }
            catch (Exception e)
            {

            }
            return Json(new { Success = true });
        }
    }
}