using System;
using System.Collections.Generic;   

namespace PetVetMVC.Models
{
    public class AgendaViewModel
    {
        private static List<AgendamentoViewModel> agenda;

        static AgendaViewModel()
        {
            agenda = new List<AgendamentoViewModel>();
        }

        public static void Inserir(AgendamentoViewModel agendamento)
        {
            agenda.Add(agendamento);
        }

        public static List<AgendamentoViewModel> Listar()
        {
            return agenda;
        }
    }
}