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
using System.Web.Security;
using System.Security.Principal;
using AritySystems.Data;

namespace AritySystems.Controllers
{
    //[Authorize]
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult Login(string ReturnUrl)
        {
            string returnURL = string.Empty;
            try
            {
                // We do not want to use any existing identity information  
                EnsureLoggedOut();

                // Store the originating URL so we can attach it to a form field  
                returnURL = ReturnUrl;

                return View(returnURL);
            }
            catch
            {
                throw;
            }
        }

        //GET: EnsureLoggedOut  
        private void EnsureLoggedOut()
        {
            // If the request is (still) marked as authenticated we send the user to the logout action  
            if (Request.IsAuthenticated)
                Logout();
        }



        //POST: Logout  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Logout()
        {
            try
            {
                // First we clean the authentication ticket like always  
                //required NameSpace: using System.Web.Security;  
                FormsAuthentication.SignOut();

                // Second we clear the principal to ensure the user does not retain any authentication  
                //required NameSpace: using System.Security.Principal;  
                HttpContext.User = new GenericPrincipal(new GenericIdentity(string.Empty), null);

                Session.Clear();
                System.Web.HttpContext.Current.Session.RemoveAll();

                // Last we redirect to a controller/action that requires authentication to ensure a redirect takes place  
                // this clears the Request.IsAuthenticated flag since this triggers a new request  
                return RedirectToAction("Login", "User");
            }
            catch
            {
                throw;
            }
        }

        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel entity)
        {
           
            try
            {
                using (var db = new ArityEntities())
                {
                    if (!ModelState.IsValid)
                        return View(entity);

                    //check user credentials
                    var userInfo = db.Users.Where(s => s.EmailId == entity.Email.Trim() && s.Password == entity.Password.Trim()).FirstOrDefault();
                    
                    if (userInfo != null)
                    {

                        //Set A Unique name in session  
                        Session["Username"] = entity.Email;
                        
                        return RedirectToAction("Index", "Order","Order");  
                       
                    }
                    else
                    {
                        //Login Fail  
                        TempData["ErrorMSG"] = "Access Denied! Wrong Credential";
                        return View(entity);
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}