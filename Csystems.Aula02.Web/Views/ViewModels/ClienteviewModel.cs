using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Csystems.Aula02.Web.Views.ViewModels
{
    public class ClienteviewModel
    {
        public int ClienteId { get; set; }

        [StringLength(100)]//não é uma coisa legal rs.
        [Required(ErrorMessage = "Campo nome é obrigatório")]
        public String Nome { get; set; }
        [StringLength(100)]//não é uma coisa legal rs.
        [Required(ErrorMessage = "Campo Fantasia é obrigatório")]
        public String Fantasia { get; set; }

        [StringLength(20)]//não é uma coisa legal rs. :-(...
        [Required(ErrorMessage = "Campo CPF é obrigatório")]
        public String CPF { get; set; }
    }
}