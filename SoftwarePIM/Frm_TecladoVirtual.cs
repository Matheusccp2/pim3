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
    public partial class Frm_TecladoVirtual : Form
    {
        private string frase = "";
        private bool maiusculo = false;

        public Frm_TecladoVirtual()
        {
            InitializeComponent();
        }

        private void Frm_TecladoVirtual_Load(object sender, EventArgs e)
        {
            // Obtém a resolução da tela
            Screen screen = Screen.PrimaryScreen;
            Rectangle area = screen.WorkingArea;

            // Calcula a posição central na parte inferior da tela
            int x = (area.Width - this.Width) / 2;
            int y = area.Height - this.Height;

            // Define a posição do formulário
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(x, y);
        }

        public void Teclado(String dig)
        {
            if (!dig.Equals("BackSpace") && !dig.Equals("Enter"))
            {
                if (maiusculo == false)
                {
                    dig = dig.ToLower();
                }
                txbTeste.Text = frase += dig;
            }
            else if (dig.Equals("BackSpace"))
            {
                if (!string.IsNullOrEmpty(frase))
                {
                    frase = frase.Remove(frase.Length - 1);
                    txbTeste.Text = frase;
                }
            }
            //else if (dig.Equals("Enter")) mandar o parametro para o controle
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            this.Teclado("A");
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            this.Teclado("B");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.Teclado("C");
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            this.Teclado("D");
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            this.Teclado("E");
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            this.Teclado("F");
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            this.Teclado("G");
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            this.Teclado("H");
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            this.Teclado("I");
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            this.Teclado("J");
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            this.Teclado("K");
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            this.Teclado("L");
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            this.Teclado("M");
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            this.Teclado("N");
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            this.Teclado("O");
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            this.Teclado("P");
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            this.Teclado("Q");
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            this.Teclado("R");
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            this.Teclado("S");
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            this.Teclado("T");
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            this.Teclado("U");
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            this.Teclado("V");
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Teclado("X");
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            this.Teclado("W");
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            this.Teclado("Y");
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            this.Teclado("Z");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.Teclado("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Teclado("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Teclado("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.Teclado("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.Teclado("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.Teclado("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.Teclado("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.Teclado("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.Teclado("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.Teclado("9");
        }

        private void btnEspaco_Click(object sender, EventArgs e)
        {
            this.Teclado(" ");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.Teclado("Enter");
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Teclado("BackSpace");
        }

        private void btnCaps_Click(object sender, EventArgs e)
        {
            if (this.maiusculo == false)
            {
                this.maiusculo = true;
            }
            else
            {
                this.maiusculo = false;
            }
        }

        private void btnTab_Click(object sender, EventArgs e)
        {

        }
    }
}
