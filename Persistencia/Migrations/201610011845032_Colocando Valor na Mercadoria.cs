namespace Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColocandoValornaMercadoria : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mercadoria", "ValorMercadoria", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mercadoria", "ValorMercadoria");
        }
    }
}
