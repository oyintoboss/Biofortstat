namespace BioFortStat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMarket : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Markets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MarketName = c.String(),
                        MarketDescription = c.String(),
                        MarketDays = c.String(),
                        MainProducts = c.String(),
                        MarketState = c.String(),
                        MarketLGA = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Markets");
        }
    }
}
