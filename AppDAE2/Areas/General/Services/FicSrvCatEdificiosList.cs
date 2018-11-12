using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace AppDAE2.Areas.General.Services
{
    public class FicSrvCatEdificiosList
    {

        HttpClient client;

        public FicSrvCatEdificiosList(HttpClient client)
        {
            this.client = client;
            this.client.BaseAddress = new Uri("http://localhost:51777/");
            this.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }



    }
}
