namespace BioFortStat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductPrice = c.String(),
                        ProductQuantity = c.Int(nullable: false),
                        ProductUnit = c.String(),
                        State = c.String(),
                        LGA = c.String(),
                        ZipCode = c.Int(nullable: false),
                        ProductPicture = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
