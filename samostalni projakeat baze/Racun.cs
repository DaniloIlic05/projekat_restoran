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
    public partial class Racun : Form
    {
        private int broj_stola;
        private const string ConnectionString = "Data Source=.;Initial Catalog=restoran;Integrated Security=True";

        public Racun()
        {
            InitializeComponent();
        }

        public Racun(int broj_stola)
        {
            InitializeComponent();

            this.broj_stola = broj_stola;

            lblSto.Text = "Sto broj: " + broj_stola.ToString();
        }

        private void btnhrana_Click(object sender, EventArgs e)
        {
            dgvArtikli.ClearSelection();

            string query = "SELECT Artikl.Id, Artikl.Naziv, Artikl.Cena, Magacin.Kolicina " +
                           "FROM Artikl LEFT JOIN Magacin ON Artikl.Id = Magacin.ArtiklID " +
                           "WHERE Artikl.Kategorija = 1";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable menuTable = new DataTable();
                adapter.Fill(menuTable);

                dgvArtikli.DataSource = menuTable;
            }
        }

        private void btnpice_Click(object sender, EventArgs e)
        {
            dgvArtikli.ClearSelection();

            string query = "SELECT Artikl.Id, Artikl.Naziv, Artikl.Cena, Magacin.Kolicina " +
                           "FROM Artikl LEFT JOIN Magacin ON Artikl.Id = Magacin.ArtiklID " +
                           "WHERE Artikl.Kategorija = 0";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable menuTable = new DataTable();
                adapter.Fill(menuTable);

                dgvArtikli.DataSource = menuTable;
            }
        }

        private void Racun_Load()
        {
            dgvRacun.ClearSelection();

            string query = "SELECT Artikl.Id, Artikl.Naziv, Artikl.Cena, sto.id " +
                           "FROM Artikl " +
                           "JOIN sto ON Artikl.Id = sto.ArtiklId " +
                           "WHERE sto.Broj = " + broj_stola.ToString() + " AND sto.Zauzet = 0";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable menuTable = new DataTable();
                adapter.Fill(menuTable);

                dgvRacun.DataSource = menuTable;
            }
        }

        private void dgvArtikli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvArtikli.Rows[e.RowIndex];

                Decimal.TryParse(lblUkupno.Text, out Decimal n);

                lblUkupno.Text = Convert.ToString(n + (Decimal)row.Cells["Cena"].Value);

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "INSERT INTO sto (Broj, X_kordinata, Y_kordinata, Zauzet, ArtiklId)" +
                                   "VALUES (@Broj, -100, -100, 0, @ArtiklId);";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Broj", broj_stola);
                    command.Parameters.AddWithValue("@ArtiklId", row.Cells["Id"].Value);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

            Racun_Load();
        }

        private void dgvRacun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRacun.Rows[e.RowIndex];

                Decimal.TryParse(lblUkupno.Text, out Decimal n);

                lblUkupno.Text = Convert.ToString(n - (Decimal)row.Cells["Cena"].Value);

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "DELETE FROM sto WHERE ArtiklId = @Id AND Zauzet = 0 AND sto.id = @StoId";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Id", row.Cells["Id"].Value);
                    command.Parameters.AddWithValue("@StoId", row.Cells["id1"].Value);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

            Racun_Load();
        }

        private void btnnaplati_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "UPDATE sto SET Zauzet = 1 WHERE Broj = " + broj_stola.ToString() + " AND X_Kordinata = -100";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {

                }

                foreach (DataGridViewRow row in dgvRacun.Rows)
                {
                    string query1 = "UPDATE Magacin SET Kolicina = Kolicina - 1 WHERE ArtiklId = @ArtiklId";
                    SqlCommand command1 = new SqlCommand(query1, connection);
                    command1.Parameters.AddWithValue("@ArtiklId", row.Cells["Id"].Value);

                    try
                    {
                        connection.Open();
                        command1.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

            this.Close();
        }

        private void btnpresek_Click(object sender, EventArgs e)
        {
            string query = "SELECT Artikl.naziv, COUNT(*) AS Kolicina " +
                           "FROM Artikl JOIN sto ON Artikl.Id = sto.ArtiklId " +
                           "WHERE sto.Zauzet = 1" +
                           "GROUP BY Artikl.Id, Artikl.Naziv;";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable menuTable = new DataTable();
                adapter.Fill(menuTable);

                dgvstanje.Visible = true;
                dgvstanje.BringToFront();
                dgvstanje.DataSource = menuTable;
            }
        }

        private void btnkraj_Click(object sender, EventArgs e)
        {
            string query = "SELECT Artikl.naziv, COUNT(*) AS Kolicina " +
                           "FROM Artikl JOIN sto ON Artikl.Id = sto.ArtiklId " +
                           "WHERE sto.Zauzet = 1" +
                           "GROUP BY Artikl.Id, Artikl.Naziv;";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable menuTable = new DataTable();
                adapter.Fill(menuTable);

                dgvstanje.Visible = true;
                dgvstanje.BringToFront();
                dgvstanje.DataSource = menuTable;
            }

            query = "SELECT SUM(Artikl.Cena) " +
                    "FROM Artikl JOIN sto ON Artikl.Id = sto.ArtiklId " +
                    "WHERE sto.Zauzet = 1" +
                    "GROUP BY Artikl.Cena;";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MessageBox.Show("Ukupan dnevni promet: " + Convert.ToString(command.ExecuteScalar()));
                    connection.Close();
                }
                catch (Exception ex)
                {

                }
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                query = "DELETE FROM sto WHERE Zauzet = 1";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {

                }
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                query = "DELETE FROM racun";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void Racun_Load(object sender, EventArgs e)
        {
            dgvstanje.Visible = false;

            Racun_Load();
        }
    }
}