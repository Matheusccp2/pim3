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
    public partial class Frm_TelaSugestao : Form
    {
        public Frm_TelaSugestao()
        {
            InitializeComponent();
        }

        private void btn_VoltarMenu_Click(object sender, EventArgs e)
        {
            Frm_PopUpMenu frm_PopUpMenu = new Frm_PopUpMenu();

            frm_PopUpMenu.ShowDialog();

            this.Hide();
        }

        private void btn_Proximo_Click(object sender, EventArgs e)
        {

        }
    }
}
