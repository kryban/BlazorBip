using System;
using System.Collections.Generic;
using System.Text;

namespace BevragingIngeschrevenPersonen.Types
{
    class PersoonNietGevonden: Persoon
    {
        public override string Naam { get => "Niet gevonden"; }
    }
}
