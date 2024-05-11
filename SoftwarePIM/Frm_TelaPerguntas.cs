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
    public partial class Frm_TelaPerguntas : Form

    {
<<<<<<< Updated upstream
        private int alternativa;
        private int numero_pergunta;
=======
        private char alternativa;
        private int pergunta;
>>>>>>> Stashed changes
        public Form? FormAnterior { get; set; }
        public Form? FormPrincipal { get; set; }

        public Frm_TelaPerguntas()
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
            Controle controle = new Controle(this.alternativa,this.pergunta);




            // Esconde o painel atual
            switch (painelAtual)
            {
                case 1:
                    panel1.Visible = false;
<<<<<<< Updated upstream
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
=======
                    this.pergunta = 0;
                    break;
                case 2:
                    panel2.Visible = false;
                    this.pergunta = 0;
                    break;
                case 3:
                    panel3.Visible = false;
                    this.pergunta = 0;
                    break;
                case 4:
                    panel4.Visible = false;
                    this.pergunta = 0;
                    break;
                case 5:
                    panel5.Visible = false;
                    this.pergunta = 0;
>>>>>>> Stashed changes
                    break;

            }

            // Passa para o próximo painel
            painelAtual++;
            //if (painelAtual > 6)
            //    painelAtual = 1;

            if (painelAtual > 5)
            {
                numero_pergunta = 6;
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
<<<<<<< Updated upstream

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

=======
                        this.pergunta = 1;
                        break;
                    case 2:
                        panel2.Visible = true;
                        this.pergunta = 2;
                        break;
                    case 3:
                        panel3.Visible = true;
                        this.pergunta = 3;
                        break;
                    case 4:
                        panel4.Visible = true;
                        this.pergunta = 4;
                        break;
                    case 5:
                        panel5.Visible = true;
                        this.pergunta = 5;
>>>>>>> Stashed changes
                        break;
                }
            }

            Controle controle = new Controle(alternativa, numero_pergunta);
            label1.Text = controle.Numero_pergunta.ToString();

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
            rbt_BomPg1.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 4;
            this.numero_pergunta = 1;
=======
            this.alternativa = '4';
>>>>>>> Stashed changes
        }

        private void pcb_BomPg2_Click(object sender, EventArgs e)
        {
            rbt_BomPg2.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 4;
            this.numero_pergunta = 2;
=======
            this.alternativa = '4';
>>>>>>> Stashed changes
        }

        private void pcb_BomPg3_Click(object sender, EventArgs e)
        {
            rbt_BomPg3.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 4;
            this.numero_pergunta = 3;
=======
            this.alternativa = '4';
>>>>>>> Stashed changes
        }

        private void pcb_BomPg4_Click(object sender, EventArgs e)
        {
            rbt_BomPg4.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 4;
            this.numero_pergunta = 4;
=======
            this.alternativa = '4';
>>>>>>> Stashed changes
        }

        private void pcb_BomPg5_Click(object sender, EventArgs e)
        {
            rbt_BomPg5.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 4;
            this.numero_pergunta = 5;
=======
            this.alternativa = '4';
>>>>>>> Stashed changes
        }

        private void pcb_MuitoBomPg1_Click(object sender, EventArgs e)
        {
            rbt_MuitoBomPg1.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 5;
            this.numero_pergunta = 1;
=======
            this.alternativa = '4';
>>>>>>> Stashed changes
        }

        private void pcb_MuitoBomPg2_Click(object sender, EventArgs e)
        {
            rbt_MuitoBomPg2.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 5;
            this.numero_pergunta = 2;
=======
            this.alternativa = '5';
>>>>>>> Stashed changes
        }

        private void pcb_MuitoBomPg3_Click(object sender, EventArgs e)
        {
            rbt_MuitoBomPg3.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 5;
            this.numero_pergunta = 3;
=======
            this.alternativa = '5';
>>>>>>> Stashed changes
        }

        private void pcb_MuitoBomPg4_Click(object sender, EventArgs e)
        {
            rbt_MuitoBomPg4.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 5;
            this.numero_pergunta = 4;
=======
            this.alternativa = '5';
>>>>>>> Stashed changes
        }

        private void pcb_MuitoBomPg5_Click(object sender, EventArgs e)
        {
            rbt_MuitoBomPg5.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 5;
            this.numero_pergunta = 5;
=======
            this.alternativa = '5';
>>>>>>> Stashed changes
        }

        private void pcb_MuitoRuimPg1_Click(object sender, EventArgs e)
        {
            rbt_MuitoRuimPg1.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 1;
            this.numero_pergunta = 1;
=======
            this.alternativa = '1';
>>>>>>> Stashed changes
        }

        private void pcb_MuitoRuimPg2_Click(object sender, EventArgs e)
        {
            rbt_MuitoRuimPg2.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 1;
            this.numero_pergunta = 2;
=======
            this.alternativa = '1';

>>>>>>> Stashed changes
        }

        private void pcb_MuitoRuimPg3_Click(object sender, EventArgs e)
        {
            rbt_MuitoRuimPg3.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 1;
            this.numero_pergunta = 3;
=======
            this.alternativa = '1';
>>>>>>> Stashed changes
        }

        private void pcb_MuitoRuimPg4_Click(object sender, EventArgs e)
        {
            rbt_MuitoRuimPg4.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 1;
            this.numero_pergunta = 4;
=======
            this.alternativa = '1';
>>>>>>> Stashed changes
        }

        private void pcb_MuitoRuimPg5_Click(object sender, EventArgs e)
        {
            rbt_MuitoRuimPg5.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 1;
            this.numero_pergunta = 5;
=======
            this.alternativa = '1';
>>>>>>> Stashed changes
        }

        private void pcb_RegularPg1_Click(object sender, EventArgs e)
        {
            rbt_RegularPg1.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 3;
            this.numero_pergunta = 1;
=======
            this.alternativa = '3';
>>>>>>> Stashed changes
        }

        private void pcb_RegularPg2_Click(object sender, EventArgs e)
        {
            rbt_RegularPg2.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 3;
            this.numero_pergunta = 2;
=======
            this.alternativa = '3';
>>>>>>> Stashed changes
        }

        private void pcb_RegularPg3_Click(object sender, EventArgs e)
        {
            rbt_RegularPg3.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 3;
            this.numero_pergunta = 3;
=======
            this.alternativa = '3';
>>>>>>> Stashed changes
        }

        private void pcb_RegularPg4_Click(object sender, EventArgs e)
        {
            rbt_RegularPg4.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 3;
            this.numero_pergunta = 4;
=======
            this.alternativa = '3';
>>>>>>> Stashed changes
        }

        private void pcb_RegularPg5_Click(object sender, EventArgs e)
        {
            rbt_RegularPg5.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 3;
            this.numero_pergunta = 5;
=======
            this.alternativa = '3';
>>>>>>> Stashed changes
        }

        private void pcb_RuimPg1_Click(object sender, EventArgs e)
        {
            rbt_RuimPg1.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 2;
            this.numero_pergunta = 1;
=======
            this.alternativa = '2';
>>>>>>> Stashed changes
        }

        private void pcb_RuimPg2_Click(object sender, EventArgs e)
        {
            rbt_RuimPg2.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 2;
            this.numero_pergunta = 2;
=======
            this.alternativa = '2';
>>>>>>> Stashed changes
        }

        private void pcb_RuimPg3_Click(object sender, EventArgs e)
        {
            rbt_RuimPg3.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 2;
            this.numero_pergunta = 3;
=======
            this.alternativa = '2';
>>>>>>> Stashed changes
        }

        private void pcb_RuimPg4_Click(object sender, EventArgs e)
        {
            rbt_RuimPg4.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 2;
            this.numero_pergunta = 4;
=======
            this.alternativa = '2';
>>>>>>> Stashed changes
        }

        private void pcb_RuimPg5_Click(object sender, EventArgs e)
        {
            rbt_RuimPg5.Checked = true;
<<<<<<< Updated upstream
            this.alternativa = 2;
            this.numero_pergunta = 5;
        }

        private void label1_Click(object sender, EventArgs e)
        {

=======
            this.alternativa = '2';
>>>>>>> Stashed changes
        }
    }
}
