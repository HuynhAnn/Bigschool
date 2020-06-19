namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyFollowing : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Fllowings", newName: "Followings");
            RenameColumn(table: "dbo.Followings", name: "FllowerId", newName: "FollowerId");
            RenameColumn(table: "dbo.Followings", name: "FlloweeId", newName: "FolloweeId");
            RenameIndex(table: "dbo.Followings", name: "IX_FllowerId", newName: "IX_FollowerId");
            RenameIndex(table: "dbo.Followings", name: "IX_FlloweeId", newName: "IX_FolloweeId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Followings", name: "IX_FolloweeId", newName: "IX_FlloweeId");
            RenameIndex(table: "dbo.Followings", name: "IX_FollowerId", newName: "IX_FllowerId");
            RenameColumn(table: "dbo.Followings", name: "FolloweeId", newName: "FlloweeId");
            RenameColumn(table: "dbo.Followings", name: "FollowerId", newName: "FllowerId");
            RenameTable(name: "dbo.Followings", newName: "Fllowings");
        }
    }
}
