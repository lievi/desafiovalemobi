namespace Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Colocandovalidação : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Mercadoria", "NomeMercadoria", c => c.String());
            AlterColumn("dbo.Mercadoria", "TipoNegocio", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Mercadoria", "TipoNegocio", c => c.String());
            AlterColumn("dbo.Mercadoria", "NomeMercadoria", c => c.String());
        }
    }
}
