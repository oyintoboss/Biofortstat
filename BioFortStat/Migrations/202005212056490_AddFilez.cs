namespace BioFortStat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFilez : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ImagesBios", "FileName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ImagesBios", "FileName", c => c.String());
        }
    }
}
