using SoftwarePIM.Back_end;
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
        private char alternativa; //varial que vai receber a alternativa escolhida pelo visitante
        private char numero_pergunta; //variavel que vai receber o numero da pergunta

        public Form? FormAnterior { get; set; }
        public Form? FormPrincipal { get; set; }

        public Frm_Pergunta1()
        {
            InitializeComponent();
        }

        private void gerar_relatorio(char alternativa)

        {

            Controle controle = new Controle(alternativa);

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
                        numero_pergunta = '1';
                        break;
                    case 2:
                        panel2.Visible = true;
                        numero_pergunta = '2';
                        break;
                    case 3:
                        panel3.Visible = true;
                        numero_pergunta = '3';
                        break;
                    case 4:
                        panel4.Visible = true;
                        numero_pergunta = '4';
                        break;
                    case 5:
                        panel5.Visible = true;
                        numero_pergunta = '5';
                        break;
                }
            }

            //vai acionar o programa para gerar o relatorio
            gerar_relatorio(this.alternativa);

        }

        private void AbrirNovoFormulario()
        {
            // Crie uma instância do novo formulário
            Frm_TelaSugestao frm_TelaSugestao = new Frm_TelaSugestao();
            // Defina o formulário atual como o formulário anterior no novo formulário
            frm_TelaSugestao.FormAnterior = this;
            // Defina o formulário atual como o formulário principal no novo formulário
            frm_TelaSugestao.FormPrincipal2 = this;
            // Defina o formulário principal no novo formulário
            frm_TelaSugestao.FormPrincipal = this.FormPrincipal;
            // Exiba o novo formulário
            frm_TelaSugestao.Show();
            // Traga o novo formulário para a frente
            frm_TelaSugestao.BringToFront();
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

        private void pictureBox40_Click(object sender, EventArgs e)
        {

        }

        private void rbt_MuitoRuimPg5_CheckedChanged(object sender, EventArgs e)
        {
            this.alternativa = '1';
        }

        private void rbt_RuimPg5_CheckedChanged(object sender, EventArgs e)
        {
            this.alternativa = '2';
        }

        private void rbt_RegularPg5_CheckedChanged(object sender, EventArgs e)
        {
            this.alternativa = '3';
        }

        private void rbt_BomPg5_CheckedChanged(object sender, EventArgs e)
        {
            this.alternativa = '4';
        }

        private void rbt_MuitoBomPg5_CheckedChanged(object sender, EventArgs e)
        {
            this.alternativa = '5';
        }
    }
}
