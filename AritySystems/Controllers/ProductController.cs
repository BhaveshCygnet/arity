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
using AritySystems.Common;

namespace AritySystems.Controllers
{
    [AllowAnonymous]
    public class ProductController : Controller
    {
        public ActionResult Create(int? Id)
        {
            try
            {
                Product product = new Product();
                ArityEntities dataContext = new ArityEntities();
                product = dataContext.Products.Where(x => x.Id == Id).FirstOrDefault();
                ViewBag.productList = new SelectList(dataContext.Products.Where(x => x.Parent_Id == 0).ToList(), "Id", "English_Name");
                return View(product);
            }

            catch(Exception ex)
            {
                var exception = ex;
                return View();
            }
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            ArityEntities dataContext = new ArityEntities();
            dataContext.Products.Add(product);
            dataContext.SaveChanges();
            return View(product);
        }
    }
}