namespace Csystems.Aula02.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Revisaotamannhodecampo : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Cliente", newName: "Clientes");
            AlterColumn("dbo.Clientes", "Nome", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Clientes", "CPF", c => c.String(maxLength: 20, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "CPF", c => c.String(maxLength: 150, unicode: false));
            AlterColumn("dbo.Clientes", "Nome", c => c.String(maxLength: 150, unicode: false));
            RenameTable(name: "dbo.Clientes", newName: "Cliente");
        }
    }
}
