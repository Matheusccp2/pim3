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
        public Form? FormAnterior { get; set; }
        public Form? FormAnterior2 { get; set; }
        public Form? FormPrincipal { get; set; }
        public Form? FormPrincipal2 { get; set; }

        public Frm_TelaSugestao()
        {
            InitializeComponent();
        }

        private void btn_VoltarMenu_Click(object sender, EventArgs e)
        {
            Frm_PopUpMenu frm_PopUpMenu = new Frm_PopUpMenu();

            frm_PopUpMenu.ShowDialog();

            this.Close();
            this.FormPrincipal?.Show();
        }

        private void btn_Proximo_Click(object sender, EventArgs e)
        {
            var frm_RegistroUsuario = new Frm_RegistroUsuario();
            frm_RegistroUsuario.FormAnterior = this;
            frm_RegistroUsuario.FormAnterior2 = this;
            frm_RegistroUsuario.FormPrincipal = this.FormPrincipal;
            frm_RegistroUsuario.ShowDialog();
            frm_RegistroUsuario.BringToFront();
            this.Close();

            //Frm_RegistroUsuario frm_RegistroUsuario = new Frm_RegistroUsuario();

            //frm_RegistroUsuario.ShowDialog();

            //this.Hide();
        }

        private void Frm_TelaSugestao_Load(object sender, EventArgs e)
        {
            this.FormPrincipal2?.Hide();
            this.FormPrincipal?.Hide();
        }
    }
}
