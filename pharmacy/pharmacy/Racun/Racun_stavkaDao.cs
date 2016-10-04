using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy.Racun
{
    interface Racun_stavkaDao
    {
        Boolean dodajNaRacun(int id, string sifra, double cijena, int kolicina);
    }
}
