using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace McKioscoBet_Back_End.Models
{
    public class AnimalBet
    {
        public int id { get; set;}
        public int animalnumber { get; set; }
        public string animalname { get; set; }
        public int betvalue { get; set; }
        public int idloto { get; set; }
        public int bettime { get; set; }
        public int idpoint { get; set; }
        public DateTime datebet { get; set;}
    }
}