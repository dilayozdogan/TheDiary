namespace TheDiary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DiaryCs",
                c => new
                    {
                        DiaryID = c.Int(nullable: false),
                        DiaryTitle = c.String(),
                    })
                .PrimaryKey(t => t.DiaryID)
                .ForeignKey("dbo.Users", t => t.DiaryID)
                .Index(t => t.DiaryID);
            
            CreateTable(
                "dbo.DiaryPages",
                c => new
                    {
                        DiaryPageID = c.Int(nullable: false, identity: true),
                        PageContent = c.String(nullable: false, maxLength: 500),
                        PageDateTime = c.DateTime(nullable: false),
                        DiaryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DiaryPageID)
                .ForeignKey("dbo.DiaryCs", t => t.DiaryID, cascadeDelete: true)
                .Index(t => t.DiaryID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        UserPassword = c.String(),
                        UserIsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DiaryCs", "DiaryID", "dbo.Users");
            DropForeignKey("dbo.DiaryPages", "DiaryID", "dbo.DiaryCs");
            DropIndex("dbo.DiaryPages", new[] { "DiaryID" });
            DropIndex("dbo.DiaryCs", new[] { "DiaryID" });
            DropTable("dbo.Users");
            DropTable("dbo.DiaryPages");
            DropTable("dbo.DiaryCs");
        }
    }
}
