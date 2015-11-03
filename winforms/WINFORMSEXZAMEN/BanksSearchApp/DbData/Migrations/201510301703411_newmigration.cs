namespace DbData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newmigration : DbMigration
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
                        CityName = c.String(),
                        StreetName = c.String(),
                        HomeNumber = c.String(),
                        CoordinateX = c.Double(nullable: false),
                        CoordinateY = c.Double(nullable: false),
                        OpenDate = c.DateTime(),
                        WorkingTime = c.String(),
                        PersonalInformation = c.String(),
                        Review = c.String(),
                        AdditionalInformation = c.String(),
                        BankId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.BankomatId)
                .ForeignKey("dbo.Banks", t => t.BankId, cascadeDelete: true)
                .Index(t => t.BankId);
            
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
                        BankomatId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.CurrencyId)
                .ForeignKey("dbo.Bankomats", t => t.BankomatId, cascadeDelete: true)
                .Index(t => t.BankomatId);
            
            CreateTable(
                "dbo.BankomatToServices",
                c => new
                    {
                        BankomatToServiceId = c.Long(nullable: false, identity: true),
                        BankomatId = c.Long(nullable: false),
                        ServiceId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.BankomatToServiceId)
                .ForeignKey("dbo.Bankomats", t => t.BankomatId, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .Index(t => t.BankomatId)
                .Index(t => t.ServiceId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceId = c.Long(nullable: false, identity: true),
                        ServiceName = c.String(),
                    })
                .PrimaryKey(t => t.ServiceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BankomatToServices", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.BankomatToServices", "BankomatId", "dbo.Bankomats");
            DropForeignKey("dbo.Currencies", "BankomatId", "dbo.Bankomats");
            DropForeignKey("dbo.Bankomats", "BankId", "dbo.Banks");
            DropIndex("dbo.BankomatToServices", new[] { "ServiceId" });
            DropIndex("dbo.BankomatToServices", new[] { "BankomatId" });
            DropIndex("dbo.Currencies", new[] { "BankomatId" });
            DropIndex("dbo.Bankomats", new[] { "BankId" });
            DropTable("dbo.Services");
            DropTable("dbo.BankomatToServices");
            DropTable("dbo.Currencies");
            DropTable("dbo.Banks");
            DropTable("dbo.Bankomats");
        }
    }
}
