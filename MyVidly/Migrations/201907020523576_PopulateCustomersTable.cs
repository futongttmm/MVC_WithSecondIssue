namespace MyVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomersTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Customers Values ('TTMM', '1996-10-01', 'true', 6)");
            Sql("Insert Into Customers Values ('Lisa', '1997-11-11', 'false', 5)");
            Sql("Insert Into Customers Values ('Mary', '1989-09-08', 'true', 8)");
        }

        public override void Down()
        {
        }
    }
}
