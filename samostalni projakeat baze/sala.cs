using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace samostalni_projakeat_baze
{
    public partial class sala : Form
    {
        private const string ConnectionString = "Data Source=.;Initial Catalog=restoran;Integrated Security=True";
        private bool n = false;
        private bool deleteMode = false;
        private int selectedTableIdToDelete = -1;
        private Point mouseDownLocation;

        public sala()
        {
            InitializeComponent();
        }

        private void LoadTables()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Sto WHERE Zauzet = 0 AND X_kordinata > -100";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int tableNumber = (int)reader["Broj"];
                        int tableCapacity = (int)reader["Kapacitet"];
                        bool tableOccupied = (bool)reader["Zauzet"];
                        int X = (int)reader["X_kordinata"];
                        int Y = (int)reader["Y_kordinata"];

                        Button tableButton = new Button();
                        tableButton.Text = $"Sto {tableNumber}\nKapacitet: {tableCapacity}";
                        tableButton.Tag = tableNumber;
                        tableButton.Click += TableButton_Click;
                        tableButton.MouseDown += TableButton_MouseDown;
                        tableButton.MouseMove += TableButton_MouseMove;
                        tableButton.Location = new Point(X, Y);

                        if (tableOccupied)
                        {
                            tableButton.BackColor = Color.Red;
                        }
                        else
                        {
                            tableButton.BackColor = Color.Green;
                        }

                        panel1.Controls.Add(tableButton);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Greška prilikom učitavanja stolova: {ex.Message}");
                }
            }
        }

        private void sala_Load(object sender, EventArgs e)
        {
            LoadTables();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteMode = true;
        }

        private void TableCordinate(int X, int Y, int Broj)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("UPDATE sto SET X_kordinata = @X, Y_kordinata = @Y WHERE Broj = @Broj", connection);

                command.Parameters.AddWithValue("@X", X);
                command.Parameters.AddWithValue("@Y", Y);
                command.Parameters.AddWithValue("@Broj", Broj);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Greška prilikom ažuriranja stola: {ex.Message}");
                }
            }
        }

        private void TableButton_MouseDown(object sender, MouseEventArgs e)
        {
            if(n)
            {
                if (e.Button == MouseButtons.Left)
                {
                    mouseDownLocation = e.Location;

                    Button button = sender as Button;
                    TableCordinate(button.Location.X, button.Location.Y, (int)button.Tag);
                }
            }
        }

        private void TableButton_MouseMove(object sender, MouseEventArgs e)
        {
            if(n)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Button button = sender as Button;
                    button.Left = e.X + button.Left - mouseDownLocation.X;
                    button.Top = e.Y + button.Top - mouseDownLocation.Y;

                    TableCordinate(button.Location.X, button.Location.Y, (int)button.Tag);
                }
            }
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            if(n)
            {
                Button clickedButton = (Button)sender;
                int tableId = (int)clickedButton.Tag;
            }
            else if (deleteMode)
            {
                Button clickedButton = (Button)sender;
                selectedTableIdToDelete = (int)clickedButton.Tag;

                DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj sto?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DeleteSelectedTable(selectedTableIdToDelete);
                }

                deleteMode = false;
                selectedTableIdToDelete = -1;

                panel1.Controls.Remove(clickedButton);
            }
            else
            {
                Button clickedButton = (Button)sender;
                clickedButton.BackColor = Color.Red;

                Racun racun = new Racun((int)clickedButton.Tag);
                racun.Show();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "INSERT INTO sto (Broj, Kapacitet, X_kordinata, Y_kordinata, Zauzet)" +
                               "VALUES (@Broj, @Kapacitet, 0, 0, 0);";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Broj", txtbroj.Text);
                command.Parameters.AddWithValue("@Kapacitet", txtkapacitet.Text);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Greška prilikom dodavanja stola: {ex.Message}");
                }
            }

            Button tableButton = new Button();
            tableButton.Text = $"Sto {txtbroj.Text}\nKapacitet: {txtkapacitet.Text}";
            tableButton.Tag = Convert.ToInt32(txtbroj.Text);
            tableButton.Click += TableButton_Click;
            tableButton.MouseDown += TableButton_MouseDown;
            tableButton.MouseMove += TableButton_MouseMove;

            panel1.Controls.Add(tableButton);
        }

        private void DeleteSelectedTable(int tableId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("DELETE FROM sto WHERE Broj = @Id", connection);

                command.Parameters.AddWithValue("@Id", tableId);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sto je uspešno obrisan.");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Greška prilikom brisanja stola: {ex.Message}");
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("UPDATE sto SET Kapacitet = @Kapacitet, Zauzet = @Zauzet WHERE Broj = @Broj", connection);

                command.Parameters.AddWithValue("@Broj", txtbroj.Text);
                command.Parameters.AddWithValue("@Kapacitet", txtkapacitet.Text);
                command.Parameters.AddWithValue("@Zauzet", 0);


                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Greška prilikom ažuriranja stola: {ex.Message}");
                }
            }
        }

        private void btnpremesti_Click(object sender, EventArgs e)
        {
            n = !n;
        }
    }
}