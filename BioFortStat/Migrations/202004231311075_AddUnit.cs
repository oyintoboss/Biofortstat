namespace BioFortStat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUnit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductUnits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UnitValue = c.String(),
                        UnitName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.States");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.States",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        stateValue = c.String(),
                        StateName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.ProductUnits");
        }
    }
}
