using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TripPerson.Web.Models
{
    public class HotelModel
    {
        public string HotelCode { get; set; }
        public string Name { get; set; }
        public LocationHotelModel Location { get; set; }
        public AddressHotelModel Address { get; set; }
        public PriceHotelModel Price { get; set; }
                
        public int Awards { get; set; }

        public string Image { get; set; }
    }

    public class LocationHotelModel
    {
        public double? latitude { get; set; }
        public double? longitude { get; set; }
    }

    public class AddressHotelModel
    {
        public string line1 { get; set; }
        public string city { get; set; }
        public string postal_code { get; set; }
        public string country { get; set; }
    }

    public class PriceHotelModel
    {
        public double? amount { get; set; }
        public string currency { get; set; }
    }

    




}