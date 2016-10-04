using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy.Proizvod
{
    interface ProizvodDao
    {
        List<Proizvod> getAllProducts();
        Boolean dodajLijek(Proizvod p);
        Boolean remove(string id);
        List<Proizvod> getAllDrugs();
    }
}
