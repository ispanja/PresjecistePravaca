using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearnaJednadzba
{
    class Program
    {
        static void Main(string[] args)
        {
            Pravac pk = new Pravac(2, 4);
            PravacStruct ps = new PravacStruct(-1, 2);

            Pravac pk2 = pk;
            PravacStruct ps2 = ps;

            Console.WriteLine($"pk={pk}");
            Console.WriteLine($"pk2={pk2}");
            Console.WriteLine($"ps={ps}");
            Console.WriteLine($"ps2={ps2}");

            pk2.koefSmjera = 25;
            ps2.odsjecakNaY = 58;

            Console.WriteLine($"pk={pk}");
            Console.WriteLine($"pk2={pk2}");
            Console.WriteLine($"ps={ps}");
            Console.WriteLine($"ps2={ps2}");



            Console.ReadKey(false);
        }
    }
}
