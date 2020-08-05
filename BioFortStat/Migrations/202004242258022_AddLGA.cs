namespace BioFortStat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLGA : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LGAs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LGAValue = c.String(),
                        LGAName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LGAs");
        }
    }
}
