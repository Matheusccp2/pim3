using SoftwarePIM.Back_end;
using SoftwarePIM.Back_End;
using SoftwarePIM.Modelo;
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
    public partial class Frm_TelaPerguntas : Form

    {
        private int alternativa;
        private int numero_pergunta;
        public Form? FormAnterior { get; set; }
        public Form? FormPrincipal { get; set; }

        public Frm_TelaPerguntas()
        {
            InitializeComponent();
            Esconder();
            
        }
        private void btn_VoltarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int muito_ruim;
        private int ruim;
        private int regular;
        private int bom;
        private int muito_bom;
        private int painelAtual = 1; // Variável para rastrear qual painel está atualmente visível

        private void Esconder() {
            
            pcb_foguetinho1Pg1.Hide();
            pcb_foguetinho2Pg1.Hide();
            pcb_foguetinho3Pg1.Hide();
            pcb_foguetinho4Pg1.Hide();
            pcb_foguetinho5Pg1.Hide();
            pcb_foguetinho1Pg2.Hide();
            pcb_foguetinho2Pg2.Hide();
            pcb_foguetinho3Pg2.Hide();
            pcb_foguetinho4Pg2.Hide();
            pcb_foguetinho5Pg2.Hide();
            pcb_foguetinho1Pg3.Hide();
            pcb_foguetinho2Pg3.Hide();
            pcb_foguetinho3Pg3.Hide();
            pcb_foguetinho4Pg3.Hide();
            pcb_foguetinho5Pg3.Hide();
            pcb_foguetinho1Pg4.Hide();
            pcb_foguetinho2Pg4.Hide();
            pcb_foguetinho3Pg4.Hide();
            pcb_foguetinho4Pg4.Hide();
            pcb_foguetinho5Pg4.Hide();
            pcb_foguetinho1Pg5.Hide();
            pcb_foguetinho2Pg5.Hide();
            pcb_foguetinho3Pg5.Hide();
            pcb_foguetinho4Pg5.Hide();
            pcb_foguetinho5Pg5.Hide();

        }
        private void mandar()

        {
            Controle controle = new Controle(muito_ruim,ruim,regular,bom,muito_bom,numero_pergunta);
            Estaticos.NUMERO_PESSOAS++;
        }
        private void btn_ProximaPergunta_Click(object sender, EventArgs e)

        {
            if (alternativa == 1) muito_ruim++;
            if (alternativa == 2) ruim++;
            if (alternativa == 3) regular++;
            if (alternativa == 4) bom++;
            if (alternativa == 5) muito_bom++;
            if (numero_pergunta == 5) mandar();
            


                // Esconde o painel atual
                switch (painelAtual)
                {
                    case 1:
                        panel1.Visible = false;
                        // this.numero_pergunta = 0;
                        break;
                    case 2:
                        panel2.Visible = false;
                        // this.numero_pergunta = 0;
                        break;
                    case 3:
                        panel3.Visible = false;
                        // this.numero_pergunta = 0;
                        break;
                    case 4:
                        panel4.Visible = false;
                        // this.numero_pergunta = 0;
                        break;
                    case 5:
                        panel5.Visible = false;
                        // this.numero_pergunta = 0;
                        break;
                }

            if (alternativa != 0 )
            {
                painelAtual++;
            }
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
            alternativa = 0;
            

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

        private void pcb_BomPg1_Click(object sender, EventArgs e)
        {

            Esconder();
            pcb_foguetinho4Pg1.Show();
                this.alternativa = 4;
                this.numero_pergunta = 1;
           
        }

        private void pcb_BomPg2_Click(object sender, EventArgs e)
        {
            Esconder();
            pcb_foguetinho4Pg2.Show();
            this.alternativa = 4;
            this.numero_pergunta = 2;
        }

        private void pcb_BomPg3_Click(object sender, EventArgs e)
        {
            Esconder();
            pcb_foguetinho4Pg3.Show();
            this.alternativa = 4;
            this.numero_pergunta = 3;
        }

        private void pcb_BomPg4_Click(object sender, EventArgs e)
        {
            Esconder();
            pcb_foguetinho4Pg4.Show();
            this.alternativa = 4;
            this.numero_pergunta = 4;
        }

        private void pcb_BomPg5_Click(object sender, EventArgs e)
        {
            Esconder();
            pcb_foguetinho4Pg5.Show();
            this.alternativa = 4;
            this.numero_pergunta = 5;
        }

        private void pcb_MuitoBomPg1_Click(object sender, EventArgs e)
        {
            Esconder();
            pcb_foguetinho5Pg1.Show();
            this.alternativa = 5;
            this.numero_pergunta = 1;
        }

        private void pcb_MuitoBomPg2_Click(object sender, EventArgs e)
        {
            Esconder();
            pcb_foguetinho5Pg2.Show();
            this.alternativa = 5;
            this.numero_pergunta = 2;
        }

        private void pcb_MuitoBomPg3_Click(object sender, EventArgs e)
        {
            Esconder();
            pcb_foguetinho5Pg3.Show();
            this.alternativa = 5;
            this.numero_pergunta = 3;
        }

        private void pcb_MuitoBomPg4_Click(object sender, EventArgs e)
        {
            Esconder();
            pcb_foguetinho5Pg4.Show();
            this.alternativa = 5;
            this.numero_pergunta = 4;
        }

        private void pcb_MuitoBomPg5_Click(object sender, EventArgs e)
        {
            Esconder();
            pcb_foguetinho5Pg5.Show();
            this.alternativa = 5;
            this.numero_pergunta = 5;
        }

        private void pcb_MuitoRuimPg1_Click(object sender, EventArgs e)
        {
            Esconder();
            pcb_foguetinho1Pg1.Show();
            this.alternativa = 1;
            this.numero_pergunta = 1;
        }

        private void pcb_MuitoRuimPg2_Click(object sender, EventArgs e)
        {
            Esconder();
            pcb_foguetinho1Pg2.Show();
            this.alternativa = 1;
            this.numero_pergunta = 2;
        }

        private void pcb_MuitoRuimPg3_Click(object sender, EventArgs e)
        {
            Esconder();
            pcb_foguetinho1Pg3.Show();
            this.alternativa = 1;
            this.numero_pergunta = 3;
        }

        private void pcb_MuitoRuimPg4_Click(object sender, EventArgs e)
        {
            Esconder();
            pcb_foguetinho1Pg4.Show();
            this.alternativa = 1;
            this.numero_pergunta = 4;
        }

        private void pcb_MuitoRuimPg5_Click(object sender, EventArgs e)
        {
            Esconder();
            pcb_foguetinho1Pg5.Show();
            this.alternativa = 1;
            this.numero_pergunta = 5;
        }

        private void pcb_RegularPg1_Click(object sender, EventArgs e)
        {
            Esconder();
            pcb_foguetinho3Pg1.Show();
            this.alternativa = 3;
            this.numero_pergunta = 1;
        }

        private void pcb_RegularPg2_Click(object sender, EventArgs e)
        {
            Esconder();
            pcb_foguetinho3Pg2.Show();
            this.alternativa = 3;
            this.numero_pergunta = 2;
        }

        private void pcb_RegularPg3_Click(object sender, EventArgs e)
        {
            Esconder();
            pcb_foguetinho3Pg3.Show();
            this.alternativa = 3;
            this.numero_pergunta = 3;
        }

        private void pcb_RegularPg4_Click(object sender, EventArgs e)
        {
            Esconder();
            pcb_foguetinho3Pg4.Show();
            this.alternativa = 3;
            this.numero_pergunta = 4;
        }

        private void pcb_RegularPg5_Click(object sender, EventArgs e)
        {
            Esconder();
            pcb_foguetinho3Pg5.Show();
            this.alternativa = 3;
            this.numero_pergunta = 5;
        }

        private void pcb_RuimPg1_Click(object sender, EventArgs e)
        {
            Esconder();
            pcb_foguetinho2Pg1.Show();
            this.alternativa = 2;
            this.numero_pergunta = 1;
        }

        private void pcb_RuimPg2_Click(object sender, EventArgs e)
        {
            Esconder();
            pcb_foguetinho2Pg2.Show();
            this.alternativa = 2;
            this.numero_pergunta = 2;
        }

        private void pcb_RuimPg3_Click(object sender, EventArgs e)
        {
            Esconder();
            pcb_foguetinho2Pg3.Show();
            this.alternativa = 2;
            this.numero_pergunta = 3;
        }

        private void pcb_RuimPg4_Click(object sender, EventArgs e)
        {
            Esconder();
            pcb_foguetinho2Pg4.Show();
            this.alternativa = 2;
            this.numero_pergunta = 4;
        }

        private void pcb_RuimPg5_Click(object sender, EventArgs e)
        {
            Esconder();
            pcb_foguetinho2Pg5.Show();
            this.alternativa = 2;
            this.numero_pergunta = 5;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
