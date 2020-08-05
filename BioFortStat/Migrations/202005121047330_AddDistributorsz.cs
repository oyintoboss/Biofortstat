namespace BioFortStat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDistributorsz : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Users", c => c.String(nullable: false));
            DropColumn("dbo.AspNetUsers", "RoleName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "RoleName", c => c.String(nullable: false));
            DropColumn("dbo.AspNetUsers", "Users");
        }
    }
}
