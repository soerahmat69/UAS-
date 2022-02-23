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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void mahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bonus_Level bns = new Bonus_Level();
            this.Show(bns);

        }
    }
}
