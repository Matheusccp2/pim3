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
            var frm_TelaPerguntas = new Frm_TelaPerguntas();
            frm_TelaPerguntas.FormAnterior = this;
            frm_TelaPerguntas.FormPrincipal = this.FormPrincipal;
            frm_TelaPerguntas.Show();
            frm_TelaPerguntas.BringToFront();


            //Frm_Relatorio frm_Relatorio = new Frm_Relatorio();

            //frm_Relatorio.ShowDialog();

            //this.Hide();
        }

        private void btn_VoltarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
