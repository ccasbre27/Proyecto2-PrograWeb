namespace WCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.User", "UserTypeID", c => c.Int(nullable: false));
            CreateIndex("dbo.User", "UserTypeID");
            AddForeignKey("dbo.User", "UserTypeID", "dbo.UserType", "Id", cascadeDelete: true);
            DropColumn("dbo.User", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.User", "Type", c => c.Int(nullable: false));
            DropForeignKey("dbo.User", "UserTypeID", "dbo.UserType");
            DropIndex("dbo.User", new[] { "UserTypeID" });
            DropColumn("dbo.User", "UserTypeID");
            DropTable("dbo.UserType");
        }
    }
}
