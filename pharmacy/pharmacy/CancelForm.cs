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
    public partial class CancelForm : Form
    {
        string user;
        public CancelForm(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.zatvori();
        }
    }
}
