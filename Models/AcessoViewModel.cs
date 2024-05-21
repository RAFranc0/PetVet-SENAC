using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PetVetMVC.Models
{
    public class AcessoViewModel
    {
        private static string MasterPassword = "000000";

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public static string MPw()
        {
            return MasterPassword;
        }
    }
}