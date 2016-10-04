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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void tb_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btn_login_Click(sender, e);
            }
        }
        private void tb_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btn_login_Click(sender, e);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            string username = tb_username.Text;
            string password = tb_password.Text;

            if (tb_username.Text == "" || tb_password.Text == "")
            {
                lbl_info.Show();
                tb_password.Text = "";
                return;
            }

           OsobaDao osobaDao = new OsobaDaoImplements();
           Osoba.Osoba osoba = osobaDao.getOsoba(password);
           if (osoba != null) {
               this.Hide();
               var form2 = new MainForm(username);
               form2.Closed += (s, args) => this.Close();
               form2.Show();
           }
           else
           {
               lbl_info.Text = "Wrong username or password";
               lbl_info.Show();
           }
         }

    }
}
