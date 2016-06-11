namespace UltimateProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Feedback : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Time = c.DateTime(nullable: false),
                        Email = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Subject = c.String(nullable: false),
                        Message = c.String(nullable: false),
                        UserID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.UserID)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Feedbacks", "UserID", "dbo.AspNetUsers");
            DropIndex("dbo.Feedbacks", new[] { "UserID" });
            DropTable("dbo.Feedbacks");
        }
    }
}
