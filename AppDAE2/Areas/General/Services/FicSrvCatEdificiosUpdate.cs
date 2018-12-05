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
    public class FicSrvCatEdificiosUpdate
    {

        HttpClient client;

        public FicSrvCatEdificiosUpdate()
        {
            this.client = new HttpClient();
            this.client.BaseAddress = new Uri("http://localhost:51777/");
            this.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public async Task<eva_cat_edificios> FicCatEdificiosUpdate(eva_cat_edificios edificio)
        {
            var json = JsonConvert.SerializeObject(edificio);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var respuestaPut = await client.PutAsync("api/edificios/"+edificio.IdEdificio, content);
            if (respuestaPut.IsSuccessStatusCode)
            {
                return edificio;
            }
            return null;
        }
    }
}
