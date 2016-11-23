namespace WindowsOpendeurdagAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.NewsItems", "Tekst");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NewsItems", "Tekst", c => c.String());
        }
    }
}