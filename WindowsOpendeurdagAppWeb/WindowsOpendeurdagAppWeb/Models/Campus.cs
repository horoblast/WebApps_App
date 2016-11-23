using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WindowsOpendeurdagAppWeb.Models
{
    public class Campus
    {
        public int CampusId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Richting> Richtingen { get; set; }

        public string Straat { get; set; }

        public string Adres { get; set; }

        public string Telnr { get; set; }

        public virtual ICollection<Gebouw> Gebouwen { get; set; }

    }
}