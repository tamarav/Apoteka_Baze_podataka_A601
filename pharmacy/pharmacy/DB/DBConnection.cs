using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;
using System.IO;
using pharmacy.Proizvod;

namespace pharmacy.DB
{
    public class DBConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DBConnection()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "apoteka";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator.");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again.");
                        break;
                }
                return false;
            }

        }

        private bool CloseConnection()
        {
            try
            {
                connection.Clone();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        internal Osoba.Osoba getOsoba(string jmbg)
        {
            string query = "SELECT * FROM OSOBA WHERE jmb='" + jmbg + "'";
            Osoba.Osoba newUser = null;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader data = cmd.ExecuteReader();
                if (data.HasRows)
                {
                    data.Read();
                    newUser = new Osoba.Osoba(data.GetString(0), data.GetString(1), data.GetString(2));
                    Console.WriteLine(newUser.toString());
                    return newUser;
                }
                data.Close();
                this.CloseConnection();
            }
            return null;
        }

        internal List<Proizvod.Proizvod> getAllProducts()
        {
            List<Proizvod.Proizvod> listOfProducts = new List<Proizvod.Proizvod>();
            string query = "SELECT * FROM lijek_info_pogled";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader data = cmd.ExecuteReader();
                
                Proizvod.Proizvod proizvod;
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        proizvod = new Proizvod.Proizvod(data.GetString(0), data.GetString(1), data.GetString(2), data.GetDouble(3), data.GetDateTime(4).ToShortDateString(), data.GetInt32(5), data.GetString(6), data.GetString(7), data.GetString(8));
                        listOfProducts.Add(proizvod);
                    }
                }
                data.Close();
                this.CloseConnection();
            }
            foreach (Proizvod.Proizvod p in listOfProducts) { Console.WriteLine(p.ToString()); }
            return listOfProducts;
        }

        internal bool dodajLijekUBazu(Proizvod.Proizvod p)
        {
            string query = "insert into proizvod values ('" + p.SifraPr + "','" + p.Naziv + "','" + p.Proizvodjac + "','" + p.Cijena + "','" + p.RokUpotrebe + "','" +  p.Kolicina + "')";
            string query2 = "insert into lijek values ('" + p.SifraPr + "','" + p.AtcSifra + "','" + p.Oblik + "','" + p.Lista + "')";
            if (this.OpenConnection() == true)
            {
                try
                {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader data = cmd.ExecuteReader();
                data.Close();
                cmd = new MySqlCommand(query2, connection);
                data = cmd.ExecuteReader();
                data.Close();
                this.CloseConnection();
                }
                catch (Exception s)
                {
                    return false;
                }
            }
            return true;
        }

        internal Boolean izbrisiLijekIzBaze(string id)
        {
            try
            {
                string query = "DELETE FROM LIJEK WHERE SifraProizvoda='" + id + "'";
                //string q2 = "DELETE FROM proizvod WHERE SifraProizvoda='" + id + "'";
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }
            catch (Exception e) {
                return false;
            }
            return true;
        }

        internal List<Osoba.Osoba> getEmployees()
        {
            List<Osoba.Osoba> listOfEmployees = new List<Osoba.Osoba>();
            string query = "SELECT * FROM farmaceutski_tehnicar_info_pogled";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader data = cmd.ExecuteReader();

                Osoba.Osoba osoba;
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        osoba = new Osoba.Osoba(data.GetString(1), data.GetString(2), data.GetString(3), data.GetString(4), data.GetString(6), data.GetString(5), data.GetString(7));
                        listOfEmployees.Add(osoba);
                    }
                }
                data.Close();
                this.CloseConnection();
            }

            return listOfEmployees;
        }

        internal List<Proizvod.Proizvod> getAllDrugs()
        {
            List<Proizvod.Proizvod> listOfProducts = new List<Proizvod.Proizvod>();
            string query = "SELECT SifraProizvoda, Naziv FROM proizvod";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader data = cmd.ExecuteReader();

                Proizvod.Proizvod proizvod;
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        proizvod = new Proizvod.Proizvod(data.GetString(0), data.GetString(1));
                        listOfProducts.Add(proizvod);
                    }
                }
                data.Close();
                this.CloseConnection();
            }
            return listOfProducts;
        }

        internal bool DodajNaRacun(int id, string sifra, double cijena, int kolicina)
        {
            Console.WriteLine("db  " + id + "  " + sifra + " " + cijena + " " + kolicina);
            string query = "insert into racun_stavka values ('" + id + "','" + sifra + "','" + cijena + "','" + kolicina + "','" + 0 + "')";
            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader data = cmd.ExecuteReader();
                    data.Close();
                    this.CloseConnection();
                }
                catch (Exception s)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
