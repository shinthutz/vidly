namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            //somehow the Id got identity
            Sql("INSERT INTO Genres (Name) VALUES ('Action')");
            Sql("INSERT INTO Genres (Name) VALUES ('Adventure')");
            Sql("INSERT INTO Genres (Name) VALUES ('Comedy')");
            Sql("INSERT INTO Genres (Name) VALUES ('Drama')");
            Sql("INSERT INTO Genres (Name) VALUES ('Horror')");
            Sql("INSERT INTO Genres (Name) VALUES ('Musicals')");
            Sql("INSERT INTO Genres (Name) VALUES ('Science Fiction')");
            Sql("INSERT INTO Genres (Name) VALUES ('War')");
            Sql("INSERT INTO Genres (Name) VALUES ('Western')");
        }
        
        public override void Down()
        {
        }
    }
}
