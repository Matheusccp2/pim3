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
    public partial class Frm_Pergunta1 : Form
    {
        public Frm_Pergunta1()
        {
            InitializeComponent();
        }

        private void btn_VoltarMenu_Click(object sender, EventArgs e)
        {
            Frm_PopUpMenu frm_PopUpMenu = new Frm_PopUpMenu();

            frm_PopUpMenu.ShowDialog();

            this.Hide();
        }

        private void btn_ProximaPergunta_Click(object sender, EventArgs e)
        {
            Frm_TelaSugestao frm_TelaSugestao = new Frm_TelaSugestao();

            frm_TelaSugestao.Show();

            this.Hide();
        }
    }
}
