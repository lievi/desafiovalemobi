namespace Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class String : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE dbo.Mercadoria DROP CONSTRAINT DF__Mercadori__Valor__4CA06362");
            AlterColumn("dbo.Mercadoria", "ValorMercadoria", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Mercadoria", "ValorMercadoria", c => c.Double(nullable: false));
        }
    }
}
