namespace WindowsOpendeurdagAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Campus", "Straatnr");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Campus", "Straatnr", c => c.Int(nullable: false));
        }
    }
}
