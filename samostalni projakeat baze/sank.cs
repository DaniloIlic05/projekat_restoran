using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace samostalni_projakeat_baze
{
    public partial class sank : Form
    {
        public sank()
        {
            InitializeComponent();
        }

        private void sank_Load(object sender, EventArgs e)
        {
            LoadMenuItems();
        }

        private void sank_Close(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private const string ConnectionString = "Data Source=.;Initial Catalog=restoran;Integrated Security=True";

        private void LoadMenuItems()
        {
            string query = "SELECT Artikl.Id, Artikl.Naziv, Artikl.Cena, Normativ.Kolicina " +
                           "FROM Artikl LEFT JOIN Normativ ON Artikl.Id = Normativ.ArtiklID" +
                           "WHERE Kategorija = 0";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable menuTable = new DataTable();
                adapter.Fill(menuTable);

                dgvsank.DataSource = menuTable;
            }
        }

        private void DeleteMenuItem(int itemId)
        {
            string deleteItemQuery = "DELETE FROM Artikl WHERE Id = @ItemId";
            string deleteNormativQuery = "DELETE FROM Normativ WHERE ArtiklID = @ItemId";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand deleteItemCommand = new SqlCommand(deleteItemQuery, connection))
                using (SqlCommand deleteNormativCommand = new SqlCommand(deleteNormativQuery, connection))
                {
                    deleteItemCommand.Parameters.AddWithValue("@ItemId", itemId);
                    deleteNormativCommand.Parameters.AddWithValue("@ItemId", itemId);

                    deleteItemCommand.ExecuteNonQuery();
                    deleteNormativCommand.ExecuteNonQuery();
                }
            }

            LoadMenuItems();
        }

        private void btninsert_Click_1(object sender, EventArgs e)
        {
            string query = "INSERT INTO Artikl (Naziv, Cena, Kategorija) VALUES (@Naziv, @Cena, @Kategorija)";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Naziv", txtnaziv.Text);
                command.Parameters.AddWithValue("@Cena", Convert.ToDecimal(txtcena.Text));
                command.Parameters.AddWithValue("@Kategorija", true);

                connection.Open();
                command.ExecuteNonQuery();
            }

            LoadMenuItems();
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            if (dgvsank.SelectedRows.Count == 1)
            {
                int itemId = (int)dgvsank.SelectedRows[0].Cells["Id"].Value;
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete ovu stavku iz karte pica?", "Brisanje stavke", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DeleteMenuItem(itemId);
                }
            }
            else
            {
                MessageBox.Show("Molimo odaberite jedan red za brisanje.");
            }
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            if (dgvsank.SelectedRows.Count == 1)
            {
                if (Convert.ToBoolean(txtkategorija.Text))
                {
                    MessageBox.Show("Sank ne moze da uredjuje jelovnik.");
                }
                else
                {
                    string query = "UPDATE Artikl SET Naziv = @Naziv, Cena = @Cena, Kategorija = @Kategorija WHERE Id = @Id";

                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Naziv", txtnaziv.Text);
                        command.Parameters.AddWithValue("@Cena", Convert.ToDecimal(txtcena.Text));
                        command.Parameters.AddWithValue("@Kategorija", false);
                        command.Parameters.AddWithValue("@Id", dgvsank.SelectedRows[0].Cells["Id"].Value);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    LoadMenuItems();
                }
            }
            else
            {
                MessageBox.Show("Molimo odaberite jedan red za uređivanje.");
            }
        }

        private void btnnormativ_Click_1(object sender, EventArgs e)
        {
            if (dgvsank.SelectedRows.Count == 1)
            {
                int itemId = (int)dgvsank.SelectedRows[0].Cells["Id"].Value;
                normativ n = new normativ(itemId);
                n.Show();
                LoadMenuItems();
            }
            else
            {
                MessageBox.Show("Molimo odaberite jedan red za uređivanje normativa.");
            }
        }
    }
}
