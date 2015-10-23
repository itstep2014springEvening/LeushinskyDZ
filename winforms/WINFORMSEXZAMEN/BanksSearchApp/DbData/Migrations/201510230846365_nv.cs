namespace DbData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nv : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bankomats",
                c => new
                    {
                        BankomatId = c.Long(nullable: false, identity: true),
                        BankomatName = c.String(),
                        BankOwnerName = c.String(),
                        Telephone = c.String(),
                        Address = c.String(),
                        CoordinateX = c.Double(nullable: false),
                        CoordinateY = c.Double(nullable: false),
                        OpenDate = c.DateTime(nullable: false),
                        WorkingTime = c.String(),
                        PersonalInformation = c.String(),
                        Review = c.String(),
                        Services = c.String(),
                        AdditionalInformation = c.String(),
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
                        BankName = c.String(),
                    })
                .PrimaryKey(t => t.BankId);
            
            CreateTable(
                "dbo.Currencies",
                c => new
                    {
                        CurrencyId = c.Long(nullable: false, identity: true),
                        CurrencyName = c.String(),
                        CurrencyBuyV = c.Double(nullable: false),
                        CurrencySellV = c.Double(nullable: false),
                        Bank_BankId = c.Long(),
                    })
                .PrimaryKey(t => t.CurrencyId)
                .ForeignKey("dbo.Banks", t => t.Bank_BankId)
                .Index(t => t.Bank_BankId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Currencies", "Bank_BankId", "dbo.Banks");
            DropForeignKey("dbo.Bankomats", "Bank_BankId", "dbo.Banks");
            DropIndex("dbo.Currencies", new[] { "Bank_BankId" });
            DropIndex("dbo.Bankomats", new[] { "Bank_BankId" });
            DropTable("dbo.Currencies");
            DropTable("dbo.Banks");
            DropTable("dbo.Bankomats");
        }
    }
}
