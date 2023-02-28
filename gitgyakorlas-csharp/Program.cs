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
            Console.Write("Adja meg az első számot.: ");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg az második számot.: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            if (szam1 - szam2 == nagyobb(szam1, szam2)) { Console.WriteLine("A két szám egyenlő."); }
            else { Console.WriteLine("A nagyobb szám a " + nagyobb(szam1, szam2)); }
            Console.ReadKey();
        }
    }
}
