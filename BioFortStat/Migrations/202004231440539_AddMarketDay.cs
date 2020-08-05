namespace BioFortStat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMarketDay : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MarketDays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Days = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MarketDays");
        }
    }
}
