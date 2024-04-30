namespace SoftwarePIM
{
    partial class Frm_TelaHistoria
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TelaHistoria));
            btn_Anterior = new PictureBox();
            btn_Proximo = new PictureBox();
            btn_Menu = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            lbl_Obra1 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)btn_Anterior).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Proximo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Menu).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Anterior
            // 
            btn_Anterior.BackColor = Color.Transparent;
            btn_Anterior.Image = (Image)resources.GetObject("btn_Anterior.Image");
            btn_Anterior.Location = new Point(146, 331);
            btn_Anterior.Margin = new Padding(3, 2, 3, 2);
            btn_Anterior.MaximumSize = new Size(35, 32);
            btn_Anterior.MinimumSize = new Size(35, 32);
            btn_Anterior.Name = "btn_Anterior";
            btn_Anterior.Size = new Size(35, 32);
            btn_Anterior.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Anterior.TabIndex = 0;
            btn_Anterior.TabStop = false;
            btn_Anterior.Click += btn_Anterior_Click;
            // 
            // btn_Proximo
            // 
            btn_Proximo.BackColor = Color.Transparent;
            btn_Proximo.Image = (Image)resources.GetObject("btn_Proximo.Image");
            btn_Proximo.Location = new Point(597, 331);
            btn_Proximo.Margin = new Padding(3, 2, 3, 2);
            btn_Proximo.MaximumSize = new Size(35, 32);
            btn_Proximo.MinimumSize = new Size(35, 32);
            btn_Proximo.Name = "btn_Proximo";
            btn_Proximo.Size = new Size(35, 32);
            btn_Proximo.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Proximo.TabIndex = 1;
            btn_Proximo.TabStop = false;
            btn_Proximo.Click += btn_Proximo_Click;
            // 
            // btn_Menu
            // 
            btn_Menu.BackColor = Color.Transparent;
            btn_Menu.Image = (Image)resources.GetObject("btn_Menu.Image");
            btn_Menu.Location = new Point(308, 331);
            btn_Menu.Margin = new Padding(3, 2, 3, 2);
            btn_Menu.MaximumSize = new Size(169, 32);
            btn_Menu.MinimumSize = new Size(169, 32);
            btn_Menu.Name = "btn_Menu";
            btn_Menu.Size = new Size(169, 32);
            btn_Menu.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Menu.TabIndex = 5;
            btn_Menu.TabStop = false;
            btn_Menu.Click += btn_Menu_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(138, 71);
            panel1.MaximumSize = new Size(504, 255);
            panel1.MinimumSize = new Size(504, 255);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 255);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(181, 48);
            label2.MaximumSize = new Size(314, 200);
            label2.MinimumSize = new Size(314, 200);
            label2.Name = "label2";
            label2.Size = new Size(314, 200);
            label2.TabIndex = 7;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 192);
            label1.Location = new Point(171, 6);
            label1.MaximumSize = new Size(324, 32);
            label1.MinimumSize = new Size(324, 32);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(324, 32);
            label1.TabIndex = 6;
            label1.Text = "\"UM PEQUENO PASSO PARA O HOMEM, UM GRANDE PASSO PARA A HUMANIDADE\"";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseMnemonic = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(9, 6);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.MaximumSize = new Size(156, 242);
            pictureBox3.MinimumSize = new Size(156, 242);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(156, 242);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(lbl_Obra1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(138, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(504, 255);
            panel2.TabIndex = 8;
            panel2.Visible = false;
            // 
            // lbl_Obra1
            // 
            lbl_Obra1.BackColor = Color.Transparent;
            lbl_Obra1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Obra1.ForeColor = Color.White;
            lbl_Obra1.Location = new Point(181, 48);
            lbl_Obra1.MaximumSize = new Size(314, 200);
            lbl_Obra1.MinimumSize = new Size(314, 200);
            lbl_Obra1.Name = "lbl_Obra1";
            lbl_Obra1.Size = new Size(314, 200);
            lbl_Obra1.TabIndex = 7;
            lbl_Obra1.Text = resources.GetString("lbl_Obra1.Text");
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 192, 192);
            label4.Location = new Point(171, 6);
            label4.MaximumSize = new Size(324, 32);
            label4.MinimumSize = new Size(324, 32);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(324, 32);
            label4.TabIndex = 6;
            label4.Text = "MINIATURA DA LUA";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(9, 6);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.MaximumSize = new Size(156, 242);
            pictureBox1.MinimumSize = new Size(156, 242);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Frm_TelaHistoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 561);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_Menu);
            Controls.Add(btn_Proximo);
            Controls.Add(btn_Anterior);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "Frm_TelaHistoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "História";
            FormClosing += Frm_TelaHistoria_FormClosing;
            Load += Frm_TelaHistoria_Load;
            ((System.ComponentModel.ISupportInitialize)btn_Anterior).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Proximo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Menu).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btn_Anterior;
        private PictureBox btn_Proximo;
        private PictureBox btn_Menu;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Label lbl_Obra1;
        private Label label4;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}