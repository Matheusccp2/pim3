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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TelaHistoria));
            btn_Anterior = new PictureBox();
            btn_Proximo = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btn_Menu = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btn_Anterior).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Proximo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Menu).BeginInit();
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
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(146, 85);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.MaximumSize = new Size(156, 242);
            pictureBox3.MinimumSize = new Size(156, 242);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(156, 242);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 192);
            label1.Location = new Point(308, 85);
            label1.MaximumSize = new Size(324, 32);
            label1.MinimumSize = new Size(324, 32);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(324, 32);
            label1.TabIndex = 3;
            label1.Text = "\"UM PEQUENO PASSO PARA O HOMEM, UM GRANDE PASSO PARA A HUMANIDADE\"";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseMnemonic = false;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(318, 127);
            label2.MaximumSize = new Size(314, 200);
            label2.MinimumSize = new Size(314, 200);
            label2.Name = "label2";
            label2.Size = new Size(314, 200);
            label2.TabIndex = 4;
            label2.Text = resources.GetString("label2.Text");
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
            // Frm_TelaHistoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 561);
            Controls.Add(btn_Menu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(btn_Proximo);
            Controls.Add(btn_Anterior);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "Frm_TelaHistoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "História";
            ((System.ComponentModel.ISupportInitialize)btn_Anterior).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Proximo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Menu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btn_Anterior;
        private PictureBox btn_Proximo;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private PictureBox btn_Menu;
    }
}