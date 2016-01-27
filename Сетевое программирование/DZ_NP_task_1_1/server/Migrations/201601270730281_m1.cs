namespace server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Indices",
                c => new
                    {
                        IndexId = c.Long(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.IndexId);
            
            CreateTable(
                "dbo.Streets",
                c => new
                    {
                        StreetId = c.Long(nullable: false, identity: true),
                        StreetName = c.String(),
                        Index_IndexId = c.Long(),
                    })
                .PrimaryKey(t => t.StreetId)
                .ForeignKey("dbo.Indices", t => t.Index_IndexId)
                .Index(t => t.Index_IndexId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Streets", "Index_IndexId", "dbo.Indices");
            DropIndex("dbo.Streets", new[] { "Index_IndexId" });
            DropTable("dbo.Streets");
            DropTable("dbo.Indices");
        }
    }
}
