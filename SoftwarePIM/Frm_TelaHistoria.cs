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
    public partial class Frm_TelaHistoria : Form
    {
        public Form? FormAnterior { get; set; }
        public Form? FormPrincipal { get; set; }

        // Array de caminhos dos arquivos de imagem no seu PC
        private string[] caminhosDasImagens = {
            @"C:\Users\t_matheus.caetano\Documents\Dev\pim3\SoftwarePIM\Properties\imagens\Obra5.1.jpg",
            @"C:\Users\t_matheus.caetano\Documents\Dev\pim3\SoftwarePIM\Properties\imagens\Obra5.2.jpg",
            @"C:\Users\t_matheus.caetano\Documents\Dev\pim3\SoftwarePIM\Properties\imagens\Obra5.3.jpg"
        };

        private int indiceAtual = 0;

        public Frm_TelaHistoria()
        {
            InitializeComponent();

            // Inicialize o Timer
            timer1.Interval = 3000; // Intervalo em milissegundos (3 segundos neste exemplo)
            timer1.Tick += Timer1_Tick;

            // Exiba a primeira imagem
            pictureBox1.Image = Image.FromFile(caminhosDasImagens[indiceAtual]);

            // Inicie o Timer
            timer1.Start();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Troque para a próxima imagem
            indiceAtual = (indiceAtual + 1) % caminhosDasImagens.Length;
            pictureBox1.Image = Image.FromFile(caminhosDasImagens[indiceAtual]);
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int painelAtual = 1; // Variável para rastrear qual painel está atualmente visível

        //private void btn_Proximo_Click(object sender, EventArgs e)
        //{
        //    Frm_TelaHistoria2 frm_TelaHistoria2 = new Frm_TelaHistoria2();
        //    frm_TelaHistoria2.FormAnterior = this;
        //    frm_TelaHistoria2.FormPrincipal = this.FormPrincipal;
        //    frm_TelaHistoria2.Show();
        //    frm_TelaHistoria2.BringToFront();
        //}

        private void Frm_TelaHistoria_Load(object sender, EventArgs e)
        {
            this.FormPrincipal?.Hide();
        }

        private void Frm_TelaHistoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FormPrincipal?.Show();
        }

        private void btn_Proximo_Click(object sender, EventArgs e)
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
                //case 3:
                //    panel3.Visible = false;
                //    break;
                //case 4:
                //    panel4.Visible = false;
                //    break;
                //case 5:
                //    panel5.Visible = false;
                //    break;

            }

            // Passa para o próximo painel
            painelAtual++;
            if (painelAtual > 2)
                painelAtual = 1;

            // Exibe o próximo painel
            switch (painelAtual)
            {
                case 1:
                    panel1.Visible = true;
                    break;
                case 2:
                    panel2.Visible = true;
                    break;
                //case 3:
                //    panel3.Visible = true;
                //    break;
                //case 4:
                //    panel4.Visible = true;
                //    break;
                //case 5:
                //    panel5.Visible = true;
                //    break;
            }

        }

        private void btn_Anterior_Click(object sender, EventArgs e)
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
                    // Adicione os casos necessários para os painéis adicionais aqui
            }

            // Volta para o painel anterior
            painelAtual--;
            if (painelAtual < 1)
                painelAtual = 2; // Altere para o número total de painéis

            // Exibe o painel anterior
            switch (painelAtual)
            {
                case 1:
                    panel1.Visible = true;
                    break;
                case 2:
                    panel2.Visible = true;
                    break;
                    // Adicione os casos necessários para os painéis adicionais aqui
            }
        }

        
    }
}
