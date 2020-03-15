using System.Collections.Generic;

namespace BevragingIngeschrevenPersonen.Types
{
    public class PersoonCompositie
    {
        public IPersoon Persoon { get; set; }
        public Adres Adres { get; set; }
        public List<Relatie> Ouders { get; set; }
        public List<Relatie> Kinderen { get; set; }
        public List<Relatie> Medebewoners { get; set; }
    }
}
