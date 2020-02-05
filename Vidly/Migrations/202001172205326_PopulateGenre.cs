namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Movies", new[] { "Genre_ID" });
            CreateIndex("dbo.Movies", "Genre_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Movies", new[] { "Genre_Id" });
            CreateIndex("dbo.Movies", "Genre_ID");
        }
    }
}
