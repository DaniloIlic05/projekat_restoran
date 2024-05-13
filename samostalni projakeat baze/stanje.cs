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
    public partial class stanje : Form
    {
        public stanje()
        {
            InitializeComponent();
        }

        private const string ConnectionString = "Data Source=.;Initial Catalog=restoran;Integrated Security=True";

        private void LoadMenuItems()
        {
            string query = "SELECT Artikl.Id, Artikl.Naziv, Artikl.Cena, Magacin.Kolicina " +
                           "FROM Artikl LEFT JOIN Magacin ON Magacin.ArtiklId = Artikl.Id";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable menuTable = new DataTable();
                adapter.Fill(menuTable);

                dgvstanje.DataSource = menuTable;
            }
        }

        private void stanje_Load(object sender, EventArgs e)
        {
            LoadMenuItems();
        }

        private void btndodaj_Click(object sender, EventArgs e)
        {
            if (dgvstanje.SelectedRows.Count == 1)
            {
                int itemId = (int)dgvstanje.SelectedRows[0].Cells["Id"].Value;
                int kol = (int)dgvstanje.SelectedRows[0].Cells["Kolicina"].Value;

                string query = "UPDATE Magacin SET Kolicina = @Kolicina WHERE Id = @Id";

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Kolicina", kol + Convert.ToInt32(txtunos.Text));
                    command.Parameters.AddWithValue("@Id", itemId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadMenuItems();
            }
        }

        private void btnotpis_Click(object sender, EventArgs e)
        {
            if (dgvstanje.SelectedRows.Count == 1)
            {
                int itemId = (int)dgvstanje.SelectedRows[0].Cells["Id"].Value;
                int kol = (int)dgvstanje.SelectedRows[0].Cells["Kolicina"].Value;

                string query = "UPDATE Magacin SET Kolicina = @Kolicina WHERE Id = @Id";

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Kolicina", kol - Convert.ToInt32(txtunos.Text));
                    command.Parameters.AddWithValue("@Id", itemId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                LoadMenuItems();
            }
        }
    }
}
