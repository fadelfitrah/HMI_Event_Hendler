using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HMI_Events_Manajement
{
    public partial class Form1 : Form
    {

        private MySqlConnection connection;
        private string server = "localhost";
        private string database = "hmi_events";
        private string uid = "root";
        private string password = "";

        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            string connectionString;
            connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM users WHERE username=@username AND password=@password";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@username", userName.Text);
                cmd.Parameters.AddWithValue("@password", userPassword.Text);

                connection.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string role = reader["role"]?.ToString();
                        string nama = reader["nama"]?.ToString();
                        MessageBox.Show("Login successful!");
                        this.Hide();

                        mainFrom MainFrom = new mainFrom(role, nama);
                        MainFrom.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials. Please try again.");
                    }
                }
                connection.Close();
            }
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void descBtn_Click(object sender, EventArgs e)
        {
            string aplicationName = "HMI Events";
            string desc = $"Wellcome to {aplicationName}, now you can get information about every event in HMI Organization.\nHere you can do absen for the event, get notification\nand do message with other member";
            
            MessageBox.Show($"Deskcription : {desc}");
        }
    }
}
