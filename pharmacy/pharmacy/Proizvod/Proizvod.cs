using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy.Proizvod
{
    public class Proizvod
    {
        private string sifraPr;

        public string SifraPr
        {
            get { return sifraPr; }
            set { sifraPr = value; }
        }
        private string naziv;

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
        private string proizvodjac;

        public string Proizvodjac
        {
            get { return proizvodjac; }
            set { proizvodjac = value; }
        }
        private double cijena;

        public double Cijena
        {
            get { return cijena; }
            set { cijena = value; }
        }
        private string rokUpotrebe;

        public string RokUpotrebe
        {
            get { return rokUpotrebe; }
            set { rokUpotrebe = value; }
        }
        private int kolicina;

        public int Kolicina
        {
            get { return kolicina; }
            set { kolicina = value; }
        }
        private string atcSifra;

        public string AtcSifra
        {
            get { return atcSifra; }
            set { atcSifra = value; }
        }
        private string oblik;

        public string Oblik
        {
            get { return oblik; }
            set { oblik = value; }
        }
        private string lista;

        public string Lista1
        {
            get { return lista; }
            set { lista = value; }
        }

        public string Lista
        {
            get { return Lista1; }
            set { Lista1 = value; }
        }
        public Proizvod(string sifra, string naziv) 
        {
            this.naziv = naziv;
            this.sifraPr = sifra;
        }
        public Proizvod(string sifraPr, string naziv, string proizvodjac, double cijena, string rokUpotrebe, int kolicina, string atcSifra, string oblik, string lista)  
        {
            this.sifraPr = sifraPr;
            this.naziv = naziv;
            this.proizvodjac = proizvodjac;
            this.cijena = cijena;
            this.rokUpotrebe = rokUpotrebe;
            this.kolicina = kolicina;
            this.atcSifra = atcSifra;
            this.oblik = oblik;
            this.lista = lista;
        }
    }
}
