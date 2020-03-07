using BevragingIngeschrevenPersonen.Mappers;
using BevragingIngeschrevenPersonen.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace BevragingIngeschrevenPersonen
{
    public class Bevrager
    {
        Client bipClient;

        public Bevrager()
        {
            bipClient = new Client(new System.Net.Http.HttpClient());
        }

        // GET: api/BevragingIngeschrevenPersoon
        //[HttpGet("/api/ingeschrevenpersoon")]
        public IEnumerable<string> Get()
        {
            //throw new NotImplementedException();
            return new List<string> { "default" };
        }

        
        // GET: api/IngeschrevenPersoon/5
        //[HttpGet("{id}", Name = "GetNatuurlijkPersoon")]
        //[HttpGet("/api/ingeschrevenpersoon/{id}")]
        //[Route("api/ingeschrevenpersoon")]
        public Persoon GetPersoon(string id)
        {
            //999993653
            try
            {
                Persoon retVal;
                IngeschrevenPersoonHal brpResult;

                brpResult = bipClient.IngeschrevenNatuurlijkPersoonAsync(id, null, null).Result;

                retVal = new Map_IngeschrevenPersoonHal_to_Persoon().Map(brpResult);

                return retVal;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /*


        // GET: api/IngeschrevenPersoonOuders/5
        [HttpGet("/api/ingeschrevenpersoon/{id}/ouders")]
        public IEnumerable<Persoon> GetOuders(string id)
        {
            List<Persoon> retVal;
            OuderHalCollectie brpSubResults;

            brpSubResults = bipClient.IngeschrevenpersonenBurgerservicenummeroudersAsync(id, null).Result;
            retVal = HaalPersoonsgegevensOp(brpSubResults._embedded.Ouders.Select(x => x.Burgerservicenummer));

            return retVal;
        }
        */
        /*
        // GET: api/IngeschrevenPersoonOuders/5
        [HttpGet("/api/ingeschrevenpersoon/{id}/kinderen")]
        public IEnumerable<Persoon> GetKinderen(string id)
        {
            List<Persoon> retVal;
            KindHalCollectie brpSubResults;

            brpSubResults = bipClient.IngeschrevenpersonenBurgerservicenummerkinderenAsync(id, null).Result;
            retVal = HaalPersoonsgegevensOp(brpSubResults._embedded.Kinderen.Select(x => x.Burgerservicenummer));

            return retVal;
        }
        */
        /*
        // GET: api/IngeschrevenPersoonOuders/5
        [HttpGet("/api/ingeschrevenpersoon/{id}/partners")]
        public IEnumerable<Persoon> GetPartners(string id)
        {
        List<Persoon> retVal;
        PartnerHalCollectie brpSubResults;

        brpSubResults = bipClient.IngeschrevenpersonenBurgerservicenummerpartnersAsync(id, null).Result;
        retVal = HaalPersoonsgegevensOp(brpSubResults._embedded.Partners.Select(x => x.Burgerservicenummer));

        return retVal;
        }
        */
        /*
        // GET: api/IngeschrevenPersoonOuders/5
        [HttpGet("/api/ingeschrevenpersoon/{id}/medebewoners")]
        public IEnumerable<Persoon> GetMedebewoners(string id)
        {
        List<Persoon> retVal;
        BewoningHalCollectie brpSubResults;

        IEnumerable<Persoon> kinderen = GetKinderen(id);
        IEnumerable<Persoon> partners = GetPartners(id);
        IEnumerable<Persoon> ouders = GetOuders(id);

        brpSubResults = bbpaClient.GetBewoningenAsync(null, null, null, null, null, null, 1, null, null, null, null, "2596TW", null, null).Result;

        retVal = null; //HaalPersoonsgegevensOp(brpSubResults._embedded.Bewoningen.Select(b => b.Bewoners));

        return retVal;
        }
        */
        /*
        //private List<Persoon> HaalPersoonsgegevensOp(IEnumerable<Bewoning> burgerservicenummers)
        //{
        //    List<Persoon> retVal = new List<Persoon>();
        //    foreach (var bsn in burgerservicenummers)
        //    {
        //        try
        //        {
        //            Persoon kind = HaalGegevensOpUitBrp(bsn);
        //            retVal.Add(kind);
        //        }
        //        catch (AggregateException e)
        //        { };
        //    }
        //    return retVal;
        //}
        */
        /*
        private List<Persoon> HaalPersoonsgegevensOp(IEnumerable<string> burgerservicenummers)
        {
        List<Persoon> retVal = new List<Persoon>();
        foreach (var bsn in burgerservicenummers)
        {
        try
        {
        Persoon kind = HaalGegevensOpUitBrp(bsn);
        retVal.Add(kind);
        }
        catch (AggregateException e)
        { };
        }
        return retVal;
        }
        */
        /*
        private Persoon HaalGegevensOpUitBrp(string bsn)
        {
        IngeschrevenPersoonHal brpPpersoon = bipClient.IngeschrevenNatuurlijkPersoonAsync(bsn, null, null, null).Result;
        Persoon persoon = new Map_IngeschrevenPersoonHal_to_Persoon().Map(brpPpersoon);
        return persoon;
        }
        */
    }
}
