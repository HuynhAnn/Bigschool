namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFollowingsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fllowings",
                c => new
                    {
                        FllowerId = c.String(nullable: false, maxLength: 128),
                        FlloweeId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.FllowerId, t.FlloweeId })
                .ForeignKey("dbo.AspNetUsers", t => t.FllowerId)
                .ForeignKey("dbo.AspNetUsers", t => t.FlloweeId)
                .Index(t => t.FllowerId)
                .Index(t => t.FlloweeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fllowings", "FlloweeId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Fllowings", "FllowerId", "dbo.AspNetUsers");
            DropIndex("dbo.Fllowings", new[] { "FlloweeId" });
            DropIndex("dbo.Fllowings", new[] { "FllowerId" });
            DropTable("dbo.Fllowings");
        }
    }
}
