namespace ConsoleApplication2exztest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _123 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Devices", "Country", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Devices", "Country");
        }
    }
}
