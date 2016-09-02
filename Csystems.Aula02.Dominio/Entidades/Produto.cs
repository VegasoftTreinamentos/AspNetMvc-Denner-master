using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csystems.Aula02.Dominio.Entidades
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        public String Descricao { get; set; }


        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
    }
}
