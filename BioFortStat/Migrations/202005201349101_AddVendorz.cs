namespace BioFortStat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVendorz : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VendorUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 15),
                        LastName = c.String(maxLength: 15),
                        GenderTypez = c.String(),
                        PhoneNumber = c.String(maxLength: 20),
                        BusinessName = c.String(maxLength: 25),
                        BusinessAddress = c.String(maxLength: 50),
                        ProductSold = c.String(maxLength: 70),
                        ProfilePicture = c.String(),
                        LGA = c.String(maxLength: 30),
                        State = c.String(maxLength: 20),
                        CreatedDate = c.DateTime(nullable: false),
                        Gender_Id = c.Int(),
                        StateType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genders", t => t.Gender_Id)
                .ForeignKey("dbo.States", t => t.StateType_Id)
                .Index(t => t.Gender_Id)
                .Index(t => t.StateType_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VendorUsers", "StateType_Id", "dbo.States");
            DropForeignKey("dbo.VendorUsers", "Gender_Id", "dbo.Genders");
            DropIndex("dbo.VendorUsers", new[] { "StateType_Id" });
            DropIndex("dbo.VendorUsers", new[] { "Gender_Id" });
            DropTable("dbo.VendorUsers");
        }
    }
}
