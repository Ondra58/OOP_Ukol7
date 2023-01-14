using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    internal class Zbozi
    {
        protected string nazev;
        protected int cena;
        protected DateTime datumvyroby;
        protected int mintrvanlivost;
        public Zbozi(string nazev, int cena, DateTime datumvyroby, int mintrvanlivost)
        {
            this.nazev = nazev;
            this.cena = cena;
            this.datumvyroby = datumvyroby;
            this.mintrvanlivost = mintrvanlivost;
        }
        public bool SplnujeMinTrvanlivost(DateTime datumvyroby, int mintrvanlivost)
        {
            if (DateTime.Now <= (datumvyroby.AddDays(mintrvanlivost + 1)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual double CenaSDPH(int cena)
        {
            return (double)cena * 1.21;
        }

        public override string ToString()
        {
            return "Název: " + nazev + "\nCena: " + cena + " Kč \nDatum výroby: " + datumvyroby.ToShortDateString() + "\nMinimální trvanlivost: " + mintrvanlivost + " dní \nCena s DPH: " + CenaSDPH(cena) + " Kč \nPo datu expirace: " + (SplnujeMinTrvanlivost(datumvyroby, mintrvanlivost) ? "Ne" : "Ano");
        }
    }
}
