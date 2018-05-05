//using KendoUI.Northwind.Dashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Data;
using System.Data.Entity;
//using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using KendoUI.Northwind.Dashboard.Models;
using kendoui_northwind_dashboard.Models;

namespace KendoUI.Northwind.Dashboard.Controllers
{
    public class CustomersController : Controller
    {
        public JsonResult Customers_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetCustomers().ToDataSourceResult(request));
        }

        public ActionResult Customers_Create([DataSourceRequest]DataSourceRequest request, CustomerViewModel customer)
        {
            if (ModelState.IsValid)
            {
                using (var northwind = new NorthwindEntities())
                {
                    var entity = new Customer
                    {
                        CustomerID = Guid.NewGuid().ToString().Substring(0,5),
                        CompanyName = customer.CompanyName,
                        Country = customer.Country,
                        City = customer.City,
                        ContactName = customer.ContactName,
                        Phone = customer.Phone,
                    };
                    northwind.Customers.Add(entity);
                    northwind.SaveChanges();
                    customer.CustomerID = entity.CustomerID;
                }
            }
            return Json(new[] { customer }.ToDataSourceResult(request));
        }

        public ActionResult Customers_Update([DataSourceRequest]DataSourceRequest request, CustomerViewModel customer)
        {
            if (ModelState.IsValid)
            {
                using (var northwind = new NorthwindEntities())
                {
                    var entity = new Customer
                    {
                        CustomerID = customer.CustomerID,
                        CompanyName = customer.CompanyName,
                        Country = customer.Country,
                        City = customer.City,
                        ContactName = customer.ContactName,
                        Phone = customer.Phone,
                    };
                    northwind.Customers.Attach(entity);
                    northwind.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                    northwind.SaveChanges();
                }
            }
            return Json(new[] { customer }.ToDataSourceResult(request));
        }

        public ActionResult Customers_Destroy([DataSourceRequest]DataSourceRequest request, CustomerViewModel customer)
        {
            if (ModelState.IsValid)
            {
                using (var northwind = new NorthwindEntities())
                {
                    var entity = new Customer
                    {
                        CustomerID = customer.CustomerID,
                        CompanyName = customer.CompanyName,
                        Country = customer.Country,
                        City = customer.City,
                        ContactName = customer.ContactName,
                        Phone = customer.Phone,
                    };
                    northwind.Customers.Attach(entity);
                    northwind.Customers.Remove(entity);
                    northwind.SaveChanges();
                }
            }
            return Json(new[] { customer }.ToDataSourceResult(request));
        } 

        private static IEnumerable<CustomerViewModel> GetCustomers()
        {
            var northwind = new NorthwindEntities();
            var customers = northwind.Customers.Select(customer => new CustomerViewModel
            {
                CustomerID = customer.CustomerID,
                CompanyName = customer.CompanyName,
                ContactName = customer.ContactName,
                City = customer.City,
                Country = customer.Country,
                Phone = customer.Phone
            });

            return customers;
        }

    }
}
