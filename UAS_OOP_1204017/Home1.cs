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
    public partial class Home1 : Form
    {
        public Home1()
        {
            InitializeComponent();
        }

        private void mahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bonus_Level bns = new Bonus_Level();
            bns.Show();
        }

        private void prodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramStudi prodi = new ProgramStudi();
            prodi.Show();

        }

        private void mahasiswaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewMhs vms = new ViewMhs();
            vms.Show();
        }

        private void prodiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewProdi vp = new ViewProdi();
            vp.Show();
        }

        private void tansaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  ViewUlang vu = new ViewUlang();
          //  vu.Show();
        }

        private void transaksiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Daftar_Ulang_Mahasiswa dft = new Daftar_Ulang_Mahasiswa();
            dft.Show();
        }
    }
}
