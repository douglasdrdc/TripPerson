using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TripPerson.Web.Controllers
{
    public class ViajanteController : Controller
    {
        // GET: Viajante
        public ActionResult CadastroDadosBasicos()
        {
            return View();
        }
    }
}