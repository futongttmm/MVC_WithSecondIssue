namespace MyVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO[dbo].[AspNetUsers]
                ([Id]
                  ,[Email]
                  ,[EmailConfirmed]
                  ,[PasswordHash]
                  ,[SecurityStamp]
                  ,[PhoneNumber]
                  ,[PhoneNumberConfirmed]
                  ,[TwoFactorEnabled]
                  ,[LockoutEndDateUtc]
                  ,[LockoutEnabled]
                  ,[AccessFailedCount]
                  ,[UserName])
            VALUES
                ('3227d21c-fc51-4233-802a-9da4bca40be1', 'guest@Vidly.com', 0,
                'AAL8GT7ivpKlFnBxfGhNk9vG07cXxdgE0mDTCHJrn5M5tucMSbCCV0s/DO9A4g7mKw==', 
                '66446463-81c2-4514-854c-8ff77788fe97', null, 0, 0, null, 1, 0, 'guest@Vidly.com')");
            Sql(@"
            INSERT INTO[dbo].[AspNetUsers]
                ([Id]
                  ,[Email]
                  ,[EmailConfirmed]
                  ,[PasswordHash]
                  ,[SecurityStamp]
                  ,[PhoneNumber]
                  ,[PhoneNumberConfirmed]
                  ,[TwoFactorEnabled]
                  ,[LockoutEndDateUtc]
                  ,[LockoutEnabled]
                  ,[AccessFailedCount]
                  ,[UserName])
            VALUES
                ('833bc4ab-27b5-402b-be38-d6128e2ca4f5', 'admin@Vidly.com', 0,
                'AA07uMujWlKtEE2CM+GVhRXXsYzp4N7f1tc6AAYUeBngCSigvQSgkkOsOyU6TnkXGA==', 
                '833bc4ab-27b5-402b-be38-d6128e2ca4f5', null, 0, 0, null, 1, 0, 'admin@Vidly.com')");

            //Sql(@"
            //INSERT INTO [dbo].[AspNetRoles]
            //       ([Id]
            //       ,[Name])
            // VALUES
            //    ('6f0f050e-769c-4f24-ae28-ed0419694fd3', 'CanManageMovies')");

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
