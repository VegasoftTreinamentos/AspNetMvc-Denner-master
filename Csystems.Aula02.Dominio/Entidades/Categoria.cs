using System.Collections.Generic;

namespace Csystems.Aula02.Dominio.Entidades
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string categoria { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
