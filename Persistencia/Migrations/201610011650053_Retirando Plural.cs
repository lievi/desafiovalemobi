namespace Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RetirandoPlural : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Mercadorias", newName: "Mercadoria");
            RenameTable(name: "dbo.Tipoes", newName: "Tipo");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Tipo", newName: "Tipoes");
            RenameTable(name: "dbo.Mercadoria", newName: "Mercadorias");
        }
    }
}
