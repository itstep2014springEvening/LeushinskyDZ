namespace Example1CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SampleMigrations : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Players", "Phone");
            DropColumn("dbo.Players", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "Email", c => c.String());
            AddColumn("dbo.Players", "Phone", c => c.String());
        }
    }
}
