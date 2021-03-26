namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedGenresNames : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) values (1, 'Comedia')");
            Sql("INSERT INTO Genres (Id, Name) values (2, 'Ação')");
            Sql("INSERT INTO Genres (Id, Name) values (3, 'Animação')");
            Sql("INSERT INTO Genres (Id, Name) values (4, 'Drama')");
        }
        
        public override void Down()
        {
        }
    }
}
