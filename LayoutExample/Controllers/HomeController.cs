using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LayoutExample.Models;
using LayoutExample.Models.Factories;

namespace LayoutExample.Controllers
{
    public class HomeController : Controller
    {
        HomeFac homeFac = new HomeFac();
        ContactFac contactFac = new ContactFac();

        // GET: Home
        public ActionResult Index()
        {
            Home home = homeFac.GetHome();
            return View(home);
        }

        public ActionResult Contact()
        {
            Contact contact = contactFac.GetContact();
            return View(contact);
        }
    }
}