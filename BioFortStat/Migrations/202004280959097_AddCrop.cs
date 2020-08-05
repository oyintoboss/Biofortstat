namespace BioFortStat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCrop : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Crops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CropName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Crops");
        }
    }
}
