using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using IO.Swagger.Model;

using System.Net.Http;
using System.Net.Http.Headers;
using TripPerson.Web.Models;

namespace TripPerson.Web.Service
{
    public class HotelService : ServiceBase
    {
        public List<HotelModel> HotelGeosearchByCircle()
        {
            decimal? latitude = Convert.ToDecimal(-23.5735812);
            decimal? longitude = Convert.ToDecimal(-46.6418569);
            int? radius = 20;
            string checkIn = "2017-11-01";
            string checkOut = "2017-11-02";
            int? numberOfResults = 3;
            string currency = "BRL";
            
            try
            {
                string caminhoApi = @"{0}/hotels/search-circle?latitude={1}&longitude={2}&radius={3}&check_in={4}&check_out={5}&number_of_results={6}&currency={7}&apikey={8}";
                caminhoApi = string.Format(caminhoApi,
                    apiRootPath,
                    latitude.ToString().Replace(",","."),
                    longitude.ToString().Replace(",", "."),
                    radius,
                    checkIn,
                    checkOut,
                    numberOfResults,
                    currency,
                    apiKeyAmadeus);

                List<HotelModel> hotelCollection = Mapping(GetResponse(caminhoApi));
                return hotelCollection;                                  
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<HotelModel> Mapping(dynamic result)
        {
            try
            {
                List<HotelModel> hotelCollection = new List<HotelModel>();
                HotelModel hotel = null;

                int countImg = 1;
                int countSecao = 0;
                List<string> secoes = new List<string>() { "Música", "Gastronomia", "Lazer" };

                foreach (var itemHotel in result.results)
                {
                    hotel = new HotelModel();
                    hotel.HotelCode = itemHotel.property_code != null ? itemHotel.property_code : string.Empty;
                    hotel.Name = itemHotel.property_name != null ? itemHotel.property_name : string.Empty;
                    hotel.Location = new LocationHotelModel()
                    {
                        latitude = itemHotel.location.latitude != null ? itemHotel.location.latitude : string.Empty,
                        longitude = itemHotel.location.longitude != null ? itemHotel.location.longitude : string.Empty
                    };
                    hotel.Address = new AddressHotelModel()
                    {
                        line1 = itemHotel.address.line1 != null ? itemHotel.address.line1 : string.Empty,
                        city = itemHotel.address.city != null ? itemHotel.address.city : string.Empty,
                        postal_code = itemHotel.address.postal_code != null ? itemHotel.address.postal_code : string.Empty,
                        country = itemHotel.address.country != null ? itemHotel.address.country : string.Empty
                    };
                    hotel.Price = new PriceHotelModel()
                    {
                        amount = itemHotel.total_price.amount != null ? itemHotel.total_price.amount : string.Empty,
                        currency = itemHotel.total_price.currency != null ? itemHotel.total_price.currency : string.Empty
                    };

                    hotel.Awards = itemHotel.awards != null && itemHotel.awards.Count > 0 ? itemHotel.awards[0].rating : 0;

                    hotel.Image = string.Format("~/img/hotel{0}.jpg", countImg);
                    countImg++;

                    hotel.SecaoPreferencia = secoes[countSecao];
                    countSecao = countSecao == 2 ? 0 : countSecao + 1;

                    hotelCollection.Add(hotel);
                }

                return hotelCollection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}