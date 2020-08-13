using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ByteBank.Forum.ViewModels
{
    public class ContaVerificacaoDoisFatoresViewModel
    {
        [Required]
        [Display(Name ="Token de SMS")]
        public string token { get; set; }

        [Display(Name = "Continuar Logado")]
        public bool ContinuarLogado { get; set; }

        [Display(Name = "Lembrar deste Computador?")]
        public bool LembrarDesteComputador { get; set; }
    }
}