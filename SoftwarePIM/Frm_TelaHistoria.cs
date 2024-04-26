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
        public Frm_TelaHistoria()
        {
            InitializeComponent();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        public Form? FormAnterior { get; set; }
        public Form? FormPrincipal { get; set; }
    }
}
