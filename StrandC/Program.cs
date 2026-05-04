using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace StrandC
{
    public class Furdo

    {
        public string Név { get; set; }
        public string Cím { get; set; }
        public int Ár { get; private set; }
        public int Vízhőfok { get; private set; }



        public Furdo(string sor)
        { 
            string[] adatok = sor.Split(';');
            Név = adatok[0];
            Cím = adatok[1];
            Ár = int.Parse(adatok[2]);
            Vízhőfok = int.Parse(adatok[3]);
        }


        public string IRSZ()
        {
            return Cím.Split(" ")[0];
        }


        public string Telepules()
        {
            return Cím.Split("  ")[1].Split(" ")[0];
        }

    }
}
