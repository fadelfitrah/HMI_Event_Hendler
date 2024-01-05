using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HMI_Events_Manajement
{
    public partial class mainFrom : Form
    {
        private MySqlConnection connection;
        private string roleUser;
        private string namaUserLogin;
        private string server = "localhost";
        private string database = "hmi_events";
        private string uid = "root";
        private string password = "";

        public mainFrom(string role, string nama)
        {
            InitializeComponent();
            InitializeComponent2();
            InitializeDatabase();
            roleUser = role;
            namaUserLogin = nama;
            if(role == "anggota")
            {
                this.button4.Visible = false;
            }
            Usermessage.Visible = false;
            label27.Visible = false;
            showNotif();
        }

        private void showNotif()
        {
            string nama = namaUserLogin;
            string query = "SELECT * FROM message";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string msg = reader.GetString(1);
                        if (msg.Contains(namaUserLogin.ToString()))
                        {
                            this.label27.Visible = true;
                        }
                    }
                }
            }
        }

        private void InitializeDatabase()
        {
            string connectionString;
            connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }

        private void daftarEvents_Click(object sender, EventArgs e)
        {
            List<string> kegiatanData = new List<string>
        {
            "Event 1: Deskripsi Event 1",
            "Event 2: Deskripsi Event 2",
            "Event 3: Deskripsi Event 3"
            // Tambahkan data kegiatan lainnya sesuai kebutuhan
        };

            // Tampilkan data kegiatan di FlowLayoutPanel
            foreach (string data in kegiatanData)
            {
                Label label = new Label();
                label.Text = data;
                halaman.Controls.Add(label);
            }
        }

        private void home_Click(object sender, EventArgs e)
        {

        }

        private List<string> GetUserNames()
        {
            List<string> userNames = new List<string>();
            string query = "SELECT * FROM users";

            // Pastikan koneksi sudah terbuka
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Mengakses semua nama pengguna
                        string nama = reader.GetString(3); // Ubah angka indeks kolom sesuai dengan struktur tabel Anda
                        userNames.Add(nama);
                    }
                }
            }

            return userNames;
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void detail1_Click(object sender, EventArgs e)
        {
            this.event1Desc.Visible = true;
            if(this.Usermessage.Visible == true)
            {
                this.Usermessage.Visible = false;
            }
            this.label23.Text = "Pelantikan Pengurus";
            this.label24.Text = "12 Februari 2024";
            this.label25.Text = "Semua anggota & undangan";
            this.label26.Text = "Gedung Kebudayaan";
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void detail2_Click(object sender, EventArgs e)
        {
            if (this.Usermessage.Visible == true)
            {
                this.Usermessage.Visible = false;
            }
            this.label23.Text = "Pelatihan Pemrogramman";
            this.label24.Text = "29 Februari 2024";
            this.label25.Text = "Semua anggota";
            this.label26.Text = "Kondisional";
        }

        private void detail3_Click(object sender, EventArgs e)
        {
            if (this.Usermessage.Visible == true)
            {
                this.Usermessage.Visible = false;
            }
            this.label23.Text = "Seminar Islam & Sains";
            this.label24.Text = "15 Maret 2024";
            this.label25.Text = "Semua anggota & undangan";
            this.label26.Text = "Kondisional";
        }

        private void detail4_Click(object sender, EventArgs e)
        {
            if (this.Usermessage.Visible == true)
            {
                this.Usermessage.Visible = false;
            }
            this.label23.Text = "Latihan Kader I";
            this.label24.Text = "1 April 2024";
            this.label25.Text = "Semua anggota, undangan & calon anggota";
            this.label26.Text = "Kondisional";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.event1Desc.Visible = false;
            Usermessage.Visible = true;
            Usermessage.Size = new Size(800, 325);
            List<string> allUserNames = GetUserNames();

            // Mengakses nama pengguna dalam List
            if (allUserNames.Count > 0)
            {
                string nama1 = allUserNames[0];
                string nama2 = allUserNames.Count > 1 ? allUserNames[1] : string.Empty;
                string nama3 = allUserNames.Count > 2 ? allUserNames[2] : string.Empty;

                this.button1.Text = nama1;
                this.button3.Text = nama2;
                this.button5.Text = nama3;
            }
            else
            {
                MessageBox.Show("Tidak ada nama pengguna yang ditemukan.");
            }
        }

        private void kalenderEvents_Click(object sender, EventArgs e)
        {
            this.pelantikanGroup.Visible = false;
            this.pelatihan.Visible = false;
            this.groupBox5.Visible = false;
            this.groupBox7.Visible = false;
            this.detailShow.Visible = false;

            string eventName = label1.Text;
            string eventDescription = label2.Text; ;
            string eventDate = label3.Text;
            string eventTime = label4.Text;

            // Tambahkan elemen baru pada FlowLayoutPanel
            AddNewEventElement(eventName, eventDescription, eventDate, eventTime);
        }

        private void AddNewEventElement(string eventName, string eventDescription, string eventDate, string eventTime)
        {
            Panel eventPanel = new Panel();
            eventPanel.BorderStyle = BorderStyle.FixedSingle;
            eventPanel.Width = halaman.Width - 20;
            eventPanel.Margin = new Padding(5);

            Label nameLabel = new Label();
            nameLabel.Text = "Event: " + eventName;

            Label descriptionLabel = new Label();
            descriptionLabel.Text = "Deskripsi: " + eventDescription;

            Label dateLabel = new Label();
            dateLabel.Text = "Tanggal: " + eventDate;

            Label timeLabel = new Label();
            timeLabel.Text = "Lokasi " + eventTime;

            eventPanel.Controls.Add(nameLabel);
            eventPanel.Controls.Add(descriptionLabel);
            eventPanel.Controls.Add(dateLabel);
            eventPanel.Controls.Add(timeLabel);

            halaman.Controls.Add(eventPanel);
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void mainFrom_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list = GetUserNames();
            string nama1 = list[0];
            this.userMessageText.Text = $"Send to : {nama1}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> list = GetUserNames();
            string nama = list[1];
            this.userMessageText.Text = $"Send to : {nama}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> list = GetUserNames();
            string nama = list[2];
            this.userMessageText.Text = $"Send to : {nama}";
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string sendBy = namaUserLogin;
            string messageValue = this.userMessageText.Text;
            string query = $"INSERT INTO message values('{sendBy}', '{messageValue}')";
            using(MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Message already sent");
            }
        }

        private void notifications_Click(object sender, EventArgs e)
        {
            string nama = namaUserLogin;
            string query = "SELECT * FROM message";
            using(MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string msg = reader.GetString(1);
                        string from = reader.GetString(0);
                        string showThis = $"{from}\n{msg}\n";
                        if (msg.Contains(namaUserLogin.ToString()))
                        {
                            this.label27.Visible = false;
                            MessageBox.Show($"Dari : {showThis}");
                        }
                    }
                }
                connection.Close();
            }
        }
    }
}
