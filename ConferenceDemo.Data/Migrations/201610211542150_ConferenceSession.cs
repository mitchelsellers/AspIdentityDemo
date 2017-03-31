namespace ConferenceDemo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConferenceSession : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConferenceSessions",
                c => new
                    {
                        ConferenceSessionId = c.Int(nullable: false, identity: true),
                        SessionName = c.String(nullable: false, maxLength: 500),
                        SessionDescription = c.String(nullable: false),
                        SpeakerUserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ConferenceSessionId)
                .ForeignKey("dbo.AspNetUsers", t => t.SpeakerUserId, cascadeDelete: true)
                .Index(t => t.SpeakerUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ConferenceSessions", "SpeakerUserId", "dbo.AspNetUsers");
            DropIndex("dbo.ConferenceSessions", new[] { "SpeakerUserId" });
            DropTable("dbo.ConferenceSessions");
        }
    }
}
