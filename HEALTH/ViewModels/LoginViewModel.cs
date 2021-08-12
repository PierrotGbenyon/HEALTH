using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HEALTH.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Nom d'utilisateur requis. Veuillez réessayer"), Display(Name ="Nom d'utilisateur", Description ="Veuillez entrer le nom d'utilisateur")]
        public string LoginUser { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Mot de passe requis. Veuillez réessayer"), Display(Name = "Mot de passe", Description = "Mot de passe")]
        public string LoginPassword { get; set; }
        public string ReturnUrl { get; set; }
    }
}
