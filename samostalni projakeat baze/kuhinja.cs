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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace samostalni_projakeat_baze
{
    public partial class kuhinja : Form
    {

        public kuhinja()
        {
            InitializeComponent();
        }

        private void kuhinja_Load(object sender, EventArgs e)
        {
            LoadMenuItems();
        }

        private void kuhinja_Close(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private const string ConnectionString = "Data Source=.;Initial Catalog=restoran;Integrated Security=True";

        private void LoadMenuItems()
        {
            string query = "SELECT Artikl.Id, Artikl.Naziv, Artikl.Cena, Magacin.Kolicina " +
                           "FROM Artikl LEFT JOIN Magacin ON Artikl.Id = Magacin.ArtiklID " +
                           "WHERE Artikl.Kategorija = 1";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable menuTable = new DataTable();
                adapter.Fill(menuTable);

                dgvkuhinja.DataSource = menuTable;
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

        private void btninsert_Click(object sender, EventArgs e)
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgvkuhinja.SelectedRows.Count == 1)
            {
                int itemId = (int)dgvkuhinja.SelectedRows[0].Cells["Id"].Value;
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete ovu stavku iz jelovnika?", "Brisanje stavke", MessageBoxButtons.YesNo);
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dgvkuhinja.SelectedRows.Count == 1)
            {
                string query = "UPDATE Artikl SET Naziv = @Naziv, Cena = @Cena, Kategorija = @Kategorija WHERE Id = @Id";

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Naziv", txtnaziv.Text);
                    command.Parameters.AddWithValue("@Cena", Convert.ToDecimal(txtcena.Text));
                    command.Parameters.AddWithValue("@Kategorija", true);
                    command.Parameters.AddWithValue("@Id", dgvkuhinja.SelectedRows[0].Cells["Id"].Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                LoadMenuItems();
            }
            else
            {
                MessageBox.Show("Molimo odaberite jedan red za uređivanje.");
            }
        }

        private void btnnormativ_Click(object sender, EventArgs e)
        {
            if (dgvkuhinja.SelectedRows.Count == 1)
            {
                int itemId = (int)dgvkuhinja.SelectedRows[0].Cells["Id"].Value;
                normativ n = new normativ(itemId);
                n.Show();
                LoadMenuItems();
            }
            else
            {
                MessageBox.Show("Molimo odaberite jedan red za uređivanje normativa.");
            }
        }

        private void dgvkuhinja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvkuhinja.Rows[e.RowIndex];

                txtnaziv.Text = row.Cells["naziv"].Value.ToString();
                txtcena.Text = row.Cells["cena"].Value.ToString();
            }
        }
    }
}
