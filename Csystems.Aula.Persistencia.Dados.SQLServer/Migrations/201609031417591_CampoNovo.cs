using System.Data.Entity.Migrations;

namespace Csystems.Aula.Persistencia.Dados.SQLServer.Migrations
{
    public partial class CampoNovo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Fantasia", c => c.String(maxLength: 150, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Fantasia");
        }
    }
}
