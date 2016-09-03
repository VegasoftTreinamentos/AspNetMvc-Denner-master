using System.Data.Entity.Migrations;

namespace Csystems.Aula.Persistencia.Dados.SQLServer.Migrations
{
    public partial class Revisãocliente : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "Nome", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.Clientes", "Fantasia", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.Clientes", "CPF", c => c.String(nullable: false, maxLength: 20, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "CPF", c => c.String(maxLength: 20, unicode: false));
            AlterColumn("dbo.Clientes", "Fantasia", c => c.String(maxLength: 150, unicode: false));
            AlterColumn("dbo.Clientes", "Nome", c => c.String(maxLength: 100, unicode: false));
        }
    }
}
