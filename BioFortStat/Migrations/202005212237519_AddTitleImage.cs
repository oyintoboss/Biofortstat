namespace BioFortStat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTitleImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ImagesBios", "Title", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ImagesBios", "Title");
        }
    }
}
