namespace BioFortStat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFileName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ImagesBios", "FileName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ImagesBios", "FileName");
        }
    }
}
