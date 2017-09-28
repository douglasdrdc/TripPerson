using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TripPerson.Web.Controllers
{
    public class PreferenciasController : Controller
    {
        // GET: Preferencias
        public ActionResult CadastroPorSecao()
        {
            return View();
        }

        // GET: Preferencias
        public ActionResult CadastroPorCategoria()
        {
            return View();
        }

        // GET: Preferencias
        public ActionResult CadastroRedesSociais()
        {
            return View();
        }
    }
}