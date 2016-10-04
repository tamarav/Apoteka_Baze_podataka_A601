using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy.Osoba
{
    class Osoba
    {
        private string ime;
        private string prezime;
        private string adresa;
        private string datum;
        private string brojPoste;
        private string mjesto;
        private string plata;

        public string Plata
        {
            get { return plata; }
            set { plata = value; }
        }

        public string Mjesto
        {
            get { return mjesto; }
            set { mjesto = value; }
        }

        public string BrojPoste
        {
            get { return brojPoste; }
            set { brojPoste = value; }
        }

        public string Datum
        {
            get { return datum; }
            set { datum = value; }
        }

        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        private string jmbg;

        public string Jmbg
        {
            get { return jmbg; }
            set { jmbg = value; }
        }
        public Osoba( string jmbg, string ime, string prezime) {
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
        }
        public Osoba(string ime, string prezime, string datum, string adresa, string mjesto, string brojPoste, string plata)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.datum = datum;
            this.adresa = adresa;
            this.mjesto = mjesto;
            this.brojPoste = brojPoste;
            this.plata = plata;
        }
        public string toString() {
            return this.ime + " " + this.prezime;
        }
    }
}
