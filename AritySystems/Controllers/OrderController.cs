using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using AritySystems.Models;
using AritySystems.Data;
using System.Collections.Generic;

namespace AritySystems.Controllers
{
    //[Authorize]
    public class OrderController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OrderLineItems(int OrderId = 0)
        {
            List<OrderLineItem> model = new List<OrderLineItem>();
            
            try
            {
                using (var db = new ArityEntities())
                {
                    ViewBag.OrderName = db.Orders.Where(x => x.Id == OrderId).Select(x=>x.Prefix).FirstOrDefault();
                    ViewBag.OrderDate = db.Orders.Where(x => x.Id == OrderId).Select(x => x.CreatedDate).FirstOrDefault();
                    ViewBag.Status = db.Orders.Where(x => x.Id == OrderId).Select(x => x.Status).FirstOrDefault();
                    model = db.OrderLineItems.Where(x=>x.OrderId == OrderId).ToList();
                    foreach (var item in model)
                    {
                        ViewBag.Total = item.DollarPurchasePrice * item.Quantity;
                    }
                    
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw;
            }
        //    return View();
        }

        public ActionResult SuppliersOrderLineItems(int orderId = 0)
        {
            List<Supplier_Assigned_OrderLineItem> model = new List<Supplier_Assigned_OrderLineItem>();

            try {
                using (var db = new ArityEntities())
                {
                    model = db.Supplier_Assigned_OrderLineItem.Where(x=>x.==)
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return View();
        }
    }
}