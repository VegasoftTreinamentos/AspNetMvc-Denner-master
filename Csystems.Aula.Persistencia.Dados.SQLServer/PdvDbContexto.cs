using Csystems.Aula02.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csystems.Aula.Persistencia.Dados.SQLServer
{
    public class PdvDbContexto : DbContext
    {
        public virtual IDbSet<Produto> Produtos { get; set; }
        public virtual IDbSet<Categoria> Categorias { get; set; }
        //public virtual IDbSet<Empresa> Empresas { get; set; }
        public PdvDbContexto()
            : base("DefaultConnection")
        {
            //Database.SetInitializer(new PreparaDbcontexto());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.ReflectedType != null && p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(150));

            base.OnModelCreating(modelBuilder);

        }

    }
    

}
