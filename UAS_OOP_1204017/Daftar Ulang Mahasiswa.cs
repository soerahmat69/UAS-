using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_OOP_1204017
{
    public partial class Daftar_Ulang_Mahasiswa : Form
    {
        private MySqlCommand cmd;
        private DataSet ds;
        private MySqlDataAdapter da;
        private MySqlDataReader rd;

       

        void limakosong()
        {
            textBox5.Text = string.Format(new CultureInfo("id-ID"), "{0:C}", double.Parse(textBox4.Text, NumberStyles.Currency) * 0.5);
            textBox6.Text = string.Format(new CultureInfo("id-ID"), "{0:C}", double.Parse(textBox4.Text, NumberStyles.Currency) - double.Parse(textBox5.Text, NumberStyles.Currency));


        }

        void dualima()
        {
            textBox5.Text = string.Format(new CultureInfo("id-ID"), "{0:C}", double.Parse(textBox4.Text, NumberStyles.Currency) * 0.25);
            textBox6.Text = string.Format(new CultureInfo("id-ID"), "{0:C}", double.Parse(textBox4.Text, NumberStyles.Currency) - double.Parse(textBox5.Text, NumberStyles.Currency));
        }
        void sepuluh()
        {
            textBox5.Text = string.Format(new CultureInfo("id-ID"), "{0:C}", double.Parse(textBox4.Text, NumberStyles.Currency) * 0.1);
            textBox6.Text = string.Format(new CultureInfo("id-ID"), "{0:C}", double.Parse(textBox4.Text, NumberStyles.Currency) - double.Parse(textBox5.Text, NumberStyles.Currency));
        }


        public Daftar_Ulang_Mahasiswa()
        {
            InitializeComponent();
        }

        private void reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox6.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan semua terisi");
            }
            else
            {
                string npm = textBox1.Text.Trim();
                double totalbiaya = double.Parse(textBox6.Text, NumberStyles.Currency);
                string grade = string.Empty;
                if (radioButton1.Checked)
                {
                    grade = "A";
                }
                else if (radioButton2.Checked)
                {
                    grade = "B";
                }
                else if (radioButton3.Checked)
                {
                    grade = "C";
                }

                Query database = new Query();
                MySqlConnection conn = database.koneksi();
                cmd = new MySqlCommand("INSERT INTO tr_daftar_ulang VALUES(@NPM, @Grade, @Total_Biaya)");
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@NPM", npm);
                cmd.Parameters.AddWithValue("@Grade", grade);
                cmd.Parameters.AddWithValue("@Total_Biaya", totalbiaya);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Transaksi Berhasil Di tambahkan");
                reset();

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Query database = new Query();
            MySqlConnection conn = database.koneksi();
            conn.Open();
            cmd = new MySqlCommand($"select nama_mhs, nama_prodi, biaya_kuliah from ms_mhs inner join ms_prodi using(kode_prodi) where npm={textBox1.Text}", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                textBox2.Text = rd[0].ToString();
                textBox3.Text = rd[1].ToString();
                //textBox4.Text = rd[2].ToString();
                textBox4.Text = string.Format(new CultureInfo("id-ID"), "{0:C}", rd[2]);


            }
            else
            {
                MessageBox.Show("NPM TIDAK DITEMUKAN");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Query database = new Query();
                MySqlConnection conn = database.koneksi();
                conn.Open();
                cmd = new MySqlCommand($"select nama_mhs, nama_prodi, biaya_kuliah from ms_mhs inner join ms_prodi using(kode_prodi) where npm={textBox1.Text}", conn);
                rd = cmd.ExecuteReader();
                rd.Read();
                if (rd.HasRows)
                {
                    textBox2.Text = rd[0].ToString();
                    textBox3.Text = rd[1].ToString();
                    textBox4.Text = string.Format(new CultureInfo("id-ID"), "{0:C}", rd[2]);
                }
                else
                {
                    MessageBox.Show("npm gada");
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            limakosong();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dualima();
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            sepuluh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
