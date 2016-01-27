namespace server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
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
                        Index_IndexId = c.Long(),
                    })
                .PrimaryKey(t => t.StreetId)
                .ForeignKey("dbo.Indices", t => t.Index_IndexId)
                .Index(t => t.Index_IndexId);
            
            DropTable("dbo.Streets");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Streets",
                c => new
                    {
                        Index = c.Long(nullable: false, identity: true),
                        Street = c.String(),
                    })
                .PrimaryKey(t => t.Index);
            
            DropForeignKey("dbo.Streets", "Index_IndexId", "dbo.Indices");
            DropIndex("dbo.Streets", new[] { "Index_IndexId" });
            DropTable("dbo.Streets");
            DropTable("dbo.Indices");
        }
    }
}
