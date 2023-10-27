using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Osztályosdi
{
    public class Cso : Henger
    {
        private double falVastagsag;

        public double FalVastagsag { get => falVastagsag; }

        public Cso(double sugar, double magassag) : base(sugar, magassag)
        {
            falVastagsag = 1;
        }

        public Cso(double sugar, double magassag, double falVastagag) : base(sugar, magassag)
        {
            this.falVastagsag = falVastagag;
        }

        public override double Terfogat()
        {
           return Math.Round(base.Terfogat() - Math.Pow(GetSugar - falVastagsag, 2) * Math.PI * GetMagassag, 2);
        }
        public override string ToString()
        {
            return $"Jellemzők >> térfogat: {Terfogat()}; sugár: {GetSugar}; magasság: {GetMagassag}; falvastagság: {FalVastagsag} ";
        }
    }
}