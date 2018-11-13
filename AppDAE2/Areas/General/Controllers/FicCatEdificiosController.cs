using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppDAE2.Areas.General.Services;
using AppDAE2.Models;

namespace AppDAE2.Areas.General.Controllers
{
    [Area("General")]
    public class FicCatEdificiosController : Controller
    {

        FicSrvCatEdificiosList FicServicio;
        List<eva_cat_edificios> FicLista;

        public IActionResult FicViCatEdificiosList()
        {
            try
            {
                FicServicio = new FicSrvCatEdificiosList();
                FicLista = FicServicio.FicGetListCatEdificios().Result;
                ViewBag.Title = "Catalogo de edificios";
                return View(FicLista);
            }
            catch(Exception e)
            {
                throw;
            }
        }

    }
}