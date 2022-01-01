using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearnaJednadzba
{
    class Tocka
    {
        public double x;
        public double y;

        public Tocka()
        { 
        
        }

        public Tocka(double apscisa, double ordinata)
        {
            this.x = apscisa;
            this.y = ordinata;
        }

        public Tocka(double apscisa)
        {
            this.x = apscisa;
            this.y = 0;
        }

        public static Tocka Sjeciste(Pravac prvi, Pravac drugi)
        {
            return new Tocka((drugi.B - prvi.B)/(prvi.A - drugi.A), (prvi.A * drugi.B - drugi.A * prvi.B) / (prvi.A - drugi.A));
        }
        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}
