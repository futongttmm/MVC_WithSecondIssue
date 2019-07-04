namespace MyVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers3 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUserRoles]
                   ([UserId]
                   ,[RoleId])
             VALUES
                   ('833bc4ab-27b5-402b-be38-d6128e2ca4f5', '6f0f050e-769c-4f24-ae28-ed0419694fd3')");
        }

        public override void Down()
        {
        }
    }
}
