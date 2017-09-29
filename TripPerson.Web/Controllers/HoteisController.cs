using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripPerson.Web.Models;
using TripPerson.Web.Service;

namespace TripPerson.Web.Controllers
{
    public class HoteisController : Controller
    {
        // GET: Hoteis
        public ActionResult Pesquisa()
        {
            HotelService service = new HotelService();
            List<HotelModel> hotelCollection = service.HotelGeosearchByCircle();
            if (hotelCollection != null)
            {
                return View(hotelCollection);
            }
            else
            {
                ViewData["StatusMessage"] = "Desculpe mas não encontramos hotéis nesta região.";
            }
            
            return View();
        }
    }
}