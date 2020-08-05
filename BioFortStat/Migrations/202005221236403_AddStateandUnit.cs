namespace BioFortStat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStateandUnit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "StateTypes_Id", c => c.Int());
            AddColumn("dbo.Products", "UnitTypes_Id", c => c.Int());
            CreateIndex("dbo.Products", "StateTypes_Id");
            CreateIndex("dbo.Products", "UnitTypes_Id");
            AddForeignKey("dbo.Products", "StateTypes_Id", "dbo.States", "Id");
            AddForeignKey("dbo.Products", "UnitTypes_Id", "dbo.ProductUnits", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "UnitTypes_Id", "dbo.ProductUnits");
            DropForeignKey("dbo.Products", "StateTypes_Id", "dbo.States");
            DropIndex("dbo.Products", new[] { "UnitTypes_Id" });
            DropIndex("dbo.Products", new[] { "StateTypes_Id" });
            DropColumn("dbo.Products", "UnitTypes_Id");
            DropColumn("dbo.Products", "StateTypes_Id");
        }
    }
}
