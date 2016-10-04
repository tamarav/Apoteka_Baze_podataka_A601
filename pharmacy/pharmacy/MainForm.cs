using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pharmacy.Proizvod;
namespace pharmacy
{
    public partial class MainForm : Form
    {
        public static AddForm formAdd;
        private string user;
        private List<Proizvod.Proizvod> lisOfProducts;
        public MainForm(string user)
        {
            InitializeComponent();
            this.ReloadListView();
            this.user = user;
            lb_user.Text = "prijavljeni korisnik: " + user;
        }

        private void ReloadListView()
        {   
            this.lisOfProducts = new List<Proizvod.Proizvod>();
            Proizvod.ProizvodDao prDao = new Proizvod.ProizvodDaoImplements();
            this.lisOfProducts = prDao.getAllProducts();
            ListViewItem lvi = new ListViewItem();
            lv_Main.Columns.Clear();
            lv_Main.Items.Clear();
            lv_Main.Columns.Add("Sifra proizvoda", 100);
            lv_Main.Columns.Add("Naziv", 60);
            lv_Main.Columns.Add("Proizvodjac", 80);
            lv_Main.Columns.Add("Cijena", 60);
            lv_Main.Columns.Add("Rok upotrebe", 80);
            lv_Main.Columns.Add("Kolicina", 60);
            lv_Main.Columns.Add("ATC sifra", 60);
            lv_Main.Columns.Add("Oblik lijeka", 90);
            lv_Main.Columns.Add("Lista", 90);
            foreach (Proizvod.Proizvod  item in lisOfProducts)
            {
                lvi = new ListViewItem(new[] {item.SifraPr, item.Naziv, item.Proizvodjac, item.Cijena.ToString(), item.RokUpotrebe, item.Kolicina.ToString(), item.AtcSifra, item.Oblik, item.Lista });
                lv_Main.Items.Add(lvi);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AboutForm();
            form.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new LoginForm();
            form.ShowDialog();
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            formAdd = new AddForm(user);
            formAdd.ShowDialog();
        }

        public static void zatvori() {
            formAdd.Close();
           }
      
        private void btn_delete_Click(object sender, EventArgs e)
        {
            string id = "";
            int index = 0;
            ListViewItem item = new ListViewItem();
            if (this.lv_Main.SelectedItems.Count > 0)
            {
                item = this.lv_Main.SelectedItems[0];
                id  = item.SubItems[0].Text;
                index = lv_Main.Items.IndexOf(lv_Main.SelectedItems[0]);
            }

            Proizvod.ProizvodDao proizvod = new Proizvod.ProizvodDaoImplements();
            Boolean uspjesno = proizvod.remove(id);
            if (uspjesno)
            {
                Console.WriteLine("proizvod je izbrisan iz baze");
                this.lisOfProducts.RemoveAt(index);
            }

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.ReloadListView();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ZaposleniForm(user);
            form.ShowDialog();
        }

        private void prodajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ProdajaForm(user, this.lisOfProducts);
            form.ShowDialog();
        }
    }
}
