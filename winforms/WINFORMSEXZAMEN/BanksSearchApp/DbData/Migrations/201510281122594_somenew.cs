namespace DbData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class somenew : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceId = c.Long(nullable: false, identity: true),
                        ServiceName = c.String(),
                        Bankomat_BankomatId = c.Long(),
                    })
                .PrimaryKey(t => t.ServiceId)
                .ForeignKey("dbo.Bankomats", t => t.Bankomat_BankomatId)
                .Index(t => t.Bankomat_BankomatId);
            
            DropColumn("dbo.Bankomats", "Services");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bankomats", "Services", c => c.String());
            DropForeignKey("dbo.Services", "Bankomat_BankomatId", "dbo.Bankomats");
            DropIndex("dbo.Services", new[] { "Bankomat_BankomatId" });
            DropTable("dbo.Services");
        }
    }
}
