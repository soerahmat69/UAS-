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
    public partial class ProgramStudi : Form
    {
       

        public ProgramStudi()
        {
            InitializeComponent();
        }

        private void ProgramStudi_Load(object sender, EventArgs e)
        {
           
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (kode.Text == "" || Namprod.Text == "" || Bikul.Text == "" || Singkat.Text == "")
            {

                switch (kode.Text)
                {
                    case "":
                        MessageBox.Show("kode gaboleh kosong");
                        break;
                }
                switch (Namprod.Text)
                {
                    case "":
                        MessageBox.Show("nama prodi gaboleh  kosong");
                        break;
                }
                switch (Bikul.Text)
                {
                    case "":
                        MessageBox.Show("biaya kuliah gaboleh kosong");
                        break;
                }
         
            }
            else
            {
                Query bukaFungsi = new Query();
                string cmdsave = "insert into ms_prodi values('" + kode.Text + "','" + Namprod.Text + "','" + Singkat.Text + "','" + Bikul.Text + "')";
                bukaFungsi.inputDataProdi(cmdsave);
            }
        }

       
    }
}
