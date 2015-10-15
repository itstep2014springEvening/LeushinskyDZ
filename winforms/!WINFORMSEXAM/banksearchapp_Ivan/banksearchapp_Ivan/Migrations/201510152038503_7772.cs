namespace banksearchapp_Ivan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _7772 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Banks", "BankName", c => c.String());
            AddColumn("dbo.Banks", "Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Banks", "Date");
            DropColumn("dbo.Banks", "BankName");
        }
    }
}
