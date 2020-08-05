namespace BioFortStat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPrice : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Prices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MarketName = c.String(),
                        ProductName = c.String(),
                        ProductQuantity = c.String(),
                        ProductPrice = c.String(),
                        SameasPrevious = c.Boolean(nullable: false),
                        CreatedBy = c.String(),
                        Unit = c.String(),
                        PickedDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Prices");
        }
    }
}
