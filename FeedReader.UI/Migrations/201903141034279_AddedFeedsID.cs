namespace FeedReader.UI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFeedsID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subscribes", "FeedID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subscribes", "FeedID");
        }
    }
}
