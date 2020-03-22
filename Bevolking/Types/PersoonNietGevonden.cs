using Bevolking.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bevolking.Types
{
    public class PersoonNietGevonden: IPersoon
    {
        public int? Burgerservicenummer { get; set; }
        public string? Voorvoegsels { get; set; }
        public string? Voorletters { get; set; }
        public string? Voornamen { get; set; }
        public enmGeslacht? Geslacht { get; set; }
        public DateTime? DatumGeboorteBevolking { get; set; }
        public DateTime? DatumGeboorte { get; set; }
        public DateTime? DatumOverlijden { get; set; }
        public int? Geboorteland { get; set; }
        public int? Nationaliteit1 { get; set; }
        public int? Nationaliteit2 { get; set; }
        public bool? Geheim { get; set; }
        public string? Aanhef { get; set; }
        public string Naam { get; set; } = "Niet gevonden";
        public string Aanschrijfwijze { get; set; } = "Niet gevonden";
    }
}
