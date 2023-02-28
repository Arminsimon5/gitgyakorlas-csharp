using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitgyakorlas_csharp
{
    internal class Program
    {
        static int nagyobb(int szam1, int szam2)
        {
            if (szam1 < szam2)
            {
                return szam2;
            }
            else if (szam2 < szam1)
            {
                return szam1;
            }
            else { return szam1 - szam2; }

        }

        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            int szam;
            do
            {
                Console.Write("Adja meg a számot.: ");
                szam = Convert.ToInt32(Console.ReadLine());
                if (szam != 0)
                {
                    lista.Add(szam);
                }
            } while (szam != 0);
            Console.WriteLine("A legnagyobb szám a felsorolásból a "+lista.Max());
            Console.ReadKey();
            
        }
    }
}
