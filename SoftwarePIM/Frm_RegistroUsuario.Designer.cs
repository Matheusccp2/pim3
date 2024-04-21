namespace SoftwarePIM
{
    partial class Frm_RegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RegistroUsuario));
            txb_NomeUsuario = new TextBox();
            txb_IdadeUsuario = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btn_Confirmar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Confirmar).BeginInit();
            SuspendLayout();
            // 
            // txb_NomeUsuario
            // 
            txb_NomeUsuario.Location = new Point(337, 48);
            txb_NomeUsuario.MaximumSize = new Size(203, 23);
            txb_NomeUsuario.MinimumSize = new Size(203, 23);
            txb_NomeUsuario.Name = "txb_NomeUsuario";
            txb_NomeUsuario.Size = new Size(203, 23);
            txb_NomeUsuario.TabIndex = 0;
            // 
            // txb_IdadeUsuario
            // 
            txb_IdadeUsuario.Location = new Point(337, 96);
            txb_IdadeUsuario.MaximumSize = new Size(203, 23);
            txb_IdadeUsuario.MinimumSize = new Size(203, 23);
            txb_IdadeUsuario.Name = "txb_IdadeUsuario";
            txb_IdadeUsuario.Size = new Size(203, 23);
            txb_IdadeUsuario.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 45);
            pictureBox1.MaximumSize = new Size(268, 29);
            pictureBox1.MinimumSize = new Size(268, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(42, 93);
            pictureBox2.MaximumSize = new Size(268, 29);
            pictureBox2.MinimumSize = new Size(268, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(268, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btn_Confirmar
            // 
            btn_Confirmar.BackColor = Color.Transparent;
            btn_Confirmar.Image = (Image)resources.GetObject("btn_Confirmar.Image");
            btn_Confirmar.Location = new Point(228, 152);
            btn_Confirmar.MaximumSize = new Size(124, 35);
            btn_Confirmar.MinimumSize = new Size(124, 35);
            btn_Confirmar.Name = "btn_Confirmar";
            btn_Confirmar.Size = new Size(124, 35);
            btn_Confirmar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Confirmar.TabIndex = 4;
            btn_Confirmar.TabStop = false;
            btn_Confirmar.Click += btn_Confirmar_Click;
            // 
            // Frm_RegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(581, 214);
            ControlBox = false;
            Controls.Add(btn_Confirmar);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txb_IdadeUsuario);
            Controls.Add(txb_NomeUsuario);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(581, 214);
            MinimumSize = new Size(581, 214);
            Name = "Frm_RegistroUsuario";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            TransparencyKey = Color.Black;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Confirmar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_NomeUsuario;
        private TextBox txb_IdadeUsuario;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox btn_Confirmar;
    }
}