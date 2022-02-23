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
    public partial class ViewMhs : Form
    {
        public ViewMhs()
        {
            InitializeComponent();
        }

        private void ViewMhs_Load(object sender, EventArgs e)
        {

            string strkoneksi = "server=localhost;uid=root;pwd=;database=uas;";
            MySqlConnection conn = new MySqlConnection(strkoneksi);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select * from ms_mhs ", conn);
            DataSet DS = new DataSet();


            mySqlDataAdapter.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.Columns[0].HeaderText = "npm";
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[0].Width = 90;
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].HeaderText = "nama_mhs";
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].HeaderText = "kode_prodi";
            dataGridView1.Columns[2].ReadOnly = true;
            conn.Close();

            this.dataGridView1.Refresh();
        }

        String id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                id = dataGridView1.Rows[e.RowIndex].Cells["kode_prodi"].FormattedValue.ToString();

                MessageBox.Show("kalau udah klik bisa milih delet dan edit oke");
                Editmhs edt = new Editmhs(id);
            }
            else
            {
                MessageBox.Show("jangn dikluk terus");
            }


        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            if (id != "")
            {
                Query bukaFungsi = new Query();
                string cmdsave = "Delete from ms_mhs where npm =" + id + ";";
                bukaFungsi.DeleteData(cmdsave);
            }
            else
            {
                MessageBox.Show("klik dulu kolumnya barubisa kelik ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Editmhs nn = new Editmhs();
            nn.Show();

            
                    
        }
    }
}
