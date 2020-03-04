using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrpBipApi.Controllers;
using BrpBipApi.Types;

namespace BrpBipBlazor.Data
{
    public class BipService
    {
        IngeschrevenPersoonController bipApi = new IngeschrevenPersoonController();

        public Persoon GetPersoon(int id = 999993653)
        {
            return bipApi.GetPersoon(id.ToString());
        }
    }
}
