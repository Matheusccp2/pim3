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
            pictureBox3 = new PictureBox();
            btn_VoltarMenu = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Confirmar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_VoltarMenu).BeginInit();
            SuspendLayout();
            // 
            // txb_NomeUsuario
            // 
            txb_NomeUsuario.BackColor = Color.White;
            txb_NomeUsuario.BorderStyle = BorderStyle.None;
            txb_NomeUsuario.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            txb_NomeUsuario.ForeColor = Color.Black;
            txb_NomeUsuario.Location = new Point(824, 295);
            txb_NomeUsuario.MinimumSize = new Size(203, 23);
            txb_NomeUsuario.Name = "txb_NomeUsuario";
            txb_NomeUsuario.Size = new Size(607, 50);
            txb_NomeUsuario.TabIndex = 9;
            txb_NomeUsuario.Enter += txb_NomeUsuario_Enter;
            txb_NomeUsuario.Leave += txb_NomeUsuario_Leave;
            // 
            // txb_IdadeUsuario
            // 
            txb_IdadeUsuario.BackColor = Color.White;
            txb_IdadeUsuario.BorderStyle = BorderStyle.None;
            txb_IdadeUsuario.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            txb_IdadeUsuario.ForeColor = Color.Black;
            txb_IdadeUsuario.Location = new Point(824, 390);
            txb_IdadeUsuario.Name = "txb_IdadeUsuario";
            txb_IdadeUsuario.Size = new Size(90, 50);
            txb_IdadeUsuario.TabIndex = 1;
            txb_IdadeUsuario.TextAlign = HorizontalAlignment.Center;
            txb_IdadeUsuario.Enter += txb_IdadeUsuario_Enter;
            txb_IdadeUsuario.Leave += txb_IdadeUsuario_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.NOME_;
            pictureBox1.Location = new Point(449, 286);
            pictureBox1.MinimumSize = new Size(268, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.IDADE_;
            pictureBox2.Location = new Point(449, 381);
            pictureBox2.MinimumSize = new Size(268, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(326, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btn_Confirmar
            // 
            btn_Confirmar.BackColor = Color.Transparent;
            btn_Confirmar.Image = Properties.Resources.BOTÃO_INICIAR_VALIDAÇÃO;
            btn_Confirmar.Location = new Point(1267, 615);
            btn_Confirmar.MinimumSize = new Size(124, 35);
            btn_Confirmar.Name = "btn_Confirmar";
            btn_Confirmar.Size = new Size(261, 71);
            btn_Confirmar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Confirmar.TabIndex = 4;
            btn_Confirmar.TabStop = false;
            btn_Confirmar.Click += btn_Confirmar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.BORDA;
            pictureBox3.Location = new Point(387, 162);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1141, 420);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // btn_VoltarMenu
            // 
            btn_VoltarMenu.BackColor = Color.Transparent;
            btn_VoltarMenu.Image = (Image)resources.GetObject("btn_VoltarMenu.Image");
            btn_VoltarMenu.Location = new Point(387, 612);
            btn_VoltarMenu.MaximumSize = new Size(276, 74);
            btn_VoltarMenu.MinimumSize = new Size(276, 74);
            btn_VoltarMenu.Name = "btn_VoltarMenu";
            btn_VoltarMenu.Size = new Size(276, 74);
            btn_VoltarMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_VoltarMenu.TabIndex = 6;
            btn_VoltarMenu.TabStop = false;
            btn_VoltarMenu.Click += btn_VoltarMenu_Click;
            // 
            // Frm_RegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.Foto_de_Fundo2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1918, 1041);
            Controls.Add(btn_VoltarMenu);
            Controls.Add(txb_IdadeUsuario);
            Controls.Add(txb_NomeUsuario);
            Controls.Add(btn_Confirmar);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "Frm_RegistroUsuario";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro Usuário";
            TransparencyKey = Color.Black;
            WindowState = FormWindowState.Maximized;
            FormClosed += Frm_RegistroUsuario_FormClosed;
            Load += Frm_RegistroUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Confirmar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_VoltarMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_NomeUsuario;
        private TextBox txb_IdadeUsuario;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox btn_Confirmar;
        private PictureBox pictureBox3;
        private PictureBox btn_VoltarMenu;
    }
}