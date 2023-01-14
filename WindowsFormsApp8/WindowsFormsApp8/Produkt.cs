using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    internal class Produkt : Zbozi
    {
        private bool lzeslevnit;
        public Produkt(string nazev, int cena, DateTime datumvyroby, int mintrvanlivost) : base(nazev, cena, datumvyroby, mintrvanlivost)
        {
            this.lzeslevnit = lzeslevnit;
        }
        public bool Lzeslevnit(bool lzeslevnit)
        {
            if (lzeslevnit == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override double CenaSDPH(int cena)
        {
            if (SplnujeMinTrvanlivost(datumvyroby, mintrvanlivost) == false)
            {
                return (base.CenaSDPH(cena)) * 0.6;
            }
            else
            {
                return base.CenaSDPH(cena);
            }
        }
    }
}
