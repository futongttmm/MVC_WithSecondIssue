namespace MyVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAvailableNumberToMoviesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "AvailableNumber", c => c.Int(nullable: false));

            Sql("Update Movies Set AvailableNumber = Number");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "AvailableNumber");
        }
    }
}
