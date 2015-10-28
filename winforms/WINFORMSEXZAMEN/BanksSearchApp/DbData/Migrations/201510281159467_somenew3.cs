namespace DbData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class somenew3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Services", "Bankomat_BankomatId", "dbo.Bankomats");
            DropIndex("dbo.Services", new[] { "Bankomat_BankomatId" });
            AddColumn("dbo.Services", "Bank_BankId", c => c.Long());
            CreateIndex("dbo.Services", "Bank_BankId");
            AddForeignKey("dbo.Services", "Bank_BankId", "dbo.Banks", "BankId");
            DropColumn("dbo.Services", "Bankomat_BankomatId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Services", "Bankomat_BankomatId", c => c.Long());
            DropForeignKey("dbo.Services", "Bank_BankId", "dbo.Banks");
            DropIndex("dbo.Services", new[] { "Bank_BankId" });
            DropColumn("dbo.Services", "Bank_BankId");
            CreateIndex("dbo.Services", "Bankomat_BankomatId");
            AddForeignKey("dbo.Services", "Bankomat_BankomatId", "dbo.Bankomats", "BankomatId");
        }
    }
}
