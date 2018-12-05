using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using AppDAE2.Models;
using Newtonsoft.Json;

namespace AppDAE2.Areas.General.Services
{
    public class FicSrvCatEdificiosCreate
    {

        HttpClient client;

        public FicSrvCatEdificiosCreate()
        {
            this.client = new HttpClient();
            this.client.BaseAddress = new Uri("http://localhost:51777/");
            this.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public async Task<eva_cat_edificios> FicCatEdificiosCreate(eva_cat_edificios edificio)
        {
            var json = JsonConvert.SerializeObject(edificio);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var respuestaGet = await client.PostAsync("api/edificios", content);
            if (respuestaGet.IsSuccessStatusCode)
            {
                return edificio;
            }
            return null;
        }

    }

}
