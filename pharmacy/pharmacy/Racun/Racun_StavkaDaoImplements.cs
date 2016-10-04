using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy.Racun
{
    public class Racun_StavkaDaoImplements : Racun_stavkaDao
    {
        public Boolean dodajNaRacun(int id, string sifra, double cijena, int kolicina) {
            DB.DBConnection db = new DB.DBConnection();
            return db.DodajNaRacun(id, sifra, cijena, kolicina);
        }
    }
}
