namespace MyVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers2 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetRoles]
                   ([Id]
                   ,[Name])
             VALUES
                ('6f0f050e-769c-4f24-ae28-ed0419694fd3', 'CanManageMovies')");

            //Sql(@"
            //INSERT INTO [dbo].[AspNetUserRoles]
            //       ([UserId]
            //       ,[RoleId])
            // VALUES
            //       ('382ea94f-ec0d-4c47-88ec-4c8d6cbfdc07', '6f0f050e-769c-4f24-ae28-ed0419694fd3')");
        }

        public override void Down()
        {
        }
    }
}
