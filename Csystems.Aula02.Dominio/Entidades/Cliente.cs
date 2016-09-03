using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Csystems.Aula02.Dominio.Entidades
{
    [Table("Clientes")]//não é uma coisa legal rs.
    public class Cliente
    {
        public int ClienteId { get; set; }
        public String Nome { get; set; }
        public String Fantasia { get; set; }
        public String CPF { get; set; }

    }
}
