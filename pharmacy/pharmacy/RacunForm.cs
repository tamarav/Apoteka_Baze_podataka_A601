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
    public partial class RacunForm : Form
    {
        public RacunForm(string user, string iznos)
        {
            InitializeComponent();
            this.lb_iznos.Text = "Iznos racuna je " + iznos + " KM.";
            this.lb_user.Text = "Racun izdrao: " + user;

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            ProdajaForm.zatvoriRacun();
        }
    }
}
