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
        public Form? FormAnterior { get; set; }
        public Form? FormPrincipal { get; set; }

        public Frm_Pergunta1()
        {
            InitializeComponent();
        }

        private void btn_VoltarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ProximaPergunta_Click(object sender, EventArgs e)
        {

            Frm_TelaSugestao frm_TelaSugestao = new Frm_TelaSugestao();
            frm_TelaSugestao.FormAnterior = this;
            frm_TelaSugestao.FormPrincipal2 = this;
            frm_TelaSugestao.FormPrincipal = this.FormPrincipal;
            frm_TelaSugestao.Show();
            frm_TelaSugestao.BringToFront();

            //Frm_TelaSugestao frm_TelaSugestao = new Frm_TelaSugestao();

            //frm_TelaSugestao.Show();

            //this.Hide();
        }

        private void Frm_Pergunta1_Load(object sender, EventArgs e)
        {
            FormAnterior?.Close();
            this.FormPrincipal?.Hide();
        }

        private void Frm_Pergunta1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FormPrincipal?.Show();
        }
    }
}
