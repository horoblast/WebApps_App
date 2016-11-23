using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace WindowsOpendeurdagAppWeb.Models
{
    public class NewsItem
    {
        public int NewsItemId { get; set; }

        // http://stackoverflow.com/questions/3548401/how-to-save-image-in-database-using-c-sharp
        public string Affiche { get; set; }

    }
}