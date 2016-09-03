using System;

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
