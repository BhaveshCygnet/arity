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

            catch (Exception ex)
            {
                var exception = ex;
                return View();
            }
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            ArityEntities dataContext = new ArityEntities();
            if (product.Parent_Id == null) product.Parent_Id = 0;
            dataContext.Products.Add(product);
            dataContext.SaveChanges();
            return View(product);
        }

        public ActionResult List()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ProductList()
        {
            ArityEntities dataContext = new ArityEntities();

            var productList = (from product in dataContext.Products.ToList()
                            select new
                            {
                                Id = product.Id,
                                Chinese_Name = product.Chinese_Name,
                                English_Name = product.English_Name,
                                Quantity = product.Quantity,
                                Dollar_Price = product.Dollar_Price,
                                RMB_Price = product.RMB_Price,
                                Unit = product.Unit,
                                Description = product.Description,
                                ModifiedDate = product.ModifiedDate
                            }).ToList();

            return Json(new { data = productList }, JsonRequestBehavior.AllowGet);
            ///return View(productList,JsonRequestBehavior.AllowGet);
        }
    }
}