using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {         
            return View();             
        }

        public ActionResult Home()
        {           
           return PartialView("Home");
        }

        [HttpPost]
        public JsonResult getCount(dataModel d)
        {
            dataModel data = new dataModel();
            var count = d.originalValue + 1;
            var response = "";
            if (count % 3 == 0 && count % 5 == 0)
            {
                response = "FizzBuzz";
            }
            else if (count % 3 == 0)
            {
                response = "Fizz";
            }
            else if (count % 5 == 0)
            {
                response = "Buzz";
            }
            else
            {
                response = count.ToString();
            }
            data.countValue = response;
            data.originalValue = count;
           return  Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult About(dataModel d)
        {
            return PartialView("About");
            
        }
        public ActionResult Contact()
        {         
            return PartialView("Contact");
        }
      
    }
}