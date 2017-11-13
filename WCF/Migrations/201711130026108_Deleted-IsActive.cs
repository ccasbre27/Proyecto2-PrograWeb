namespace WCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedIsActive : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Product", "IsActive");
            DropColumn("dbo.User", "IsActive");
            DropColumn("dbo.UserType", "IsActive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserType", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.User", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Product", "IsActive", c => c.Boolean(nullable: false));
        }
    }
}
