using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racuni
{
    public partial class FormIzbrisi : Form
    {
        public FormIzbrisi()
        {
            InitializeComponent();
        }

        private void buttonIzbrisiNe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm();
            f.izbrisiToolStripMenuItem_Click(null, null);
            this.Close();
        }
    }
}
