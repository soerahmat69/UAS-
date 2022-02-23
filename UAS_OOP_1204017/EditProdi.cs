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
    public partial class EditProdi : Form
    {
        public EditProdi()
        {
            InitializeComponent();
        }

        private void EditProdi_Load(object sender, EventArgs e)
        {

        }

        string ids;
        public EditProdi(string id) :this() {
            ids = id;
        }

        private void submit_Click(object sender, EventArgs e)
        {

            // hasill =  total.Text ;
            MessageBox.Show("yakin mau di update?");

            if (ids != "")
            {
                Query bukaFungsi = new Query();
                string cmdsave = "update ms_prodi set kode_prodi = '" + kode.Text + "', nama_prodi ='" + Namprod.Text + "',singkatan ='" + Singkat.Text + ",biaya_kuliah ='" + Bikul.Text +"';";
                bukaFungsi.UpdateDataBon(cmdsave);
            }
            else
            {
                Query bukaFungsi = new Query();
                string cmdsave = "update ms_prodi set kode_prodi = '" + kode.Text + "', nama_prodi ='" + Namprod.Text + "',singkatan ='" + Singkat.Text + ",biaya_kuliah ='" + Bikul.Text + "';";
                bukaFungsi.UpdateDataBon(cmdsave);
            }
        }
    }
}
