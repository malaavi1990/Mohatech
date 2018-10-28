namespace MohatechDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Setting2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Settings", "SiteTitle", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Settings", "Description", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Settings", "Keyword", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Settings", "CopyRight", c => c.String(maxLength: 250));
            AlterColumn("dbo.Settings", "NavIcon", c => c.String(maxLength: 200));
            AlterColumn("dbo.Settings", "Address", c => c.String(maxLength: 500));
            AlterColumn("dbo.Settings", "PhoneNumber", c => c.String(maxLength: 100));
            AlterColumn("dbo.Settings", "WorkTime", c => c.String(maxLength: 100));
            AlterColumn("dbo.Settings", "SupportEmail", c => c.String(maxLength: 100));
            AlterColumn("dbo.Settings", "InfoEmail", c => c.String(maxLength: 100));
            AlterColumn("dbo.Settings", "Logo", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Settings", "Logo", c => c.String());
            AlterColumn("dbo.Settings", "InfoEmail", c => c.String());
            AlterColumn("dbo.Settings", "SupportEmail", c => c.String());
            AlterColumn("dbo.Settings", "WorkTime", c => c.String());
            AlterColumn("dbo.Settings", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Settings", "Address", c => c.String());
            AlterColumn("dbo.Settings", "NavIcon", c => c.String());
            AlterColumn("dbo.Settings", "CopyRight", c => c.String());
            AlterColumn("dbo.Settings", "Keyword", c => c.String());
            AlterColumn("dbo.Settings", "Description", c => c.String());
            AlterColumn("dbo.Settings", "SiteTitle", c => c.String());
        }
    }
}
