using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PraktikumADO
{
    public partial class Form1 : Form
    {
        // Deklarasi objek koneksi dan command
        SqlConnection conn;
        // cmd  = objek untuk mengirim perintah SQL ke database
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            
        }

        // Membuka koneksi ke database
        private void Koneksi()
        {
            conn = new SqlConnection(
                "Data Source=LAPTOP-4UOCIEQ0\\FAIZADITYA;Initial Catalog=DBAkademikADO;Integrated Security=True"
                );
            
        }

        // Menambahkan kode yang otomatis berjalan ketika tombol Connect diklik oleh user.
        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                MessageBox.Show("Koneksi ke database berhasil");

                conn.Close();
            }

            //  menampilkan pesan error jika terjadi kesalahan saat membuka koneksi(try).
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
         }

        // Method untuk menghitung jumlah data mahasiswa.
        private void HitungMhs_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                string query = "SELECT COUNT(*) FROM Mahasiswa";

                cmd = new SqlCommand(query, conn);

                // Ambil hasilnya (1 angka) 
                int jumlah = (int)cmd.ExecuteScalar();

                txtHasil.Text = jumlah.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Method untuk menghitung jumlah Mahasiswa.
        private void HitungMK_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                // Variabel bertipe teks untuk menyimpan perintah SQL.
                string query = "SELECT COUNT(*) FROM Matakuliah";

                cmd = new SqlCommand(query, conn);

                int jumlah = (int)cmd.ExecuteScalar();

                txtHasil.Text = jumlah.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Menambahkan method untuk mengubah data di db.
        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                string query = "UPDATE Mahasiswa SET Alamat = 'Cilacap' WHERE NIM = '20240150065'";

                cmd = new SqlCommand(query, conn);

                int hasil = cmd.ExecuteNonQuery();

                MessageBox.Show("Jumlah Baris terpengaruh: " + hasil);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHitungDosen_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                string query = "SELECT COUNT(*) FROM Dosen";

                cmd = new SqlCommand(query, conn);

                int jumlah = (int)cmd.ExecuteScalar();

                txtHasil.Text = jumlah.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                string query = "UPDATE MataKuliah SET SKS = 4 WHERE KodeMK = 'IF210101'";

                cmd = new SqlCommand(query, conn);

                int hasil = cmd.ExecuteNonQuery(); // tidak menghasilkan data

                MessageBox.Show("Jumlah baris terpengaruh: " + hasil);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                string query = "INSERT INTO ProgramStudi VALUES ('MI01', 'Manajemen Informatika')";

                cmd = new SqlCommand(query, conn);

                int hasil = cmd.ExecuteNonQuery(); // INSERT juga pakai ExecuteNonQuery

                MessageBox.Show("Data berhasil ditambahkan! Baris terpengaruh: " + hasil);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
 }

