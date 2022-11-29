
namespace GSMS
{
    partial class Login
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
            this.submit_btn = new Guna.UI2.WinForms.Guna2Button();
            this.pwd_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.teacherid_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.Btn_Minimize.Location = new System.Drawing.Point(1120, 12);
            this.Btn_Minimize.Name = "Btn_Minimize";
            this.Btn_Minimize.Size = new System.Drawing.Size(31, 28);
            this.Btn_Minimize.TabIndex = 9;
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Close.CustomIconSize = 15F;
            this.Btn_Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Btn_Close.IconColor = System.Drawing.Color.Black;
            this.Btn_Close.Location = new System.Drawing.Point(1157, 12);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(31, 28);
            this.Btn_Close.TabIndex = 8;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // submit_btn
            // 
            this.submit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.submit_btn.BorderRadius = 10;
            this.submit_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.submit_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.submit_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.submit_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.submit_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(132)))), ((int)(((byte)(31)))));
            this.submit_btn.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
            this.submit_btn.ForeColor = System.Drawing.Color.White;
            this.submit_btn.Location = new System.Drawing.Point(780, 510);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(180, 45);
            this.submit_btn.TabIndex = 27;
            this.submit_btn.Text = "Submit";
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // pwd_txt
            // 
            this.pwd_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.pwd_txt.BorderRadius = 10;
            this.pwd_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pwd_txt.DefaultText = "";
            this.pwd_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pwd_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pwd_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pwd_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pwd_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pwd_txt.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.pwd_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pwd_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pwd_txt.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.pwd_txt.IconRightSize = new System.Drawing.Size(22, 22);
            this.pwd_txt.Location = new System.Drawing.Point(718, 392);
            this.pwd_txt.Name = "pwd_txt";
            this.pwd_txt.PasswordChar = '\0';
            this.pwd_txt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.pwd_txt.PlaceholderText = "Password";
            this.pwd_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pwd_txt.SelectedText = "";
            this.pwd_txt.Size = new System.Drawing.Size(320, 54);
            this.pwd_txt.TabIndex = 26;
            // 
            // teacherid_txt
            // 
            this.teacherid_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.teacherid_txt.BorderRadius = 10;
            this.teacherid_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.teacherid_txt.DefaultText = "";
            this.teacherid_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.teacherid_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.teacherid_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.teacherid_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.teacherid_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.teacherid_txt.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.teacherid_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teacherid_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.teacherid_txt.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.teacherid_txt.IconRightSize = new System.Drawing.Size(22, 22);
            this.teacherid_txt.Location = new System.Drawing.Point(718, 323);
            this.teacherid_txt.Name = "teacherid_txt";
            this.teacherid_txt.PasswordChar = '\0';
            this.teacherid_txt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.teacherid_txt.PlaceholderText = "Username(or)ID";
            this.teacherid_txt.SelectedText = "";
            this.teacherid_txt.Size = new System.Drawing.Size(320, 54);
            this.teacherid_txt.TabIndex = 25;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::GSMS.Properties.Resources.gsms_login;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, -1);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1198, 729);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 10;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(132)))), ((int)(((byte)(31)))));
            this.label1.Location = new System.Drawing.Point(879, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 38);
            this.label1.TabIndex = 30;
            this.label1.Text = "Login Now";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(732, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "PHONE NUMBER IS PASSWORD";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 728);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.pwd_txt);
            this.Controls.Add(this.teacherid_txt);
            this.Controls.Add(this.Btn_Minimize);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ControlBox Btn_Minimize;
        private Guna.UI2.WinForms.Guna2ControlBox Btn_Close;
        private Guna.UI2.WinForms.Guna2Button submit_btn;
        private Guna.UI2.WinForms.Guna2TextBox pwd_txt;
        private Guna.UI2.WinForms.Guna2TextBox teacherid_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}