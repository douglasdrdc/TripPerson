using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Net.Http;
using System.Net.Http.Headers;

using Newtonsoft.Json;

namespace TripPerson.Web.Service
{
    public class ServiceBase
    {
        public const string apiKeyAmadeus = @"aE20qlGQuekHDdhJc0eJYX0lAzvjoAPM";
        public const string apiRootPath = @"http://api.sandbox.amadeus.com/v1.2/";

        public dynamic GetResponse(string caminhoApi)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync(caminhoApi).Result;

                response.EnsureSuccessStatusCode();
                string conteudo =
                    response.Content.ReadAsStringAsync().Result;

                return JsonConvert.DeserializeObject(conteudo);
            }
        }

    }
}