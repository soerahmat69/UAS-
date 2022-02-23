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
    public partial class Editmhs : Form
    {
        public Editmhs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        string ids;
        public Editmhs(string id) :this() {
            ids = id;
        }
        private void submit_Click(object sender, EventArgs e)
        {
            // hasill =  total.Text ;
            MessageBox.Show("yakin mau di update?");

            if (ids != "")
            {
                Query  bukaFungsi = new Query();
                string cmdsave = "update ms_mhs set npm = '" + NPM.Text + "', nama_mhs ='" + NamaMah.Text + "',kode_prodi ='" + prodi+";";
                bukaFungsi.UpdateDataBon(cmdsave);
            }
            else
            {
                Query bukaFungsi = new Query();
                string cmdsave = "update ms_mhs set npm = '" + NPM.Text + "', nama_mhs ='" + NamaMah.Text + "',kode_prodi ='" + prodi + ";";
                bukaFungsi.UpdateDataBon(cmdsave);
            }
        }
    }
}
