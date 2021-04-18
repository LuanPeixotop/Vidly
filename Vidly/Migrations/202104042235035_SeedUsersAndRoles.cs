namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsersAndRoles : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'48ebb5a7-b4d7-4ced-af57-f5b389d9e506', N'guest@vidly.com', 0, N'AJfFnqec0MYwNtUV7IJJZSA2lKGVrzCiEYTZP/yv3whQEELA1ylWnQkVuoi8Sh/Png==', N'302eb1c4-3244-440c-9ed9-921e04ae9f41', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ff5f5dec-5d58-49d1-8b7e-41da8b2ab16a', N'admin@vidly.com', 0, N'AF1ND7fJuFGPzVwdZYWkSPB82BGYzMCa1vVjaXzCqoqER/myI9sbBznE1k5t7xnCeA==', N'64167503-0416-4132-8a2a-0f5f22e3dbc6', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'122d2a0f-aac9-4e36-a601-47b601e33277', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ff5f5dec-5d58-49d1-8b7e-41da8b2ab16a', N'122d2a0f-aac9-4e36-a601-47b601e33277')
            ");
        }

        public override void Down()
        {
        }
    }
}
