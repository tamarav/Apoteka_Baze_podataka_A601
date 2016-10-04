using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy.Osoba
{
    class OsobaDaoImplements : OsobaDao
    {
        public Osoba getOsoba(string password) {
            DB.DBConnection db = new DB.DBConnection();
            Osoba user = db.getOsoba(password);

            if (user != null && user.Jmbg == password)
            {
                return user;
            }

            return null;
        }
        public List<Osoba> getEmployees() {
            DB.DBConnection db = new DB.DBConnection();
            return db.getEmployees();
        }
    }
}
