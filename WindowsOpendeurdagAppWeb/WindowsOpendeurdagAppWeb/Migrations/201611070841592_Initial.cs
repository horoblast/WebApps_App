namespace WindowsOpendeurdagAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.CalendarEvents",
                c => new
                    {
                        CalendarEventId = c.Int(nullable: false, identity: true),
                        DayOfEvent = c.DateTime(nullable: false),
                        Name = c.String(),
                        Adres = c.String(),
                        ForWhom = c.String(),
                        Time = c.String(),
                        Language = c.String(),
                        Organizer = c.String(),
                        Contact = c.String(),
                        Website = c.String(),
                        Tekst = c.String(),
                    })
                .PrimaryKey(t => t.CalendarEventId);
            
            CreateTable(
                "dbo.Campus",
                c => new
                    {
                        CampusId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Straat = c.String(),
                        Straatnr = c.Int(nullable: false),
                        Adres = c.String(),
                        Telnr = c.String(),
                        GebruikerFormulier_GebruikerFormulierId = c.Int(),
                    })
                .PrimaryKey(t => t.CampusId)
                .ForeignKey("dbo.GebruikerFormuliers", t => t.GebruikerFormulier_GebruikerFormulierId)
                .Index(t => t.GebruikerFormulier_GebruikerFormulierId);
            
            CreateTable(
                "dbo.Gebouws",
                c => new
                    {
                        GebouwId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.GebouwId);
            
            CreateTable(
                "dbo.Richtings",
                c => new
                    {
                        RichtingId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Tekst = c.String(),
                        GebruikerFormulier_GebruikerFormulierId = c.Int(),
                    })
                .PrimaryKey(t => t.RichtingId)
                .ForeignKey("dbo.GebruikerFormuliers", t => t.GebruikerFormulier_GebruikerFormulierId)
                .Index(t => t.GebruikerFormulier_GebruikerFormulierId);
            
            CreateTable(
                "dbo.GebruikerFormuliers",
                c => new
                    {
                        GebruikerFormulierId = c.Int(nullable: false, identity: true),
                        Voornaam = c.String(),
                        Achternaam = c.String(),
                        Geboortedatum = c.DateTime(nullable: false),
                        Straat = c.String(),
                        Straatnr = c.Int(nullable: false),
                        Email = c.String(),
                        Telnr = c.Int(nullable: false),
                        Gsmnr = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GebruikerFormulierId);
            
            CreateTable(
                "dbo.NewsItems",
                c => new
                    {
                        NewsItemId = c.Int(nullable: false, identity: true),
                        Tekst = c.String(),
                        Affiche = c.String(),
                    })
                .PrimaryKey(t => t.NewsItemId);
            
            CreateTable(
                "dbo.GebouwCampus",
                c => new
                    {
                        Gebouw_GebouwId = c.Int(nullable: false),
                        Campus_CampusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Gebouw_GebouwId, t.Campus_CampusId })
                .ForeignKey("dbo.Gebouws", t => t.Gebouw_GebouwId, cascadeDelete: true)
                .ForeignKey("dbo.Campus", t => t.Campus_CampusId, cascadeDelete: true)
                .Index(t => t.Gebouw_GebouwId)
                .Index(t => t.Campus_CampusId);
            
            CreateTable(
                "dbo.RichtingCampus",
                c => new
                    {
                        Richting_RichtingId = c.Int(nullable: false),
                        Campus_CampusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Richting_RichtingId, t.Campus_CampusId })
                .ForeignKey("dbo.Richtings", t => t.Richting_RichtingId, cascadeDelete: true)
                .ForeignKey("dbo.Campus", t => t.Campus_CampusId, cascadeDelete: true)
                .Index(t => t.Richting_RichtingId)
                .Index(t => t.Campus_CampusId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Richtings", "GebruikerFormulier_GebruikerFormulierId", "dbo.GebruikerFormuliers");
            DropForeignKey("dbo.Campus", "GebruikerFormulier_GebruikerFormulierId", "dbo.GebruikerFormuliers");
            DropForeignKey("dbo.RichtingCampus", "Campus_CampusId", "dbo.Campus");
            DropForeignKey("dbo.RichtingCampus", "Richting_RichtingId", "dbo.Richtings");
            DropForeignKey("dbo.GebouwCampus", "Campus_CampusId", "dbo.Campus");
            DropForeignKey("dbo.GebouwCampus", "Gebouw_GebouwId", "dbo.Gebouws");
            DropIndex("dbo.RichtingCampus", new[] { "Campus_CampusId" });
            DropIndex("dbo.RichtingCampus", new[] { "Richting_RichtingId" });
            DropIndex("dbo.GebouwCampus", new[] { "Campus_CampusId" });
            DropIndex("dbo.GebouwCampus", new[] { "Gebouw_GebouwId" });
            DropIndex("dbo.Richtings", new[] { "GebruikerFormulier_GebruikerFormulierId" });
            DropIndex("dbo.Campus", new[] { "GebruikerFormulier_GebruikerFormulierId" });
            DropTable("dbo.RichtingCampus");
            DropTable("dbo.GebouwCampus");
            DropTable("dbo.NewsItems");
            DropTable("dbo.GebruikerFormuliers");
            DropTable("dbo.Richtings");
            DropTable("dbo.Gebouws");
            DropTable("dbo.Campus");
            DropTable("dbo.CalendarEvents");
            DropTable("dbo.Admins");
        }
    }
}
