<<<<<<< Updated upstream
﻿using SoftwarePIM.Back_end;
using SoftwarePIM.Back_End;
=======
﻿using SoftwarePIM.Back_End;
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            Controle controle = new Controle();
            label1.Text = controle.Numero_pergunta.ToString();

=======
            Relatorio relatorio = new Relatorio();
            lbl_QtdMuitoRuim.Text = relatorio.ToString(relatorio.Total_muitoruim);//revisar Classe relatorio()
>>>>>>> Stashed changes
        }

        

<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
        private void label1_Click(object sender, EventArgs e)
        {

        }
=======

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_QtdMuitoRuim_Click(object sender, EventArgs e)
        {

        }

        private void lbl_QtdRuim_Click(object sender, EventArgs e)
        {
            
            
                }
>>>>>>> Stashed changes
    }
}
