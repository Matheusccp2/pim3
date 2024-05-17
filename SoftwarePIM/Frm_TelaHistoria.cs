using SoftwarePIM.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
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

        private int painelAtual = 1;
        private int indiceAtual = 0;

        public Frm_TelaHistoria()
        {
            InitializeComponent();

            this.pictureBox1.Image = Resources.Obra5_3;
            timer1.Interval = 3000; 
            timer1.Tick += Timer1_Tick;
            timer1.Start();

        }
        private int counter = 1;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            switch (counter % 3)
            {
                case 0:
                    this.pictureBox1.Image = Resources.Obra5_1;
                    break;
                case 1:
                    this.pictureBox1.Image = Resources.Obra5_2;
                    break;
                case 2:
                    this.pictureBox1.Image = Resources.Obra5_3;
                    break;
            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

            painelAtual++;
            if (painelAtual > 5)
                painelAtual = 1;

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

        private void btn_Anterior_Click(object sender, EventArgs e)
        {
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

            painelAtual--;
            if (painelAtual < 1)
                painelAtual = 5; // Altere para o número total de painéis

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
}
