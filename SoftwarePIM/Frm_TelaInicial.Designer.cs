﻿namespace SoftwarePIM
{
    partial class Frm_TelaInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TelaInicial));
            btn_Historia = new PictureBox();
            btn_Mapa = new PictureBox();
            btn_Avaliacao = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)btn_Historia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Mapa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Avaliacao).BeginInit();
            SuspendLayout();
            // 
            // btn_Historia
            // 
            btn_Historia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_Historia.BackColor = Color.Transparent;
            btn_Historia.Image = (Image)resources.GetObject("btn_Historia.Image");
            btn_Historia.Location = new Point(766, 348);
            btn_Historia.Margin = new Padding(3, 2, 3, 2);
            btn_Historia.MaximumSize = new Size(389, 118);
            btn_Historia.MinimumSize = new Size(389, 118);
            btn_Historia.Name = "btn_Historia";
            btn_Historia.Size = new Size(389, 118);
            btn_Historia.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Historia.TabIndex = 0;
            btn_Historia.TabStop = false;
            btn_Historia.Click += btn_Historia_Click;
            // 
            // btn_Mapa
            // 
            btn_Mapa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_Mapa.BackColor = Color.Transparent;
            btn_Mapa.Image = (Image)resources.GetObject("btn_Mapa.Image");
            btn_Mapa.Location = new Point(753, 161);
            btn_Mapa.Margin = new Padding(3, 2, 3, 2);
            btn_Mapa.MaximumSize = new Size(411, 123);
            btn_Mapa.MinimumSize = new Size(411, 123);
            btn_Mapa.Name = "btn_Mapa";
            btn_Mapa.Size = new Size(411, 123);
            btn_Mapa.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Mapa.TabIndex = 1;
            btn_Mapa.TabStop = false;
            btn_Mapa.Click += btn_Mapa_Click;
            // 
            // btn_Avaliacao
            // 
            btn_Avaliacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_Avaliacao.BackColor = Color.Transparent;
            btn_Avaliacao.Image = (Image)resources.GetObject("btn_Avaliacao.Image");
            btn_Avaliacao.Location = new Point(703, 517);
            btn_Avaliacao.Margin = new Padding(3, 2, 3, 2);
            btn_Avaliacao.MaximumSize = new Size(498, 170);
            btn_Avaliacao.MinimumSize = new Size(498, 170);
            btn_Avaliacao.Name = "btn_Avaliacao";
            btn_Avaliacao.Size = new Size(498, 170);
            btn_Avaliacao.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Avaliacao.TabIndex = 2;
            btn_Avaliacao.TabStop = false;
            btn_Avaliacao.Click += btn_Avaliacao_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(386, 1050);
            label1.Name = "label1";
            label1.Size = new Size(1121, 21);
            label1.TabIndex = 3;
            label1.Text = "Nós respeitamos sua privacidade e seguimos as normas da LGPD, mesmo tratando apenas de dados não pessoais. Sua proteção é nossa prioridade.";
            // 
            // Frm_TelaInicial
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1080);
            Controls.Add(label1);
            Controls.Add(btn_Avaliacao);
            Controls.Add(btn_Mapa);
            Controls.Add(btn_Historia);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "Frm_TelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            Load += Frm_TelaInicial_Load;
            ((System.ComponentModel.ISupportInitialize)btn_Historia).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Mapa).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Avaliacao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btn_Historia;
        private PictureBox btn_Mapa;
        private PictureBox btn_Avaliacao;
        private Label label1;
    }
}
