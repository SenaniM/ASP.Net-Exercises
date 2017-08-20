using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyDetails.Controllers
{
    public class HomeController : Controller
    {
       public String name = "Maheshika Weerasinghe";
       public String city = "Kandy";
       public String email = "maheshika@hsenidlanka.com";
       public String desg = "Software Engineer";
       public String company = "hSenid Software International Pvt.";
        public string add = "No. 1/370, Ward Place, Colombo 07 ";
        public string telephone = "011254789";

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Bio()
        {
            ViewBag.Message = "Your application description page.";

            ViewData["myname"] = name;
            ViewData["mycity"] = city;
            ViewData["myemail"] = email;
            ViewData["myocc"] = desg;
            ViewData["mycompany"] = company;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Please refere following ....";

            Models.Contacts cont = new Models.Contacts();
            cont.setName(name);
            cont.setDesignation(desg);
            cont.setCompany(company);
            cont.setAddress(add);
            cont.setPhone(telephone);
            cont.setEmail(email);

            return View(cont);
        }
    }
}