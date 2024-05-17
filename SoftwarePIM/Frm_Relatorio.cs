using SoftwarePIM.Back_end;
using SoftwarePIM.Back_End;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwarePIM
{
    public partial class Frm_Relatorio : Form

    {


        public Form? FormAnterior { get; set; }
        public Form? FormAnterior2 { get; set; }
        public Form? FormPrincipal { get; set; }

        public Frm_Relatorio()
        {
            InitializeComponent();

            lbl_QtdMuitoRuim.Text = Relatorio.total_muitoruim.ToString();
            lbl_QtdRuim.Text = Relatorio.total_ruim.ToString();
            lbl_QtdRegular.Text = Relatorio.total_regular.ToString();
            lbl_QtdBom.Text = Relatorio.total_bom.ToString();
            lbl_QtdMuitoBom.Text = Relatorio.total_muitobom.ToString();
            lbl_MediaAvaliacao.Text = Relatorio.media_avaliacao + "%" + " " + Relatorio.maior_reposta;
            label1.Text = Relatorio.total_muitoruim.ToString();

        }




        private void Frm_Relatorio_Load(object sender, EventArgs e)
        {
            FormAnterior?.Close();
            FormAnterior2?.Close();
            this.FormPrincipal?.Hide();
        }


        private void Frm_Relatorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FormPrincipal?.Show();
        }



        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.FormPrincipal?.Show();
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_QtdMuitoRuim_Click(object sender, EventArgs e)
        {

        }

        private void lbl_QtdRuim_Click(object sender, EventArgs e)
        {


        }

        private void lbl_MediaAvaliacao_Click(object sender, EventArgs e)
        {

        }
    }
}
