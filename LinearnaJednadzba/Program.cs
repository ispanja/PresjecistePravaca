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
            Pravac pk = new Pravac(-3, 5);

            Pravac pk2 = pk;

            Console.WriteLine($"pk={pk}");
            Console.WriteLine($"pk2={pk2}");

            Console.WriteLine(pk.A);
            Console.WriteLine(pk2.A);

            pk.A = 105;
            pk2.B = -103;
            Console.WriteLine(pk.A);
            Console.WriteLine(pk2.A);
            Console.WriteLine(pk.B);
            Console.WriteLine(pk2.B);

            Pravac pk3 = new Pravac(4, 1);
            Pravac pk4 = new Pravac(2, 5);

            var t = Tocka.Sjeciste(pk3, pk4);

            Console.WriteLine(pk3);
            Console.WriteLine(pk4);
            Console.WriteLine(t);
            Console.WriteLine(pk3.Nultocka);
            Console.WriteLine(pk4.Nultocka);

            Console.ReadKey(false);
        }
    }
}
