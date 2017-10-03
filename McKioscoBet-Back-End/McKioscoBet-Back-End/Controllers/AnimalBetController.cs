using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using McKioscoBet_Back_End.Models;

namespace McKioscoBet_Back_End.Controllers
{
    public class AnimalBetController : ApiController
    {
        [HttpGet]
        public AnimalBet Hola()
        {
            AnimalBet apuesta = new AnimalBet();
            apuesta.animalname = "Hola mudno";
            apuesta.bettime = 14;
            apuesta.datebet = Convert.ToDateTime("2017-10-03");

            return apuesta;
        }

        [HttpGet]
        public IEnumerable<string> Caho()
        {
            return new string[] { "va", "lue2" };
        }
        [HttpPost]
        public IEnumerable<string> Instert()
        {
            return new string[] { "va", "lue2" };
        }
    }
}
