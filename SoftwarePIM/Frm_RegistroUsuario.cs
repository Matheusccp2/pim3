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

        Frm_TecladoVirtual frm_TecladoVirtual = new Frm_TecladoVirtual();

        public Frm_RegistroUsuario()
        {
            InitializeComponent();

            Frm_TecladoVirtual frm_TecladoVirtual = new Frm_TecladoVirtual();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            var frm_TelaPerguntas = new Frm_TelaPerguntas();
            frm_TelaPerguntas.FormAnterior = this;
            frm_TelaPerguntas.FormPrincipal = this.FormPrincipal;
            frm_TelaPerguntas.Show();
            frm_TelaPerguntas.BringToFront();
        }

        private void btn_VoltarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txb_NomeUsuario_Enter(object sender, EventArgs e)
        {
            frm_TecladoVirtual.Show();
            frm_TecladoVirtual.BringToFront();

        }

        private void Frm_RegistroUsuario_Load(object sender, EventArgs e)
        {
            this.FormPrincipal?.Hide();
        }

        private void txb_NomeUsuario_Leave(object sender, EventArgs e)
        {
            frm_TecladoVirtual.Hide();
        }

        private void Frm_RegistroUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.FormPrincipal?.Show();
            frm_TecladoVirtual.Close();
        }

        private void txb_IdadeUsuario_Enter(object sender, EventArgs e)
        {
            frm_TecladoVirtual.Show();
            frm_TecladoVirtual.BringToFront();
        }

        private void txb_IdadeUsuario_Leave(object sender, EventArgs e)
        {
            frm_TecladoVirtual.Hide();
        }
    }
}
