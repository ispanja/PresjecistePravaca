using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearnaJednadzba
{
    struct PravacStruct
    {
        // y = ax + b
        // a - koeficijent smjera; b - odsječak na ordinati
        public double koefSmjera;
        public double odsjecakNaY;

        //Konstruktor
        public PravacStruct(double koeficijentSmjera, double odsjecakOrdinata)
        {
            this.koefSmjera = koeficijentSmjera;
            this.odsjecakNaY = odsjecakOrdinata;
        }

        public override string ToString()
        {
            return $"({koefSmjera}, {odsjecakNaY})";
        }
    }
}
