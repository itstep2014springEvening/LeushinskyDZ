namespace banksearchapp_Ivan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _7771 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bankomats", "BankomatName", c => c.String());
            AddColumn("dbo.Bankomats", "BankOwnerName", c => c.String());
            AddColumn("dbo.Bankomats", "Telephone", c => c.Double(nullable: false));
            AddColumn("dbo.Bankomats", "Address", c => c.String());
            AddColumn("dbo.Bankomats", "CoordinateX", c => c.Double(nullable: false));
            AddColumn("dbo.Bankomats", "CoordinateY", c => c.Double(nullable: false));
            AddColumn("dbo.Bankomats", "OpenDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Bankomats", "WorkingTime", c => c.String());
            AddColumn("dbo.Bankomats", "CurrencyName", c => c.String());
            AddColumn("dbo.Bankomats", "CurrencyValueB", c => c.String());
            AddColumn("dbo.Bankomats", "CurrencyValueS", c => c.String());
            AddColumn("dbo.Bankomats", "PersonalInformation", c => c.String());
            AddColumn("dbo.Bankomats", "Review", c => c.String());
            AddColumn("dbo.Bankomats", "Services", c => c.String());
            AddColumn("dbo.Bankomats", "AdditionalInformation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bankomats", "AdditionalInformation");
            DropColumn("dbo.Bankomats", "Services");
            DropColumn("dbo.Bankomats", "Review");
            DropColumn("dbo.Bankomats", "PersonalInformation");
            DropColumn("dbo.Bankomats", "CurrencyValueS");
            DropColumn("dbo.Bankomats", "CurrencyValueB");
            DropColumn("dbo.Bankomats", "CurrencyName");
            DropColumn("dbo.Bankomats", "WorkingTime");
            DropColumn("dbo.Bankomats", "OpenDate");
            DropColumn("dbo.Bankomats", "CoordinateY");
            DropColumn("dbo.Bankomats", "CoordinateX");
            DropColumn("dbo.Bankomats", "Address");
            DropColumn("dbo.Bankomats", "Telephone");
            DropColumn("dbo.Bankomats", "BankOwnerName");
            DropColumn("dbo.Bankomats", "BankomatName");
        }
    }
}
