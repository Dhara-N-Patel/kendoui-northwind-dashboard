using Kendo.Mvc.UI;
using System.Collections.Generic;
using System.Linq; 
using System.Web.Mvc;
using Kendo.Mvc;
using Kendo.Mvc.Extensions;
using System.Collections;


namespace KendoUI.Northwind.Dashboard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Projects()
        {
            return View();
        }
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult NotificationSettings()
        {
            return View();
        }
        public ActionResult Settlement()
        {
            //ViewData["employees"] = GetEmployees();
            //ViewData["customers"] = GetCustomers();
            //ViewData["products"] = GetProducts();
            //ViewData["shippers"] = GetShippers();
            return View();
        }

        public ActionResult Budget()
        {
            return View();
        }
        public ActionResult Contracts()
        {
            return View();
        }
        public ActionResult PaymentEstimates()
        {
            return View();
        }
        public ActionResult Inspections()
        {
            return View();
        }
        public ActionResult PaymentRequests()
        {
            return View();
        }
        public ActionResult Resources()
        {
            return View();
        }
        public ActionResult Closeout()
        {
            return View();
        }
    }
}
