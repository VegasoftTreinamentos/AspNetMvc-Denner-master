using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Csystems.Aula02.Dominio.Entidades
{
    [Table("Clientes")]//não é uma coisa legal rs.
    public class Cliente
    {
        public int ClienteId { get; set; }
        
        [StringLength(100)]//não é uma coisa legal rs.
        public String Nome { get; set; }

        [StringLength(20)]//não é uma coisa legal rs. :-(...
        public String CPF { get; set; }

    }
}
