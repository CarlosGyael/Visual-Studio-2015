namespace Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initcreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ImageSize", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "FileName", c => c.String());
            AddColumn("dbo.AspNetUsers", "ImageData", c => c.Binary());
            AddColumn("dbo.AspNetUsers", "Score", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Score");
            DropColumn("dbo.AspNetUsers", "ImageData");
            DropColumn("dbo.AspNetUsers", "FileName");
            DropColumn("dbo.AspNetUsers", "ImageSize");
        }
    }
}
