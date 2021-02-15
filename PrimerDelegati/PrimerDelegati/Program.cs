using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerDelegati
{
    class Program
    {
        //1. definiraj si tip delegat
        //public delegate bool FunkcijaZaNize(string s);
        //2. napiši metodo, ki sprejme tega delegata kot parameter
        public static List<string> DelajOperacijeNadNizi(string[] m,Func<string,bool> mojaFunkcija)
        {
            List<string> rezultat = new List<string>();

            foreach(var s in m)
            {
                if (mojaFunkcija(s))
                {
                    rezultat.Add(s);
                }
            }

            return rezultat;
        }
        //3. napiši metode, ki so tipa FunkijaZaNize
        //public static bool ZačneZA(string s)
        //{
        //    return s.StartsWith("A");
        //}
        public static bool KončaZN(string s)
        {
            return s.EndsWith("n");
        }

        static void Main(string[] args)
        {
            string[] mojiNizi = { "Adam", "Alan", "Bob", "Steve", "Jim", "Aiden" };
            //To damo noter v "aji". --> uporaba anonimnih metod
            //FunkcijaZaNize an = delegate (string s) { return s.StartsWith("A"); };
            //List<string> aji = DelajOperacijeNadNizi(mojiNizi, delegate (string s) { return s.StartsWith("A"); });
            List<string> nji = DelajOperacijeNadNizi(mojiNizi, KončaZN);

            //Anonimna metoda z lambda izrazom
            List<string> aji = DelajOperacijeNadNizi(mojiNizi, s => s.StartsWith("A"));

            Console.WriteLine("Začnejo se z A: ");
            foreach (var x in aji)
            {
                
                Console.WriteLine(x);
            }
            Console.WriteLine("Končajo se z N: ");

            Console.ReadLine();
        }
    }
}
