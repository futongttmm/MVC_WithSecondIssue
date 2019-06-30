namespace MyVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateData : DbMigration
    {
        public override void Up()
        {
            //Sql("Insert Into MembershipTypes Values (1, 'Pay As You Go', 0, 0, 0)");
            //Sql("Insert Into MembershipTypes Values (2, 'Monthly', 30, 1, 90)");
            //Sql("Insert Into MembershipTypes Values (3, 'Seasonly', 90, 3, 80)");
            //Sql("Insert Into MembershipTypes values (4, 'Annually', 120, 12, 70)");
            Sql("insert into Customers values (1, 'ttmm', '1996-10-01', 'true', 3)");
            Sql("insert into Customers values (2, 'lisa', '1977-09-09', 'false', 1)");
            Sql("insert into Customers values (3, 'mary', '1996-06-11', 'true', 2)");
            Sql("insert into Genres values (1, 'action')");
            Sql("insert into Genres values (2, 'romance')");
            Sql("insert into Genres values (3, 'documentary')");
            Sql("insert into Genres values (4, 'cartoon')");
            Sql("insert into Movies values (1, 'die hard', '2000-10-09', '2010-09-08', 1, 5)");
            Sql("insert into Movies values (2, 'shrek!', '2001-10-09', '2016-09-08', 2, 6)");
            Sql("insert into Movies values (3, 'love', '2012-10-09', '2016-09-08', 4, 7)");
            Sql("insert into Movies values (4, 'x man', '1999-10-09', '2015-11-08', 3, 3)");
            Sql("insert into Movies values (5, 'iron man', '2006-10-09', '2013-09-30', 2, 6)");
        }

        public override void Down()
        {
        }
    }
}
