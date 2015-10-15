namespace banksearchapp_Ivan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _777 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bankomats",
                c => new
                    {
                        BankomatId = c.Long(nullable: false, identity: true),
                        Bank_BankId = c.Long(),
                    })
                .PrimaryKey(t => t.BankomatId)
                .ForeignKey("dbo.Banks", t => t.Bank_BankId)
                .Index(t => t.Bank_BankId);
            
            CreateTable(
                "dbo.Banks",
                c => new
                    {
                        BankId = c.Long(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.BankId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bankomats", "Bank_BankId", "dbo.Banks");
            DropIndex("dbo.Bankomats", new[] { "Bank_BankId" });
            DropTable("dbo.Banks");
            DropTable("dbo.Bankomats");
        }
    }
}
