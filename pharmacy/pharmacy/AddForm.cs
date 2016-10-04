using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy
{
    public partial class AddForm : Form
    {
        private string user;

         public AddForm(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            var form = new CancelForm(user);
            form.ShowDialog();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (tb_sifraP.Text == "" || tb_naziv.Text == "" ) {
                lb_message.Show();
                return;
            }
            string datum =  dateTimePicker1.Value.ToString("yyyy-MM-dd");
            Proizvod.Proizvod proizvod = new Proizvod.Proizvod(tb_sifraP.Text.ToString(), tb_naziv.Text.ToString(), tb_proizvodjac.Text.ToString(), Double.Parse(tb_cijena.Text), datum, Int16.Parse(tb_kolicina.Text), tb_atcS.Text.ToString(), tb_oblik.Text.ToString(), tb_lista.Text.ToString());
            Proizvod.ProizvodDao proizvodDao = new Proizvod.ProizvodDaoImplements();
            if (proizvodDao.dodajLijek(proizvod))
            {
                this.Close();
            }
            else {
                lb_message.Show();
            }
        }

    }
}
