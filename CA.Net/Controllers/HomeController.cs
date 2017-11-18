using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaptchaMvc.HtmlHelpers;  

namespace CA.Net.Controllers
{
    using System.Runtime.ExceptionServices;

    using CA.BusinessLogic;
    using CA.DataAccess;

    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult Contact()
        {

            return View();
            
        }
        [HttpPost]    
        public ActionResult Contact(Contact newContact)
        {

                if (ModelState.IsValid)
                {
                    var contactRepository = new ContactRepository();
                    string resultID = contactRepository.InsertAddToDatabase(newContact);
                    return View("ThankYou", newContact);
                }
                else
                {
                    return View();
         }
        }

    }
}