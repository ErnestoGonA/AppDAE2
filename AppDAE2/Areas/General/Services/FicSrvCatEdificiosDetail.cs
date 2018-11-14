using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using AppDAE2.Models;
using Newtonsoft.Json;

namespace AppDAE2.Areas.General.Services
{
    public class FicSrvCatEdificiosDetail
    {
        HttpClient client;

        public FicSrvCatEdificiosDetail()
        {
            this.client = new HttpClient();
            this.client.BaseAddress = new Uri("http://localhost:51777/");
            this.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public async Task<eva_cat_edificios> FicGetCatEdificiosDetail(short id)
        {
            HttpResponseMessage response = await this.client.GetAsync("api/edificios/" + id);
            if (response.IsSuccessStatusCode)
            {
                var respuesta = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<eva_cat_edificios>(respuesta);
            }
            return new eva_cat_edificios();
        }


    }
}
