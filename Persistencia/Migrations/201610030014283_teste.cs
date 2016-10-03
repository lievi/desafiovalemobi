namespace Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Mercadoria", "TipoNegocio", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Mercadoria", "TipoNegocio", c => c.String(nullable: false));
        }
    }
}
