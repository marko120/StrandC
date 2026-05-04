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


        static void Main(string[] args)
        {
            List<Furdo> List = new List<Furdo>();
            string[] sorok = File.ReadAllLines("strandadatok.txt").Skip(1).ToArray();
            foreach (string s in sorok)
            List.Add(new Furdo(s));{
            
                
            }
            Console.WriteLine("7.feladat");
            Console.WriteLine($"Fürdők száma: {List.Count}");



            int összeg = 0;
            foreach (var item in List)
            {
                összeg += item.Ár;
            }
            double átlag = összeg/(double)List.Count;
            Console.WriteLine($"8.feladat\r\n A fűrdőbelépők átlagos ára: {átlag:F1}\r\n");
        }
    }
}
