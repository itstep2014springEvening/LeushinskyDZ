namespace DbData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nv3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bankomats", "CityName", c => c.String());
            AddColumn("dbo.Bankomats", "StreetName", c => c.String());
            AddColumn("dbo.Bankomats", "HomeNumber", c => c.String());
            DropColumn("dbo.Bankomats", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bankomats", "Address", c => c.String());
            DropColumn("dbo.Bankomats", "HomeNumber");
            DropColumn("dbo.Bankomats", "StreetName");
            DropColumn("dbo.Bankomats", "CityName");
        }
    }
}
