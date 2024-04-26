namespace SoftwarePIM
{
    partial class Frm_TelaSugestao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TelaSugestao));
            pictureBox1 = new PictureBox();
            txb_Sugestao = new TextBox();
            btn_Proximo = new PictureBox();
            btn_VoltarMenu = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Proximo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_VoltarMenu).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(155, 82);
            pictureBox1.MaximumSize = new Size(475, 46);
            pictureBox1.MinimumSize = new Size(475, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(475, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txb_Sugestao
            // 
            txb_Sugestao.BackColor = Color.PowderBlue;
            txb_Sugestao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Sugestao.ForeColor = SystemColors.ControlText;
            txb_Sugestao.Location = new Point(155, 157);
            txb_Sugestao.MaximumSize = new Size(475, 160);
            txb_Sugestao.MinimumSize = new Size(475, 160);
            txb_Sugestao.Multiline = true;
            txb_Sugestao.Name = "txb_Sugestao";
            txb_Sugestao.PlaceholderText = "  Deixe a sua opinião aqui...";
            txb_Sugestao.Size = new Size(475, 160);
            txb_Sugestao.TabIndex = 2;
            // 
            // btn_Proximo
            // 
            btn_Proximo.BackColor = Color.Transparent;
            btn_Proximo.Image = (Image)resources.GetObject("btn_Proximo.Image");
            btn_Proximo.Location = new Point(500, 332);
            btn_Proximo.MaximumSize = new Size(124, 35);
            btn_Proximo.MinimumSize = new Size(124, 35);
            btn_Proximo.Name = "btn_Proximo";
            btn_Proximo.Size = new Size(124, 35);
            btn_Proximo.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Proximo.TabIndex = 3;
            btn_Proximo.TabStop = false;
            btn_Proximo.Click += btn_Proximo_Click;
            // 
            // btn_VoltarMenu
            // 
            btn_VoltarMenu.BackColor = Color.Transparent;
            btn_VoltarMenu.Image = (Image)resources.GetObject("btn_VoltarMenu.Image");
            btn_VoltarMenu.Location = new Point(161, 332);
            btn_VoltarMenu.MaximumSize = new Size(124, 35);
            btn_VoltarMenu.MinimumSize = new Size(124, 35);
            btn_VoltarMenu.Name = "btn_VoltarMenu";
            btn_VoltarMenu.Size = new Size(124, 35);
            btn_VoltarMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_VoltarMenu.TabIndex = 4;
            btn_VoltarMenu.TabStop = false;
            btn_VoltarMenu.Click += btn_VoltarMenu_Click;
            // 
            // Frm_TelaSugestao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 561);
            Controls.Add(btn_VoltarMenu);
            Controls.Add(btn_Proximo);
            Controls.Add(txb_Sugestao);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "Frm_TelaSugestao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_TelaSugestao";
            Load += Frm_TelaSugestao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Proximo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_VoltarMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txb_Sugestao;
        private PictureBox btn_Proximo;
        private PictureBox btn_VoltarMenu;
    }
}