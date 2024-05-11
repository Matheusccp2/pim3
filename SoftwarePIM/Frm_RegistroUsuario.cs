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
        public Form? FormAnterior { get; set; }
        public Form? FormPrincipal { get; set; }
        public Form? FormAnterior2 { get; set; }

        public Frm_RegistroUsuario()
        {
            InitializeComponent();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            var frm_Relatorio = new Frm_Relatorio();
            frm_Relatorio.FormAnterior = this;
            frm_Relatorio.FormPrincipal = this.FormPrincipal;
            frm_Relatorio.Show();
            frm_Relatorio.BringToFront();


            //Frm_Relatorio frm_Relatorio = new Frm_Relatorio();

            //frm_Relatorio.ShowDialog();

            //this.Hide();
        }

        private void txb_NomeUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
