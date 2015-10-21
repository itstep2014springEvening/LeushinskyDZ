namespace DbData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class str2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Currencies",
                c => new
                    {
                        CurrencyId = c.Long(nullable: false, identity: true),
                        CurrencyName = c.String(),
                        CurrencyBuyV = c.Double(nullable: false),
                        CurrencySellV = c.Double(nullable: false),
                        Bankomats_BankomatId = c.Long(),
                    })
                .PrimaryKey(t => t.CurrencyId)
                .ForeignKey("dbo.Bankomats", t => t.Bankomats_BankomatId)
                .Index(t => t.Bankomats_BankomatId);
            
            DropColumn("dbo.Bankomats", "CurrencyName");
            DropColumn("dbo.Bankomats", "CurrencyValueB");
            DropColumn("dbo.Bankomats", "CurrencyValueS");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bankomats", "CurrencyValueS", c => c.String());
            AddColumn("dbo.Bankomats", "CurrencyValueB", c => c.String());
            AddColumn("dbo.Bankomats", "CurrencyName", c => c.String());
            DropForeignKey("dbo.Currencies", "Bankomats_BankomatId", "dbo.Bankomats");
            DropIndex("dbo.Currencies", new[] { "Bankomats_BankomatId" });
            DropTable("dbo.Currencies");
        }
    }
}
