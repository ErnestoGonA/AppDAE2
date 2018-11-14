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
        FicSrvCatEdificiosDetail servicioDetail;
        List<eva_cat_edificios> FicLista;
        eva_cat_edificios edificio;

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

        public IActionResult FicViCatEdificiosDetail(short id)
        {
            try
            {
                servicioDetail = new FicSrvCatEdificiosDetail();
                edificio = servicioDetail.FicGetCatEdificiosDetail(id).Result;
                ViewBag.Title = "Detalle Edificio";      
                return View(edificio);
            }
            catch (Exception e)
            {
                throw;
            }
        }

    }
}