namespace MyVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTables : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into MembershipTypes Values ('Pay As You Go', 0, 0, 0)");
            Sql("Insert Into MembershipTypes Values ('Monthly', 30, 1, 9)");
            Sql("Insert Into MembershipTypes Values ('Seasonly', 90, 3, 8)");
            Sql("Insert Into MembershipTypes Values ('Annually', 120, 12, 7)");
            //Sql("Insert Into Customers Values ('TTMM', 'true', 3)");
            //Sql("Insert Into Customers Values ('Lisa', 'false', 1)");
            //Sql("Insert Into Customers Values ('Mary', 'true', 2)");
            //Sql("Insert Into Genres Values ('Action')");
            //Sql("Insert Into Genres Values ('Romance')");
            //Sql("Insert Into Genres Values ('Documentary')");
            //Sql("Insert Into Genres Values ('Cartoon')");
            //Sql("Insert Into Movies Values ('Die Hard', '2000-10-09', '2010-09-08', 1, 5)");
            //Sql("Insert Into Movies Values ('Shrek!', '2001-10-09', '2016-09-08', 2, 6)");
            //Sql("Insert Into Movies Values ('Love', '2012-10-09', '2016-09-08', 4, 7)");
            //Sql("Insert Into Movies Values ('X Man', '1999-10-09', '2015-11-08', 3, 3)");
            //Sql("Insert Into Movies Values ('Iron Man', '2006-10-09', '2013-09-30', 2, 6)");
        }
        
        public override void Down()
        {
        }
    }
}
