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
        }

        static void Main(string[] args)
        {
        }
    }
}
