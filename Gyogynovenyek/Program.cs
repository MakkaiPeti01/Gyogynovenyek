using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gyogynovenyek
{
    class Program
    {
        static List<Noveny> lista = new List<Noveny>();
        static Dictionary<string, int> reszek = new Dictionary<string, int>();
        static void Beolvas()
        {
            StreamReader olvas = new StreamReader("noveny.csv");
            while (!olvas.EndOfStream)
            {
                lista.Add(new Noveny(olvas.ReadLine()));
            }
            olvas.Close();
            Console.WriteLine("1. feladat: Növények száma: {0}", lista.Count);
        }
        static void Masodik()
        {
            Console.WriteLine("\n2. feladat: Gyűjthető részek:");
            foreach (var i in lista)
            {
                if (!reszek.ContainsKey(i.Resz))
                {
                    reszek.Add(i.Resz, 0);
                }
            }
            foreach (var n in lista)
            {
                reszek[n.Resz]++;
            }
            foreach (var i in reszek)
            {
                Console.WriteLine("{0} {1}",i.Key,i.Value);
            }
        }
        static void Harmadik()
        {
            int max = 0;
            string noveny = "";
            foreach (var i in lista)
            {
                if (i.Idotartam > max)
                {
                    max = i.Idotartam;
                    noveny = i.Nev;
                }
            }
                Console.WriteLine("3. feladat: Legtöbb idő, amíg gyűjthető: {0}",max);
                Console.Write("Növény(ek): {0}", noveny);
        }
        static void Negyedik()
        {          
            double s = 0;
            double atlag = 0;
            foreach (var i in lista)
            {
                s = s + i.Idotartam;
            }
            atlag = Math.Round(s / lista.Count, 2);
            Console.WriteLine("");
            Console.WriteLine("4. feladat: {0}", atlag);
        }
        static void Main(string[] args)
        {
            var N = new Noveny("Acsalapu;levél;6;8");
            Beolvas();
            Masodik();
            Harmadik();
            Negyedik();
            Console.ReadKey();
        }
    }
}
