using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_OOP_1204017
{
    class Query
    {

        string strkoneksi = "server=localhost;uid=root;pwd=;database=uas;";
        public void inputData(string cmd)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(strkoneksi);
                conn.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = cmd;
                command.ExecuteNonQuery();
                MessageBox.Show("Berhasil Di Tambahkan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        public void inputDataProdi(string cmd)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(strkoneksi);
                conn.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = cmd;
                command.ExecuteNonQuery();
                MessageBox.Show("Prodi Berhasil Di Tambahkan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void DeleteData(string cmd)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(strkoneksi);
                conn.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = cmd;
                command.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Terhapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ulang ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        public void UpdateDataBon(string cmd)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(strkoneksi);
                conn.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = cmd;
                command.ExecuteNonQuery();
                MessageBox.Show("Data berhasil terupdate", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ulang ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        public MySqlConnection koneksi()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(strkoneksi);
                return conn;
            }
            catch
            {
                throw new Exception("Error");
            }
        }


    }
}
