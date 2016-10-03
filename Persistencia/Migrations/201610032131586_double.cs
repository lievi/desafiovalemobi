namespace Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _double : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Mercadoria", "ValorMercadoria", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Mercadoria", "ValorMercadoria", c => c.Single(nullable: false));
        }
    }
}
