using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PetVetMVC.Models
{
    public class AgendamentoViewModel
    {
        [DisplayName("Nome")]
        [MinLength(3, ErrorMessage = "Nome deve ter no mínimo 3 caracteres!")]
        [Required(ErrorMessage = "O campo Nome é obrigatório!")]
        public string Nome { get; set; }

        [DisplayName("Telefone")]
        [MinLength(10, ErrorMessage = "Telefone deve ter no mínimo 10 caracteres!")]
        [Required(ErrorMessage = "O campo Telefone é obrigatório!")]
        public string Telefone { get; set; }

        [DisplayName("E-mail")]
        [EmailAddress(ErrorMessage = "Digite um E-mail válido: ----@----.com")]
        [Required(ErrorMessage = "O campo E-mail é obrigatório!")]
        public string Email { get; set; }

        public DateTime Data = DateTime.Now;

        [DisplayName("Animal")]
        [Required(ErrorMessage = "O campo Animal é obrigatório!")]
        public string Animal { get; set; }

        [DisplayName("Necessidade")]
        [MinLength(10, ErrorMessage = "Necessidade deve ter no mínimo 10 caracteres!")]
        [Required(ErrorMessage = "O campo Necessidade é obrigatório!")]        
        public string Necessidade { get; set; }
    }
}
