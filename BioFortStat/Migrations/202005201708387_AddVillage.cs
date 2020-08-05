namespace BioFortStat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVillage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VendorUsers", "Village", c => c.String(maxLength: 35));
        }
        
        public override void Down()
        {
            DropColumn("dbo.VendorUsers", "Village");
        }
    }
}
