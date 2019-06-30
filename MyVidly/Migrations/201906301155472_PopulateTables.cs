namespace MyVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTables : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into MembershipTypes Values (1, 'Pay As You Go', 0, 0, 0)");
            Sql("Insert Into MembershipTypes Values (2, 'Monthly', 30, 1, 9)");
            Sql("Insert Into MembershipTypes Values (3, 'Seasonly', 90, 3, 8)");
            Sql("Insert Into MembershipTypes Values (4, 'Annually', 120, 12, 7)");
            //Sql("Insert Into Customers Values (1, 'TTMM', 'true', 3)");
            //Sql("Insert Into Customers Values (2, 'Lisa', 'false', 1)");
            //Sql("Insert Into Customers Values (3, 'Mary', 'true', 2)");
            //Sql("Insert Into Genres Values (1, 'Action')");
            //Sql("Insert Into Genres Values (2, 'Romance')");
            //Sql("Insert Into Genres Values (3, 'Documentary')");
            //Sql("Insert Into Genres Values (4, 'Cartoon')");
            //Sql("Insert Into Movies Values (1, 'Die Hard', '2000-10-09', '2010-09-08', 1, 5)");
            //Sql("Insert Into Movies Values (2, 'Shrek!', '2001-10-09', '2016-09-08', 2, 6)");
            //Sql("Insert Into Movies Values (3, 'Love', '2012-10-09', '2016-09-08', 4, 7)");
            //Sql("Insert Into Movies Values (4, 'X Man', '1999-10-09', '2015-11-08', 3, 3)");
            //Sql("Insert Into Movies Values (5, 'Iron Man', '2006-10-09', '2013-09-30', 2, 6)");

        }
        
        public override void Down()
        {
        }
    }
}
