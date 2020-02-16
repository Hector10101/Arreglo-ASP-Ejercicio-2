using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArreglosASP.Models;
using Microsoft.AspNetCore.Mvc;
using ArreglosASP.Funtions;

namespace ArreglosASP.Controllers
{
    public class InicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Numeros numeros)
        {
            ViewData["NumMayor"] = FuntionMM.Mayor(numeros.Numero);
            ViewData["NumMenor"] = FuntionMM.Menor(numeros.Numero);
            
            return View();
        }
    }
}