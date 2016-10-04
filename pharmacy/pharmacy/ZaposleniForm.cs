using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pharmacy.Osoba;

namespace pharmacy
{   
    public partial class ZaposleniForm : Form
    {
        private string user;
        public ZaposleniForm(string user)
        {  
            InitializeComponent();
            this.user = user;
            this.ReloadListView();
        }
        private void ReloadListView()
        {
            List<Osoba.Osoba> listOfEmplyees = new List<Osoba.Osoba>();
            ListViewItem lvi = new ListViewItem();
            Osoba.OsobaDao osobaDao = new Osoba.OsobaDaoImplements();
            listOfEmplyees = osobaDao.getEmployees();
            lv_Main.Columns.Clear();
            lv_Main.Items.Clear();
            lv_Main.Columns.Add("Ime", 60);
            lv_Main.Columns.Add("Prezime", 60);
            lv_Main.Columns.Add("Datum rodjenja", 90);
            lv_Main.Columns.Add("Adresa", 60);
            lv_Main.Columns.Add("Mjesto", 60);
            lv_Main.Columns.Add("Postanski broj", 60);
            lv_Main.Columns.Add("Plata", 60);
            foreach (Osoba.Osoba item in listOfEmplyees)
            {
                lvi = new ListViewItem (new[] { item.Ime, item.Prezime, item.Datum, item.Adresa, item.Mjesto, item.BrojPoste, item.Plata });
                lv_Main.Items.Add(lvi);
            }
        }

    }
}
