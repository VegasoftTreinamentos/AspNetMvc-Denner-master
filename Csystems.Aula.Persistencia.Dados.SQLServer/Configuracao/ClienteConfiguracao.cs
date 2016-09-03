using System.Data.Entity.ModelConfiguration;
using Csystems.Aula02.Dominio.Entidades;

namespace Csystems.Aula.Persistencia.Dados.SQLServer.Configuracao
{
    public class ClienteConfiguracao : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguracao()
        {
            ToTable("Clientes");
            HasKey(c => c.ClienteId);

            Property(c => c.Nome).IsRequired().HasMaxLength(100);

            Property(c => c.Fantasia).IsRequired().HasMaxLength(100);

            Property(c => c.CPF).IsRequired().HasMaxLength(20);
        }
    }
}
