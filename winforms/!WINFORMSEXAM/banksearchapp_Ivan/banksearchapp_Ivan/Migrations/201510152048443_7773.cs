namespace banksearchapp_Ivan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _7773 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Banks", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Banks", "Date", c => c.DateTime());
        }
    }
}
