namespace Playtopia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class priceToGame : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "price");
        }
    }
}
