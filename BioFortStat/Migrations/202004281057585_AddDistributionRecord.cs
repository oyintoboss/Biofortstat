namespace BioFortStat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDistributionRecord : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DistributionRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Crop = c.String(),
                        Indicator = c.String(),
                        Year = c.Int(nullable: false),
                        State = c.String(),
                        Value = c.Int(nullable: false),
                        createdUser = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DistributionRecords");
        }
    }
}
