namespace server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Streets",
                c => new
                    {
                        Index = c.Long(nullable: false, identity: true),
                        Street = c.String(),
                    })
                .PrimaryKey(t => t.Index);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Streets");
        }
    }
}
