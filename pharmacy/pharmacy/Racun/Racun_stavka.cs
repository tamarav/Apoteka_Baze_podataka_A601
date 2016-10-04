using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy.Racun
{
    public class Racun_stavka
    {
        private string sifra;

        public string Sifra
        {
            get { return sifra; }
            set { sifra = value; }
        }
       // private string naziv;
        private int kolicina;
       // private double cijena;
        private double ukupno;
        private Proizvod.Proizvod proizvod;

        public Proizvod.Proizvod Proizvod
        {
            get { return proizvod; }
            set { proizvod = value; }
        }

        public Racun_stavka(Proizvod.Proizvod p, int kolicina, double ukupno) 
        {
            this.proizvod = p;
            this.kolicina = kolicina;
            this.ukupno = ukupno;
        }
        public double Ukupno
        {
            get { return ukupno; }
            set { ukupno = value; }
        }
       /* public double Cijena
        {
            get { return cijena; }
            set { cijena = value; }
        }*/
        public int Kolicina
        {
            get { return kolicina; }
            set { kolicina = value; }
        }
     /*   public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
        public string Sifra
        {
            get { return sifra; }
            set { sifra = value; }
        }
        public Racun_stavka(string sifra, string naziv, int kolicina, double cijena, double ukupno) 
        {
            this.sifra = sifra;
            this.naziv = naziv;
            this.kolicina = kolicina;
            this.cijena = cijena;
            this.ukupno = ukupno;
        }*/
           

    }
}
