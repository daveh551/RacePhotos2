namespace RacePhotos2.App_Architecture.Services.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Distance",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RaceDistance = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Event",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventName = c.String(),
                        RaceDate = c.DateTime(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Race",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventId = c.Int(nullable: false),
                        DistanceId = c.Int(nullable: false),
                        ReferenceTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Distance", t => t.DistanceId, cascadeDelete: true)
                .ForeignKey("dbo.Event", t => t.EventId, cascadeDelete: true)
                .Index(t => t.DistanceId)
                .Index(t => t.EventId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Race", "EventId", "dbo.Event");
            DropForeignKey("dbo.Race", "DistanceId", "dbo.Distance");
            DropIndex("dbo.Race", new[] { "EventId" });
            DropIndex("dbo.Race", new[] { "DistanceId" });
            DropTable("dbo.Race");
            DropTable("dbo.Event");
            DropTable("dbo.Distance");
        }
    }
}
