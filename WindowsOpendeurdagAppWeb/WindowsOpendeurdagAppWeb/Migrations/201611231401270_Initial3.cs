namespace WindowsOpendeurdagAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.GebruikerFormuliers", "Straatnr");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GebruikerFormuliers", "Straatnr", c => c.Int(nullable: false));
        }
    }
}
