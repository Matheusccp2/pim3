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
            lbl_MediaAvaliacao.Text = Relatorio.maior_reposta;
            lbl_Qtd60.Text = Relatorio.total_mais60.ToString();
            lbl_Qtd18Menos.Text = Relatorio.total_menos18.ToString();
            lbl_Qtd18a60.Text = Relatorio.total_entre18e60.ToString();
            lbl_MediaEtaria.Text = Relatorio.media_idade.ToString();
            lbl_Total_Pessoas.Text = Relatorio.numero_pessoas.ToString();
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

        private void lbl_QtdBom_Click(object sender, EventArgs e)
        {

        }
    }
}
