using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace samostalni_projakeat_baze
{
    public partial class Form1 : Form
    {
        public string CS = "Data Source = .; Initial Catalog = restoran; Integrated Security = True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtlogin.Text))
            {
                MessageBox.Show("Molimo vas unesite ID zaposlenog.");
                return;
            }

            if (!int.TryParse(txtlogin.Text, out int id))
            {
                MessageBox.Show("Uneseni ID mora biti broj.");
                return;
            }

            using (SqlConnection veza = new SqlConnection(CS))
            {
                string query = "SELECT COUNT(*) FROM Zaposleni WHERE Id = @ZaposleniID";
                SqlCommand command = new SqlCommand(query, veza);
                command.Parameters.AddWithValue("@ZaposleniID", id);

                try
                {
                    veza.Open();
                    int br = (int)command.ExecuteScalar();
                    veza.Close();

                    if (br > 0)
                    {
                        string query1 = "SELECT Pozicija FROM Zaposleni WHERE Id = @ZaposleniID";
                        SqlCommand command1 = new SqlCommand(query1, veza);
                        command1.Parameters.AddWithValue("@ZaposleniID", id);

                        veza.Open();
                        string str = (string)command1.ExecuteScalar();
                        veza.Close();

                        switch (str)
                        {
                            case "Konobarica":
                                sala sa = new sala();
                                sa.Show();
                                break;
                            case "Kuvar":
                                kuhinja k = new kuhinja();
                                k.Show();
                                break;
                            case "sanker":
                                sank s = new sank();
                                s.Show();
                                break;
                            case "Šef":
                                stanje st = new stanje();
                                st.Show();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Zaposleni sa ID-em {id} ne postoji.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška prilikom izvršavanja upita: " + ex.Message);
                }
            }
        }
    }
}
