using Microsoft.AspNet.Identity;
using ResturantTaskSDk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace ResturantTaskSDk.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult Login()
        {
            User user = new User();
            return View(user);
        }


        [HttpPost]
        public ActionResult Login(User user)
        {
            string name = "ehab";
            string password = "1234";
            if (user.name == name && user.Password == password)
            {
                var id = new ClaimsIdentity(DefaultAuthenticationTypes.ApplicationCookie);
                var ctx = Request.GetOwinContext();
                var authenticationManager = ctx.Authentication;
                authenticationManager.SignIn(id);
                return RedirectToAction("Index", "Home");
            }
            return View(user);

        }

        public ActionResult Logout()
        {
            Request.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Index", "Home");
        }
    }
}