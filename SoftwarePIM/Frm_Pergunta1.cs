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

        private int painelAtual = 1; // Variável para rastrear qual painel está atualmente visível

        private void btn_ProximaPergunta_Click(object sender, EventArgs e)
        {

            // Esconde o painel atual
            switch (painelAtual)
            {
                case 1:
                    panel1.Visible = false;
                    break;
                case 2:
                    panel2.Visible = false;
                    break;
                case 3:
                    panel3.Visible = false;
                    break;
                case 4:
                    panel4.Visible = false;
                    break;
                case 5:
                    panel5.Visible = false;
                    break;

            }

            // Passa para o próximo painel
            painelAtual++;
            //if (painelAtual > 6)
            //    painelAtual = 1;

            if (painelAtual > 5)
            {
                painelAtual = 1;
                // Abre um novo formulário
                AbrirNovoFormulario();
            }
            else
            {

                // Exibe o próximo painel
                switch (painelAtual)
                {
                    case 1:
                        panel1.Visible = true;
                        break;
                    case 2:
                        panel2.Visible = true;
                        break;
                    case 3:
                        panel3.Visible = true;
                        break;
                    case 4:
                        panel4.Visible = true;
                        break;
                    case 5:
                        panel5.Visible = true;
                        break;
                }
            }

        }

        private void AbrirNovoFormulario()
        {
            var frm_Relatorio = new Frm_Relatorio();
            frm_Relatorio.FormAnterior = this;
            frm_Relatorio.FormPrincipal = this.FormPrincipal;
            frm_Relatorio.Show();
            frm_Relatorio.BringToFront();
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
