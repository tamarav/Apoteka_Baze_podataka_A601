using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy.Osoba
{
    interface OsobaDao
    {
        Osoba getOsoba(string password);
        List<Osoba> getEmployees();
    }
}
