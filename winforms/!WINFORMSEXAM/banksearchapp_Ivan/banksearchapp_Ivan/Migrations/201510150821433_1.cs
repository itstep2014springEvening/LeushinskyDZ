namespace banksearchapp_Ivan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Bankomats", name: "Banks_BankId", newName: "Bank_BankId");
            RenameColumn(table: "dbo.Bankomats", name: "Bankomat_BankomatId", newName: "Bankomats_BankomatId");
            RenameIndex(table: "dbo.Bankomats", name: "IX_Bankomat_BankomatId", newName: "IX_Bankomats_BankomatId");
            RenameIndex(table: "dbo.Bankomats", name: "IX_Banks_BankId", newName: "IX_Bank_BankId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Bankomats", name: "IX_Bank_BankId", newName: "IX_Banks_BankId");
            RenameIndex(table: "dbo.Bankomats", name: "IX_Bankomats_BankomatId", newName: "IX_Bankomat_BankomatId");
            RenameColumn(table: "dbo.Bankomats", name: "Bankomats_BankomatId", newName: "Bankomat_BankomatId");
            RenameColumn(table: "dbo.Bankomats", name: "Bank_BankId", newName: "Banks_BankId");
        }
    }
}
