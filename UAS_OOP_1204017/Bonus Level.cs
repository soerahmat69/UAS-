using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_OOP_1204017
{
    public partial class Bonus_Level : Form
    {
        public Bonus_Level()
        {
            InitializeComponent();
        }

        string prods;
        private void prodi_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;Database=uas;username=root;password=;");
            string selectQuery = "SELECT kode_prodi  FROM ms_prodi";
            connection.Open();

            MySqlCommand command = new MySqlCommand(selectQuery, connection);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                prodi.Items.Add(reader.GetString("kode_prodi"));

            }

            connection.Close();

            prods = prodi.Text;
        }
        private void submit_Click(object sender, EventArgs e)
        {
            if (NamaMah.Text == "" || NPM.Text == "" || prodi.Text == "")
            {

               

                switch (NamaMah.Text)
                {
                    case "":
                        MessageBox.Show("Nama Mahasiswanya kosong");
                        break;
                }
                switch (NPM.Text)
                {
                    case "":
                        MessageBox.Show("masa NPMnya kosong");
                        break;
                }
                switch (prodi.Text)
                {
                    case "":
                        MessageBox.Show("masa prodi kosong");
                        break;
                }

            }
            else
            {
                Query bukaFungsi = new Query();
                string cmdsave = "insert into ms_mhs values('" + NPM.Text + "','" + NamaMah.Text + "','" + prods + "')";
                bukaFungsi.inputData(cmdsave);
            }
        }

        private void buttclearon2_Click(object sender, EventArgs e)
        {
            NamaMah.Clear();
            NPM.Clear();
         
        }
    }
}
