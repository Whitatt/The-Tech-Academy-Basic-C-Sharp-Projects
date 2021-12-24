using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(String firstname, String lastname, String emailaddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailaddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                string connectionString = @Data Source = DESKTOP - A2A72J6\SQLEXPRESS; Initial Catalog = Newsletter; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False


                string queryString = @"INSERT INTO Signup (FirstName, LastName, EmailAddress) VALUES (@FirstName, @LastName, @EmailAddress)";
                return View("Success");
            }
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