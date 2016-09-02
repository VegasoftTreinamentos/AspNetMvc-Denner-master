using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csystems.Aula02.Dominio.Entidades
{
    public class Empresa
    {
        public int EmpresaId { get; set; }

        public String RazaoSocial { get; set; }

        public String Cnpj { get; set; }
    }
}
