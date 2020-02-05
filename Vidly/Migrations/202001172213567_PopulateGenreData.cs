namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreData : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON");
            Sql("INSERT INTO Genres (ID, Name) VALUES (1,'Comedy')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (2,'Action')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (3,'Family')");
            Sql("INSERT INTO Genres (ID, Name) VALUES (4,'Romance')");
            Sql("SET IDENTITY_INSERT Genres OFF");
        }
        
        public override void Down()
        {
        }
    }
}
