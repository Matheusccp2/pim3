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
            Frm_TelaInicial frm_TelaInicial = new Frm_TelaInicial();

            frm_TelaInicial.Show();

            this.Hide();
        }
    }
}
