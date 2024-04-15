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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Criando uma instância da Tela do Mapa
            Frm_TelaInicial frm_TelaInicial = new Frm_TelaInicial();

            // Exibindo o FormSecundario
            frm_TelaInicial.Show();

            // Fechar a Tela Inicial
            this.Hide();
        }
    }
}
