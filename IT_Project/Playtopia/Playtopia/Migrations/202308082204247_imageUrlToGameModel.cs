namespace Playtopia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imageUrlToGameModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "ImageUrl");
        }
    }
}
