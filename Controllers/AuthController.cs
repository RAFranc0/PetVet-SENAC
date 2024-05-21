using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PetVetMVC.Models;

namespace PetVetMVC.Controllers
{
    public class AuthController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        
        // POST: /Auth/Login
        [HttpPost]
        public IActionResult Login(string senha)
        {
            if (!string.IsNullOrEmpty(senha) || senha == "000000")
            {
                
                return RedirectToAction("Agenda", "Home");;
            }
            else
            {
               TempData["Error"] = "Senha incorreta.";
                return View("~/Views/Home/Index.cshtml");
            }
        }
    }
}
