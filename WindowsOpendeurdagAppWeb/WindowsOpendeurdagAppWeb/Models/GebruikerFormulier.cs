using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WindowsOpendeurdagAppWeb.Models
{
    public class GebruikerFormulier
    {
        public int GebruikerFormulierId { get; set; }

        public string Voornaam { get; set; }

        public string Achternaam { get; set; }

        public DateTime Geboortedatum { get; set; }

        public string Straat { get; set; }

        public string Email { get; set; }

        public int Telnr { get; set; }

        public int Gsmnr { get; set; }

        public virtual ICollection<Campus> Campussen { get; set; }

        public virtual ICollection<Richting> Richtingen { get; set; }
    }
}