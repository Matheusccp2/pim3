namespace SoftwarePIM
{
    partial class Frm_TelaMapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TelaMapa));
            btn_Menu = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btn_Menu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Menu
            // 
            btn_Menu.BackColor = Color.Transparent;
            btn_Menu.Image = (Image)resources.GetObject("btn_Menu.Image");
            btn_Menu.Location = new Point(831, 608);
            btn_Menu.Margin = new Padding(3, 2, 3, 2);
            btn_Menu.MinimumSize = new Size(169, 32);
            btn_Menu.Name = "btn_Menu";
            btn_Menu.Size = new Size(280, 78);
            btn_Menu.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Menu.TabIndex = 6;
            btn_Menu.TabStop = false;
            btn_Menu.Click += btn_Menu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Totem3sem1;
            pictureBox1.Location = new Point(565, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(818, 460);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Frm_TelaMapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.Foto_de_Fundo2;
            ClientSize = new Size(1920, 1080);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Menu);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "Frm_TelaMapa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mapa";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)btn_Menu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btn_Menu;
        private PictureBox pictureBox1;
    }
}