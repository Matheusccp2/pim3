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
            Controle controle = new Controle();
            label1.Text = controle.Numero_pergunta.ToString();

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
