using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwarePIM
{
    public partial class Frm_PopUpMenu : Form
    {
        public Frm_PopUpMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm_TelaInicial frm_TelaInicial = new Frm_TelaInicial();

            frm_TelaInicial.Show();

            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
