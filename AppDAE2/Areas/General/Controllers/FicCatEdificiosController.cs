using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppDAE2.Areas.General.Services;

namespace AppDAE2.Areas.General.Controllers
{
    //Se tiene que llamar igual que la carpeta de view
    public class FicCatEdificiosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}