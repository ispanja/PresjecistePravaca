using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearnaJednadzba
{
    struct Pravac
    {
        // y = ax + b
        // a - koeficijent smjera; b - odsječak na ordinati
        private double koefSmjera;
        private double odsjecakNaY;

        //Konstruktor
        public Pravac(double koeficijentSmjera, double odsjecakOrdinata)
        {
            this.koefSmjera = koeficijentSmjera;
            this.odsjecakNaY = odsjecakOrdinata;
        }

        public Pravac(double koeficijentSmjera)
        {
            this.koefSmjera = koeficijentSmjera;
            odsjecakNaY = 0d;
        }

        //Property a-koef smjera
        public double A
        {
            get { return koefSmjera; }
            set { koefSmjera = value; }
        }

        //Property b-odsjecak ordinata
        public double B
        {
            get { return odsjecakNaY; }
            set { odsjecakNaY = value; }
        }

        public double Y(double x)
        {
            return koefSmjera * x + odsjecakNaY;
        }

        public double Nultocka
        {
            get { return -(odsjecakNaY / koefSmjera); }
        }


        public override string ToString()
        {
            return $"{koefSmjera}x + {odsjecakNaY}";
        }

    }
}
