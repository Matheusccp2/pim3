namespace SoftwarePIM
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
            ((System.ComponentModel.ISupportInitialize)btn_Historia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Mapa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Avaliacao).BeginInit();
            SuspendLayout();
            // 
            // btn_Historia
            // 
            btn_Historia.BackColor = Color.Transparent;
            btn_Historia.Image = (Image)resources.GetObject("btn_Historia.Image");
            btn_Historia.Location = new Point(298, 188);
            btn_Historia.Name = "btn_Historia";
            btn_Historia.Size = new Size(186, 62);
            btn_Historia.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Historia.TabIndex = 0;
            btn_Historia.TabStop = false;
            btn_Historia.Click += btn_Historia_Click;
            // 
            // btn_Mapa
            // 
            btn_Mapa.BackColor = Color.Transparent;
            btn_Mapa.Image = (Image)resources.GetObject("btn_Mapa.Image");
            btn_Mapa.Location = new Point(329, 97);
            btn_Mapa.Name = "btn_Mapa";
            btn_Mapa.Size = new Size(125, 62);
            btn_Mapa.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Mapa.TabIndex = 1;
            btn_Mapa.TabStop = false;
            btn_Mapa.Click += btn_Mapa_Click;
            // 
            // btn_Avaliacao
            // 
            btn_Avaliacao.BackColor = Color.Transparent;
            btn_Avaliacao.Image = (Image)resources.GetObject("btn_Avaliacao.Image");
            btn_Avaliacao.Location = new Point(280, 279);
            btn_Avaliacao.Name = "btn_Avaliacao";
            btn_Avaliacao.Size = new Size(223, 62);
            btn_Avaliacao.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Avaliacao.TabIndex = 2;
            btn_Avaliacao.TabStop = false;
            btn_Avaliacao.Click += btn_Avaliacao_Click;
            // 
            // Frm_TelaInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 553);
            Controls.Add(btn_Avaliacao);
            Controls.Add(btn_Mapa);
            Controls.Add(btn_Historia);
            DoubleBuffered = true;
            Name = "Frm_TelaInicial";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)btn_Historia).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Mapa).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Avaliacao).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btn_Historia;
        private PictureBox btn_Mapa;
        private PictureBox btn_Avaliacao;
    }
}
