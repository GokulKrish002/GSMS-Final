
namespace GSMS
{
    partial class Landing_app
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Btn_Minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Btn_Close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Btn_Sign_in = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // Btn_Minimize
            // 
            this.Btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Btn_Minimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Btn_Minimize.IconColor = System.Drawing.Color.Black;
            this.Btn_Minimize.Location = new System.Drawing.Point(1121, 12);
            this.Btn_Minimize.Name = "Btn_Minimize";
            this.Btn_Minimize.Size = new System.Drawing.Size(31, 28);
            this.Btn_Minimize.TabIndex = 7;
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Close.CustomIconSize = 15F;
            this.Btn_Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Btn_Close.IconColor = System.Drawing.Color.Black;
            this.Btn_Close.Location = new System.Drawing.Point(1158, 12);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(31, 28);
            this.Btn_Close.TabIndex = 6;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_Sign_in
            // 
            this.Btn_Sign_in.BorderRadius = 10;
            this.Btn_Sign_in.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Sign_in.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Sign_in.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Sign_in.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Sign_in.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(132)))), ((int)(((byte)(31)))));
            this.Btn_Sign_in.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.Btn_Sign_in.ForeColor = System.Drawing.Color.White;
            this.Btn_Sign_in.Location = new System.Drawing.Point(146, 448);
            this.Btn_Sign_in.Name = "Btn_Sign_in";
            this.Btn_Sign_in.Size = new System.Drawing.Size(180, 45);
            this.Btn_Sign_in.TabIndex = 5;
            this.Btn_Sign_in.Text = "Sign-In";
            this.Btn_Sign_in.Click += new System.EventHandler(this.Btn_Sign_in_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::GSMS.Properties.Resources.landing_form;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1201, 729);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Landing_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 728);
            this.Controls.Add(this.Btn_Minimize);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Sign_in);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Landing_app";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Landing_app";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox Btn_Minimize;
        private Guna.UI2.WinForms.Guna2ControlBox Btn_Close;
        private Guna.UI2.WinForms.Guna2Button Btn_Sign_in;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}