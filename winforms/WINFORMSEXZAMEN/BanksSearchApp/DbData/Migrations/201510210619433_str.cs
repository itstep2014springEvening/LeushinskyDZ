namespace DbData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class str : DbMigration
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
                        CurrencyName = c.String(),
                        CurrencyValueB = c.String(),
                        CurrencyValueS = c.String(),
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
