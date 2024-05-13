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
    public partial class normativ : Form
    {
        public int id;
        private const string ConnectionString = "Data Source=.;Initial Catalog=restoran;Integrated Security=True";

        public normativ()
        {
            InitializeComponent();
        }

        public normativ(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void LoadNormativItems()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT Normativ.Id AS NormativId, Sastojci.Id AS SastojciID, Artikl.Naziv AS Artikl, Sastojci.Naziv AS Sastojak, Normativ.Kolicina " +
                           "FROM Normativ " +
                           "INNER JOIN Artikl ON Normativ.ArtiklID = Artikl.Id " +
                           "INNER JOIN Sastojci_Normativ ON Normativ.Id = Sastojci_Normativ.NormativID " +
                           "INNER JOIN Sastojci ON Sastojci_Normativ.SastojciID = Sastojci.id " +
                           "WHERE Artikl.Id = @Id";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@Id", id);
                adapter.Fill(dataTable);
            }

            dgvnormativ.DataSource = dataTable;
        }

        private void normativ_Load(object sender, EventArgs e)
        {
            LoadNormativItems();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            string query1 = "INSERT INTO Normativ (ArtiklID, Kolicina) OUTPUT inserted.id VALUES (@ArtiklID, @Kolicina)";
            string query2 = "INSERT INTO Sastojci (Naziv) OUTPUT inserted.id VALUES (@Naziv)";
            string query3 = "INSERT INTO Sastojci_Normativ (SastojciID, NormativID) VALUES (@SastojciID, @NormativID)";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlCommand command1 = new SqlCommand(query1, connection))
            using (SqlCommand command2 = new SqlCommand(query2, connection))
            using (SqlCommand command3 = new SqlCommand(query3, connection))
            {

                command1.Parameters.AddWithValue("@ArtiklID", id);
                command1.Parameters.AddWithValue("@Kolicina", Convert.ToInt32(txtkolicina.Text));

                command2.Parameters.AddWithValue("@Naziv", txtnaziv.Text);

                connection.Open();
                int normativ = Convert.ToInt32(command1.ExecuteScalar());
                int sastojci = Convert.ToInt32(command2.ExecuteScalar());
                command3.Parameters.AddWithValue("@SastojciID", sastojci);
                command3.Parameters.AddWithValue("@NormativID", normativ);
                command3.ExecuteNonQuery();
                connection.Close();
            }

            LoadNormativItems();
        }

        private void DeleteNormativItem(int itemId)
        {
            string deleteNormativQuery = "DELETE FROM Normativ WHERE id = @NormativID";
            string deleteSNQuery = "DELETE FROM Sastojci_Normativ WHERE NormativID = @NormativID";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand deleteSN = new SqlCommand(deleteSNQuery, connection))
                using (SqlCommand deleteNormativ = new SqlCommand(deleteNormativQuery, connection))
                {
                    deleteSN.Parameters.AddWithValue("NormativID", itemId);
                    deleteNormativ.Parameters.AddWithValue("@NormativID", itemId);

                    deleteSN.ExecuteNonQuery();
                    deleteNormativ.ExecuteNonQuery();
                }
            }

            LoadNormativItems();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgvnormativ.SelectedRows.Count == 1)
            {
                int itemId = (int)dgvnormativ.SelectedRows[0].Cells["NormativID"].Value;
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete ovu stavku iz normativa?", "Brisanje stavke", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DeleteNormativItem(itemId);
                }
            }
            else
            {
                MessageBox.Show("Molimo odaberite jedan red za brisanje.");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dgvnormativ.SelectedRows.Count == 1)
            {
                string normativQuery = "UPDATE Normativ SET Kolicina = @Kolicina WHERE Id = @Id";
                string sastojciQuery = "UPDATE Sastojci SET Naziv = @Naziv WHERE Id = @Id";

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command1 = new SqlCommand(normativQuery, connection))
                using (SqlCommand command2 = new SqlCommand(sastojciQuery, connection))
                {
                    command1.Parameters.AddWithValue("@Kolicina", txtkolicina.Text);
                    command1.Parameters.AddWithValue("@Id", dgvnormativ.SelectedRows[0].Cells["NormativID"].Value);

                    command2.Parameters.AddWithValue("@Naziv", txtnaziv.Text);
                    command2.Parameters.AddWithValue("@Id", dgvnormativ.SelectedRows[0].Cells["SastojciID"].Value);

                    connection.Open();
                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    connection.Close();
                }

                LoadNormativItems();
            }
            else
            {
                MessageBox.Show("Molimo odaberite jedan red za uređivanje.");
            }
        }
    }
}
