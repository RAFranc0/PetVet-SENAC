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
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Servicos()
        {
            return View();
        }

        public IActionResult Agendamento(AgendamentoViewModel agendamento)
        {
            return View(agendamento);
        }

        public IActionResult ConfirmarAgendamento()
        {
            return View("Concluido");
        }

        public IActionResult Agenda()
        {
            List<AgendamentoViewModel> listaDeAgendamentos = AgendaViewModel.Listar();
            return View("Agenda", listaDeAgendamentos);
        }

        [HttpPost]
        public IActionResult EnviarAgendamento(AgendamentoViewModel agendamento)
        {
            if (!ModelState.IsValid)
            {
                ViewData["mensagem"] = "Informações inválidas";
                return View("Agendamento", agendamento);
            }

            AgendaViewModel.Inserir(agendamento);
            return View("ConfirmarAgendamento", agendamento);

            /*return RedirectToAction("ConfirmarAgendamento", new { agendamento = agendamento });*/
        }

        /*public IActionResult Acesso(AcessoViewModel Acesso)
        {
            string Pw = Acesso.Password;
            string MPw = AcessoViewModel.MPw();

            if(string.IsNullOrEmpty(Pw) || Pw != MPw)
            {
                ViewData["pass"] = "Senha incorreta!";
                return View("Index");
            }

            return View("Agenda");
        }*/
    }
}
