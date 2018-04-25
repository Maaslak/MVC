using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class SongsController : Controller
    {
        // GET: Songs
        public ActionResult Index()
        {
            Song song = new Song("Lift Your Skinny Fist Like Anthenas to Heaven", "Godspeed", "Ambient", 0);
            return View(song);
        }

        // GET: Songs/Square/

        public ActionResult Square(int id)
        {
            return Content((id * id).ToString());
        }
    }
}