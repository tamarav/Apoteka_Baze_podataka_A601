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
    public partial class ProdajaForm : Form
    {
        private string user;
        public  static RacunForm racunForm;
        private List<Proizvod.Proizvod> listOfProducts;
        private ListViewItem lvi = new ListViewItem();
        public static int id = 222;
        public List<Proizvod.Proizvod> naruceni;
        List<Racun.Racun_stavka> listaRacuna = new List<Racun.Racun_stavka>();
        public ProdajaForm(string user, List<Proizvod.Proizvod> listOfProducts)
        {
            InitializeComponent();
            this.user = user;
            this.listOfProducts = listOfProducts;
            ProdajaLoad();
        }
        public void ProdajaLoad() 
        {
            foreach (Proizvod.Proizvod p in listOfProducts) 
            {
                this.cb_lijek.Items.Add(new { Text = p.Naziv, Value = p.SifraPr});
                Console.WriteLine(p.Naziv + p.SifraPr);
            }
            this.cb_lijek.DisplayMember = "Text";
            this.cb_lijek.ValueMember = "Value";
            this.cb_lijek.SelectedIndex = 0;
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
             lb_racun.Items.Add(this.cb_lijek.Text + "-" + nup_kolicna.Value.ToString());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = lb_racun.SelectedIndex;
            Console.WriteLine(i);
           lb_racun.Items.RemoveAt(i);

        }

        private void btn_stampaj_Click(object sender, EventArgs e)
        {
            
            int broj = lb_racun.Items.Count;
            string sifra = "";
            double cijena = 0.00;
            double ukupna_cijena = 0.00;
            string[] stavke_na_racunu= new string[broj];
            for (int i = 0; i < broj; i++ )
            {
                string naziv;
                naziv = lb_racun.Items[i].ToString();
                char[] separatingChars = { '-', '^' };
                string[] words = naziv.Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries );
                Proizvod.Proizvod p = nadjiProizvod(words[0]);
                //cijena = p.Cijena;
                ukupna_cijena += p.Cijena * Int16.Parse(words[1]);
                this.listaRacuna.Add(new Racun.Racun_stavka(p, Int16.Parse(words[1]), p.Cijena * Double.Parse(words[1])));   
                this.lb_ukupan_racun.Text = "Iznos racuna : " + ukupna_cijena;
            }
            racunForm = new RacunForm(user, this.lb_ukupan_racun.Text);
            racunForm.ShowDialog();
        }
        private Proizvod.Proizvod nadjiProizvod(string naziv) 
        {
            foreach (Proizvod.Proizvod p in listOfProducts)
            {
                if (p.Naziv.Equals(naziv))
                {
                    return p;  
                }
            }
            return null;
        }
        public static void zatvoriRacun() 
        {
            racunForm.Close();
        }

        private void btn_dodajKeyPresses(object sender, KeyPressEventArgs e)
        {

        }

        private void cb_keyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btn_dodaj_Click(sender, e);
            }
        }
    }
}
