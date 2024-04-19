namespace SoftwarePIM
{
    partial class Frm_PopUpMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PopUpMenu));
            btn_Sim = new PictureBox();
            btn_Nao = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btn_Sim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Nao).BeginInit();
            SuspendLayout();
            // 
            // btn_Sim
            // 
            btn_Sim.BackColor = Color.Transparent;
            btn_Sim.Image = (Image)resources.GetObject("btn_Sim.Image");
            btn_Sim.Location = new Point(39, 77);
            btn_Sim.Name = "btn_Sim";
            btn_Sim.Size = new Size(96, 50);
            btn_Sim.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Sim.TabIndex = 0;
            btn_Sim.TabStop = false;
            btn_Sim.Click += pictureBox1_Click;
            // 
            // btn_Nao
            // 
            btn_Nao.BackColor = Color.Transparent;
            btn_Nao.Image = (Image)resources.GetObject("btn_Nao.Image");
            btn_Nao.Location = new Point(303, 77);
            btn_Nao.Name = "btn_Nao";
            btn_Nao.Size = new Size(96, 50);
            btn_Nao.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Nao.TabIndex = 1;
            btn_Nao.TabStop = false;
            btn_Nao.Click += pictureBox2_Click;
            // 
            // Frm_PopUpMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(446, 139);
            ControlBox = false;
            Controls.Add(btn_Nao);
            Controls.Add(btn_Sim);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_PopUpMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_PopUpMenu";
            ((System.ComponentModel.ISupportInitialize)btn_Sim).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Nao).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btn_Sim;
        private PictureBox btn_Nao;
    }
}