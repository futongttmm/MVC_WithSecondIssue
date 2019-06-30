namespace MyVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnToMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Number", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Number");
        }
    }
}
