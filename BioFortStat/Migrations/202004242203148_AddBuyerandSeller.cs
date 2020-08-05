namespace BioFortStat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBuyerandSeller : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BuyerAndSellers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryValue = c.String(),
                        Product = c.String(),
                        Quantity = c.Int(nullable: false),
                        Unit = c.String(),
                        Availability = c.DateTime(nullable: false),
                        Price = c.String(),
                        Village = c.String(),
                        LGAValue = c.String(),
                        State = c.String(),
                        ProfilePicture = c.String(),
                        ZipCode = c.Int(nullable: false),
                        Negotiable = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BuyerAndSellers");
        }
    }
}
