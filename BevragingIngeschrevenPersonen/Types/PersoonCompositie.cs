using System.Collections.Generic;

namespace BevragingIngeschrevenPersonen.Types
{
    class PersoonCompositie
    {
        public Persoon Persoon { get; set; }
        public Adres Adres { get; set; }
        public List<Relatie> Ouders { get; set; }
        public List<Relatie> Kinderen { get; set; }
        public List<Relatie> Medebewoners { get; set; }
    }
}
