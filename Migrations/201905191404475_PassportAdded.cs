namespace WinAppCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PassportAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Passports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        GivenDate = c.DateTime(nullable: false),
                        GivenOrg = c.String(),
                        ExpireDate = c.DateTime(nullable: false),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("pp.People", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Passports", "PersonId", "pp.People");
            DropIndex("dbo.Passports", new[] { "PersonId" });
            DropTable("dbo.Passports");
        }
    }
}
