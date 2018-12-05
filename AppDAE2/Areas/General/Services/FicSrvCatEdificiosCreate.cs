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
            edificio.FechaReg = DateTime.Now;
            edificio.FechaUltMod = DateTime.Now;
            edificio.UsuarioReg = "ERNESTO";
            edificio.UsuarioMod = "ERNESTO";
            edificio.Activo = "S";
            edificio.Borrado = "N";

            var json = JsonConvert.SerializeObject(edificio);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var respuestaPost = await client.PostAsync("api/edificios", content);
            if (respuestaPost.IsSuccessStatusCode)
            {
                return edificio;
            }
            return null;
        }

    }

}
