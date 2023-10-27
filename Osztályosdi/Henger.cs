using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztályosdi
{
    public class Henger
    {
        private double magassag;
        private double sugar;
        private static int szuletesSzamlalo;

        public Henger(double sugar, double magassag)
        {
            this.magassag = magassag;
            this.sugar = sugar;
            szuletesSzamlalo++;
        }

        public double GetMagassag { get => magassag; }
        public double GetSugar { get => sugar;}
        public static int SzuletesSzamlalo { get => szuletesSzamlalo; }

        public virtual double Terfogat()
        {
            return Math.Round(Math.Pow(sugar, 2) * Math.PI * magassag, 2);
        }

        public override string ToString()
        {
            return $"Jellemzők >> térfogat: {Terfogat()}; sugár: {GetSugar}; magasság: {GetMagassag}";
        }
    }
}
