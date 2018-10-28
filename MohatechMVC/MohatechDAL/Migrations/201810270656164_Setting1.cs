namespace MohatechDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Setting1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        SettingId = c.Int(nullable: false, identity: true),
                        SiteTitle = c.String(),
                        Description = c.String(),
                        Keyword = c.String(),
                        CopyRight = c.String(),
                        NavIcon = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        WorkTime = c.String(),
                        SupportEmail = c.String(),
                        InfoEmail = c.String(),
                        Logo = c.String(),
                    })
                .PrimaryKey(t => t.SettingId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Settings");
        }
    }
}
