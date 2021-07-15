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
            dataModel data = new dataModel();
            return View(data);
        }

        [HttpPost]
        public ActionResult Index(dataModel d)
        {
            dataModel data = new dataModel();
            var count =d.originalValue + 1;
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
            return View(new dataModel() { countValue = response , originalValue = count });
        }
        public ActionResult About(dataModel d)
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