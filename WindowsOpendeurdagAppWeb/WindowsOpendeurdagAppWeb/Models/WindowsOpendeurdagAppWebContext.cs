using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WindowsOpendeurdagAppWeb.Models
{
    public class WindowsOpendeurdagAppWebContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WindowsOpendeurdagAppWebContext() : base("name=WindowsOpendeurdagAppWebContext")
        {
        }

        public System.Data.Entity.DbSet<WindowsOpendeurdagAppWeb.Models.Campus> Campus { get; set; }

        public System.Data.Entity.DbSet<WindowsOpendeurdagAppWeb.Models.Richting> Richtings { get; set; }

        public System.Data.Entity.DbSet<WindowsOpendeurdagAppWeb.Models.Gebouw> Gebouws { get; set; }

        public System.Data.Entity.DbSet<WindowsOpendeurdagAppWeb.Models.Admin> Admins { get; set; }

        public System.Data.Entity.DbSet<WindowsOpendeurdagAppWeb.Models.CalendarEvent> CalendarEvents { get; set; }

        public System.Data.Entity.DbSet<WindowsOpendeurdagAppWeb.Models.GebruikerFormulier> GebruikerFormuliers { get; set; }

        public System.Data.Entity.DbSet<WindowsOpendeurdagAppWeb.Models.NewsItem> NewsItems { get; set; }
    }
}
