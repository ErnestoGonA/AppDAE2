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
    public class FicSrvCatEdificiosList
    {

        HttpClient client;      

        public FicSrvCatEdificiosList()
        {
            this.client = new HttpClient();
            this.client.BaseAddress = new Uri("http://localhost:51777/");
            this.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<eva_cat_edificios>> FicGetListCatEdificios()
        {
            HttpResponseMessage FicResponse = await this.client.GetAsync("api/edificios");
            if (FicResponse.IsSuccessStatusCode)
            {
                var FicRespuesta = await FicResponse.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<eva_cat_edificios>>(FicRespuesta);
            }
            //return null;
            return new List<eva_cat_edificios>();
        }

        public async Task<string> FicCatEdificiosDelete(short id)
        {
            HttpResponseMessage res = await this.client.DeleteAsync("api/edificios/" + id);
            return res.IsSuccessStatusCode ? "OK":"ERROR";
        }

    }
}
