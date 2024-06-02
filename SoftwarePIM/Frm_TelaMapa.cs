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
    public partial class Frm_TelaMapa : Form
    {

        public Form? FormAnterior { get; set; }
        public Form? FormPrincipal { get; set; }

        public Frm_TelaMapa()
        {
            InitializeComponent();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_TelaMapa_Load(object sender, EventArgs e)
        {
            this.FormPrincipal?.Hide();
        }

        private void Frm_TelaMapa_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FormPrincipal?.Show();
        }
    }
}
