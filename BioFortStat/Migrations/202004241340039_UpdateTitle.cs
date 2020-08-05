namespace BioFortStat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTitle : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.UserInformations");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserInformations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        MiddleName = c.String(),
                        Mobile = c.String(),
                        LGA = c.String(),
                        ZipCode = c.Int(nullable: false),
                        Passport = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
