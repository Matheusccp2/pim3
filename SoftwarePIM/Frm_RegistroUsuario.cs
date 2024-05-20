using SoftwarePIM.Back_end;
using SoftwarePIM.Back_End;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SoftwarePIM
{
    public partial class Frm_RegistroUsuario : Form
    {
        private bool maiusculo = false;
        private string frase = "";
        private string frase_idade = "";
        private string campo;
        private bool enter = false;

        public Frm_RegistroUsuario()
        {
            InitializeComponent();
            this.pnlTeclado_Nome.Hide();
            this.pnlTeclado_idade.Hide();
        }

        private void Validar(string nome, string idade)
        {

            Controle controle = new Controle(nome, idade);
            if (controle.mensagem.Equals("ok"))
            {
                var frm_TelaPerguntas = new Frm_TelaPerguntas();
                frm_TelaPerguntas.FormAnterior = this;
                frm_TelaPerguntas.FormPrincipal = this.FormPrincipal;
                frm_TelaPerguntas.Show();
                frm_TelaPerguntas.BringToFront();
            }
            else
            {
                lbl_validacao.Text = controle.mensagem;
            }

        }
        private void Teclado(string dig)

        {
            if (dig == "Enter" && this.enter == false) { this.enter = true; dig = ""; }

            if (!dig.Equals("Backspace") && this.enter == false)

            {
                if (maiusculo == false)
                {
                    dig = dig.ToLower();
                }

                txb_NomeUsuario.Text = frase += dig;
            }

            else if (dig.Equals("Backspace") && this.enter == false)
            {
                if (!string.IsNullOrEmpty(frase))
                {
                    frase = frase.Remove(frase.Length - 1);

                    txb_NomeUsuario.Text = frase;
                }
            }
            else if (dig.Equals("Backspace") && this.enter == true)
            {


                if (!string.IsNullOrEmpty(frase_idade))
                {
                    frase_idade = frase_idade.Remove(frase_idade.Length - 1);

                    txb_IdadeUsuario.Text = frase_idade;
                }
            }

            else if (this.enter == true)
            {
                
                if (!dig.Equals("Enter") && this.frase_idade.Count() < 3) txb_IdadeUsuario.Text = frase_idade += dig;
            }

        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            Validar(frase, frase_idade);
        }

        private void btn_VoltarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_RegistroUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.FormPrincipal?.Show();
        }


        private void btnCapslock_Click(object sender, EventArgs e)
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

        #region teclado

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            this.Teclado("Backspace");
        }

        private void btnBackspace_Idade_Click(object sender, EventArgs e)
        {
            this.Teclado("Backspace");
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

        private void btn0_Click(object sender, EventArgs e)
        {
            this.Teclado("0");
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            this.Teclado("Q");
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            this.Teclado("W");
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            this.Teclado("E");
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            this.Teclado("R");
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            this.Teclado("T");
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            this.Teclado("Y");
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            this.Teclado("U");
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            this.Teclado("I");
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            this.Teclado("O");
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            this.Teclado("P");
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            this.Teclado("A");
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            this.Teclado("S");
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            this.Teclado("D");
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

        private void btnZ_Click(object sender, EventArgs e)
        {
            this.Teclado("Z");
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Teclado("X");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.Teclado("C");
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            this.Teclado("V");
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            this.Teclado("B");
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            this.Teclado("N");
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            this.Teclado("M");
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            this.Teclado(" ");
        }

        #endregion
        private void txb_NomeUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_IdadeUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_validacao_Click(object sender, EventArgs e)
        {

        }

        private void txb_NomeUsuario_Enter(object sender, EventArgs e)
        {
            this.pnlTeclado_Nome.Show();
            this.pnlTeclado_idade.Hide();
            this.enter = false;

        }

        private void txb_NomeUsuario_Leave(object sender, EventArgs e)
        {
            
        }

        private void txb_IdadeUsuario_Enter(object sender, EventArgs e)
        {
            this.pnlTeclado_idade.Show();
            this.pnlTeclado_Nome.Hide();
            this.enter = true;

        }

        private void txb_IdadeUsuario_Leave(object sender, EventArgs e)
        {
            
        }

        public Form? FormAnterior { get; set; }
        public Form? FormPrincipal { get; set; }
        public Form? FormAnterior2 { get; set; }
    }
}
