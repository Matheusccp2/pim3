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

            lbl_QtdMuitoRuim.Text = Estaticos.TOTAL_MUITORUIM.ToString();
            lbl_QtdRuim.Text = Estaticos.TOTAL_RUIM.ToString();
            lbl_QtdRegular.Text = Estaticos.TOTAL_REGULAR.ToString();
            lbl_QtdBom.Text = Estaticos.TOTAL_BOM.ToString();
            lbl_QtdMuitoBom.Text = Estaticos.TOTAL_BOM.ToString();
            lbl_MediaAvaliacao.Text = Estaticos.MAIOR_REPOSTA;
            lbl_Qtd60.Text = Estaticos.TOTAL_MAIS60.ToString();
            lbl_Qtd18Menos.Text = Estaticos.TOTAL_MENOS18.ToString();
            lbl_Qtd18a60.Text = Estaticos.TOTAL_ENTRE18E60.ToString();
            lbl_MediaEtaria.Text = Estaticos.MEDIA_IDADE.ToString();          
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
