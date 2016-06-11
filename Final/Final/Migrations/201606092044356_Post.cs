namespace Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Post : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Number", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "Number");
        }
    }
}
