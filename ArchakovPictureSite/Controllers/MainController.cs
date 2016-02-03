using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using ArchakovPictureSite.Models;

namespace ArchakovPictureSite.Controllers
{
    public class MainController : Controller
    {
        //
        // GET: /Main/
        public ActionResult MainPage()
        {
            return View();
        }
    }
}
