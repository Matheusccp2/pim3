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
    public partial class Frm_RegistroUsuario : Form
    {
        public Frm_RegistroUsuario()
        {
            InitializeComponent();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            Frm_Relatorio frm_Relatorio = new Frm_Relatorio();

            frm_Relatorio.ShowDialog();

            this.Hide();
        }
    }
}
