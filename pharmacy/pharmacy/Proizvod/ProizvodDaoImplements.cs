using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy.Proizvod
{
    public class ProizvodDaoImplements : ProizvodDao
    {
        public List<Proizvod> getAllProducts() {
            DB.DBConnection db = new DB.DBConnection();
            return db.getAllProducts();
        }
        public Boolean dodajLijek(Proizvod p) {
            DB.DBConnection db = new DB.DBConnection();
            return db.dodajLijekUBazu(p);
        }
        public Boolean remove(string id) 
        {
            DB.DBConnection db = new DB.DBConnection();
            return db.izbrisiLijekIzBaze(id);
        }
        public List<Proizvod> getAllDrugs() 
        {
            DB.DBConnection db = new DB.DBConnection();
            return db.getAllDrugs();
        }
    }
}
