namespace Persistencia
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Modelo;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class Contexto : DbContext
    {
        // Your context has been configured to use a 'Modelo' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Persistencia.Modelo' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Modelo' 
        // connection string in the application configuration file.
        public Contexto()
            : base("name=Modelo")
        {
            Database.SetInitializer<Contexto>(new MigrateDatabaseToLatestVersion<Contexto, Migrations.Configuration>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Mercadoria> Mercadoria { get; set; }
        public virtual DbSet<Tipo> Tipo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

}