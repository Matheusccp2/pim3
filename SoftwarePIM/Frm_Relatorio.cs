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
    public partial class Frm_Relatorio : Form
    {
        public Form? FormAnterior { get; set; }
        public Form? FormAnterior2 { get; set; }
        public Form? FormPrincipal { get; set; }

        public Frm_Relatorio()
        {
            InitializeComponent();
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
    }
}
