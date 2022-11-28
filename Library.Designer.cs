
namespace GSMS
{
    partial class Library
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.middlePannel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txt_Borrowed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_BookId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Author = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Shelves = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Rack = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.label14 = new System.Windows.Forms.Label();
            this.Btn_Remove = new Guna.UI2.WinForms.Guna2Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Update = new Guna.UI2.WinForms.Guna2Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_GridLibrary = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bookidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelvesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowedBooksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librarytblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gsms_dbDataSet = new GSMS.gsms_dbDataSet();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ribbenPannel = new Guna.UI2.WinForms.Guna2Panel();
            this.pic_library = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Close_Timer = new System.Windows.Forms.Timer(this.components);
            this.library_tblTableAdapter = new GSMS.gsms_dbDataSetTableAdapters.Library_tblTableAdapter();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.Btn_Events = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Library = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Teachers = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Students = new Guna.UI2.WinForms.Guna2Button();
            this.Home_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.logo_pic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.minimize_btn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.close_btn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.Lbl_Available = new System.Windows.Forms.Label();
            this.Lbl_Borrowed = new System.Windows.Forms.Label();
            this.middlePannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GridLibrary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarytblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsms_dbDataSet)).BeginInit();
            this.ribbenPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_library)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // middlePannel
            // 
            this.middlePannel.BackColor = System.Drawing.Color.Transparent;
            this.middlePannel.BorderRadius = 20;
            this.middlePannel.BorderThickness = 10;
            this.middlePannel.Controls.Add(this.guna2PictureBox1);
            this.middlePannel.Controls.Add(this.txt_Borrowed);
            this.middlePannel.Controls.Add(this.txt_BookId);
            this.middlePannel.Controls.Add(this.txt_Author);
            this.middlePannel.Controls.Add(this.txt_Shelves);
            this.middlePannel.Controls.Add(this.txt_Rack);
            this.middlePannel.Controls.Add(this.txt_Name);
            this.middlePannel.Controls.Add(this.guna2Button5);
            this.middlePannel.Controls.Add(this.label14);
            this.middlePannel.Controls.Add(this.Btn_Remove);
            this.middlePannel.Controls.Add(this.label13);
            this.middlePannel.Controls.Add(this.label2);
            this.middlePannel.Controls.Add(this.Btn_Update);
            this.middlePannel.Controls.Add(this.label12);
            this.middlePannel.Controls.Add(this.Btn_add);
            this.middlePannel.Controls.Add(this.label11);
            this.middlePannel.Controls.Add(this.label10);
            this.middlePannel.Controls.Add(this.label5);
            this.middlePannel.Controls.Add(this.label4);
            this.middlePannel.Controls.Add(this.Lbl_Borrowed);
            this.middlePannel.Controls.Add(this.Lbl_Available);
            this.middlePannel.Controls.Add(this.Lbl_Total);
            this.middlePannel.Controls.Add(this.label3);
            this.middlePannel.Controls.Add(this.label8);
            this.middlePannel.Controls.Add(this.txt_GridLibrary);
            this.middlePannel.Controls.Add(this.txt_Search);
            this.middlePannel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(149)))), ((int)(((byte)(221)))));
            this.middlePannel.ForeColor = System.Drawing.SystemColors.Control;
            this.middlePannel.Location = new System.Drawing.Point(269, 170);
            this.middlePannel.MinimumSize = new System.Drawing.Size(1236, 511);
            this.middlePannel.Name = "middlePannel";
            this.middlePannel.Size = new System.Drawing.Size(1445, 693);
            this.middlePannel.TabIndex = 39;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::GSMS.Properties.Resources.library_icons;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(833, 18);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(94, 74);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 12;
            this.guna2PictureBox1.TabStop = false;
            // 
            // txt_Borrowed
            // 
            this.txt_Borrowed.BackColor = System.Drawing.Color.Transparent;
            this.txt_Borrowed.BorderRadius = 10;
            this.txt_Borrowed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_Borrowed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_Borrowed.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Borrowed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Borrowed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_Borrowed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_Borrowed.ItemHeight = 30;
            this.txt_Borrowed.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.txt_Borrowed.Location = new System.Drawing.Point(1021, 275);
            this.txt_Borrowed.Name = "txt_Borrowed";
            this.txt_Borrowed.Size = new System.Drawing.Size(346, 36);
            this.txt_Borrowed.TabIndex = 11;
            // 
            // txt_BookId
            // 
            this.txt_BookId.BorderRadius = 10;
            this.txt_BookId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_BookId.DefaultText = "";
            this.txt_BookId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_BookId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_BookId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_BookId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_BookId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_BookId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_BookId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_BookId.Location = new System.Drawing.Point(1022, 317);
            this.txt_BookId.Name = "txt_BookId";
            this.txt_BookId.PasswordChar = '\0';
            this.txt_BookId.PlaceholderText = "";
            this.txt_BookId.SelectedText = "";
            this.txt_BookId.Size = new System.Drawing.Size(345, 36);
            this.txt_BookId.TabIndex = 10;
            // 
            // txt_Author
            // 
            this.txt_Author.BorderRadius = 10;
            this.txt_Author.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Author.DefaultText = "";
            this.txt_Author.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Author.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Author.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Author.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Author.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Author.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Author.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Author.Location = new System.Drawing.Point(1022, 233);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.PasswordChar = '\0';
            this.txt_Author.PlaceholderText = "";
            this.txt_Author.SelectedText = "";
            this.txt_Author.Size = new System.Drawing.Size(345, 36);
            this.txt_Author.TabIndex = 10;
            // 
            // txt_Shelves
            // 
            this.txt_Shelves.BorderRadius = 10;
            this.txt_Shelves.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Shelves.DefaultText = "";
            this.txt_Shelves.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Shelves.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Shelves.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Shelves.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Shelves.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Shelves.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Shelves.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Shelves.Location = new System.Drawing.Point(1022, 191);
            this.txt_Shelves.Name = "txt_Shelves";
            this.txt_Shelves.PasswordChar = '\0';
            this.txt_Shelves.PlaceholderText = "";
            this.txt_Shelves.SelectedText = "";
            this.txt_Shelves.Size = new System.Drawing.Size(345, 36);
            this.txt_Shelves.TabIndex = 9;
            // 
            // txt_Rack
            // 
            this.txt_Rack.BorderRadius = 10;
            this.txt_Rack.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Rack.DefaultText = "";
            this.txt_Rack.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Rack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Rack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Rack.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Rack.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Rack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Rack.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Rack.Location = new System.Drawing.Point(1022, 149);
            this.txt_Rack.Name = "txt_Rack";
            this.txt_Rack.PasswordChar = '\0';
            this.txt_Rack.PlaceholderText = "";
            this.txt_Rack.SelectedText = "";
            this.txt_Rack.Size = new System.Drawing.Size(345, 36);
            this.txt_Rack.TabIndex = 8;
            // 
            // txt_Name
            // 
            this.txt_Name.BorderRadius = 10;
            this.txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Name.DefaultText = "";
            this.txt_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name.Location = new System.Drawing.Point(1022, 107);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.PlaceholderText = "";
            this.txt_Name.SelectedText = "";
            this.txt_Name.Size = new System.Drawing.Size(345, 36);
            this.txt_Name.TabIndex = 7;
            // 
            // guna2Button5
            // 
            this.guna2Button5.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderRadius = 15;
            this.guna2Button5.BorderThickness = 2;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(77)))));
            this.guna2Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(204)))));
            this.guna2Button5.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button5.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button5.Location = new System.Drawing.Point(938, 446);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(178, 44);
            this.guna2Button5.TabIndex = 5;
            this.guna2Button5.Text = "SUBMIT";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(933, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(336, 29);
            this.label14.TabIndex = 5;
            this.label14.Text = "NEW BOOK INFORMATION";
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_Remove.BorderRadius = 15;
            this.Btn_Remove.BorderThickness = 2;
            this.Btn_Remove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Remove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Remove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Remove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Remove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(77)))));
            this.Btn_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Remove.ForeColor = System.Drawing.Color.White;
            this.Btn_Remove.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(204)))));
            this.Btn_Remove.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Remove.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Remove.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Btn_Remove.Location = new System.Drawing.Point(727, 379);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(191, 49);
            this.Btn_Remove.TabIndex = 4;
            this.Btn_Remove.Text = "REMOVE BOOK";
            this.Btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(761, 283);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 29);
            this.label13.TabIndex = 5;
            this.label13.Text = "BORROWED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(761, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "BOOK ID";
            // 
            // Btn_Update
            // 
            this.Btn_Update.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_Update.BorderRadius = 15;
            this.Btn_Update.BorderThickness = 2;
            this.Btn_Update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(77)))));
            this.Btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.ForeColor = System.Drawing.Color.White;
            this.Btn_Update.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(204)))));
            this.Btn_Update.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Update.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Btn_Update.Location = new System.Drawing.Point(1158, 379);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(241, 47);
            this.Btn_Update.TabIndex = 3;
            this.Btn_Update.Text = "UPDATE CHANGES";
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(761, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 29);
            this.label12.TabIndex = 5;
            this.label12.Text = "AUTHOR";
            // 
            // Btn_add
            // 
            this.Btn_add.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_add.BorderRadius = 15;
            this.Btn_add.BorderThickness = 2;
            this.Btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(77)))));
            this.Btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_add.ForeColor = System.Drawing.Color.White;
            this.Btn_add.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(204)))));
            this.Btn_add.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_add.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_add.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Btn_add.Location = new System.Drawing.Point(953, 377);
            this.Btn_add.Name = "Btn_add";
            this.Btn_add.Size = new System.Drawing.Size(178, 49);
            this.Btn_add.TabIndex = 2;
            this.Btn_add.Text = "ADD BOOK";
            this.Btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(761, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 29);
            this.label11.TabIndex = 5;
            this.label11.Text = "SHELVES";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(761, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 29);
            this.label10.TabIndex = 5;
            this.label10.Text = "RACK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(761, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 29);
            this.label8.TabIndex = 5;
            this.label8.Text = "BOOK NAME";
            // 
            // txt_GridLibrary
            // 
            this.txt_GridLibrary.AllowUserToResizeColumns = false;
            this.txt_GridLibrary.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.txt_GridLibrary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.txt_GridLibrary.AutoGenerateColumns = false;
            this.txt_GridLibrary.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(149)))), ((int)(((byte)(221)))));
            this.txt_GridLibrary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.txt_GridLibrary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.txt_GridLibrary.ColumnHeadersHeight = 4;
            this.txt_GridLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.txt_GridLibrary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookidDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.rackDataGridViewTextBoxColumn,
            this.shelvesDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.borrowedBooksDataGridViewTextBoxColumn});
            this.txt_GridLibrary.DataSource = this.librarytblBindingSource;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.txt_GridLibrary.DefaultCellStyle = dataGridViewCellStyle15;
            this.txt_GridLibrary.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.txt_GridLibrary.Location = new System.Drawing.Point(30, 79);
            this.txt_GridLibrary.Name = "txt_GridLibrary";
            this.txt_GridLibrary.ReadOnly = true;
            this.txt_GridLibrary.RowHeadersVisible = false;
            this.txt_GridLibrary.RowHeadersWidth = 51;
            this.txt_GridLibrary.RowTemplate.Height = 24;
            this.txt_GridLibrary.Size = new System.Drawing.Size(646, 584);
            this.txt_GridLibrary.TabIndex = 3;
            this.txt_GridLibrary.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.txt_GridLibrary.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.txt_GridLibrary.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.txt_GridLibrary.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.txt_GridLibrary.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.txt_GridLibrary.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.txt_GridLibrary.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(149)))), ((int)(((byte)(221)))));
            this.txt_GridLibrary.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.txt_GridLibrary.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txt_GridLibrary.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.txt_GridLibrary.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GridLibrary.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.txt_GridLibrary.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.txt_GridLibrary.ThemeStyle.HeaderStyle.Height = 4;
            this.txt_GridLibrary.ThemeStyle.ReadOnly = true;
            this.txt_GridLibrary.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.txt_GridLibrary.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.txt_GridLibrary.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GridLibrary.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_GridLibrary.ThemeStyle.RowsStyle.Height = 24;
            this.txt_GridLibrary.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.txt_GridLibrary.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // bookidDataGridViewTextBoxColumn
            // 
            this.bookidDataGridViewTextBoxColumn.DataPropertyName = "Book_id";
            this.bookidDataGridViewTextBoxColumn.HeaderText = "Book_id";
            this.bookidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookidDataGridViewTextBoxColumn.Name = "bookidDataGridViewTextBoxColumn";
            this.bookidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rackDataGridViewTextBoxColumn
            // 
            this.rackDataGridViewTextBoxColumn.DataPropertyName = "Rack";
            this.rackDataGridViewTextBoxColumn.HeaderText = "Rack";
            this.rackDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rackDataGridViewTextBoxColumn.Name = "rackDataGridViewTextBoxColumn";
            this.rackDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shelvesDataGridViewTextBoxColumn
            // 
            this.shelvesDataGridViewTextBoxColumn.DataPropertyName = "Shelves";
            this.shelvesDataGridViewTextBoxColumn.HeaderText = "Shelves";
            this.shelvesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shelvesDataGridViewTextBoxColumn.Name = "shelvesDataGridViewTextBoxColumn";
            this.shelvesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // borrowedBooksDataGridViewTextBoxColumn
            // 
            this.borrowedBooksDataGridViewTextBoxColumn.DataPropertyName = "Borrowed_Books";
            this.borrowedBooksDataGridViewTextBoxColumn.HeaderText = "Borrowed_Books";
            this.borrowedBooksDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowedBooksDataGridViewTextBoxColumn.Name = "borrowedBooksDataGridViewTextBoxColumn";
            this.borrowedBooksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // librarytblBindingSource
            // 
            this.librarytblBindingSource.DataMember = "Library_tbl";
            this.librarytblBindingSource.DataSource = this.gsms_dbDataSet;
            // 
            // gsms_dbDataSet
            // 
            this.gsms_dbDataSet.DataSetName = "gsms_dbDataSet";
            this.gsms_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_Search
            // 
            this.txt_Search.BorderRadius = 10;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultText = "";
            this.txt_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.IconRight = global::GSMS.Properties.Resources._1251067;
            this.txt_Search.IconRightSize = new System.Drawing.Size(25, 25);
            this.txt_Search.Location = new System.Drawing.Point(30, 31);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "Search";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(646, 42);
            this.txt_Search.TabIndex = 2;
            this.txt_Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(518, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 46);
            this.label1.TabIndex = 41;
            this.label1.Text = "LIBRARY SECTION";
            // 
            // ribbenPannel
            // 
            this.ribbenPannel.BackColor = System.Drawing.Color.Transparent;
            this.ribbenPannel.BorderRadius = 20;
            this.ribbenPannel.BorderThickness = 10;
            this.ribbenPannel.Controls.Add(this.pic_library);
            this.ribbenPannel.Controls.Add(this.label1);
            this.ribbenPannel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(77)))));
            this.ribbenPannel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ribbenPannel.Location = new System.Drawing.Point(269, 57);
            this.ribbenPannel.Name = "ribbenPannel";
            this.ribbenPannel.Size = new System.Drawing.Size(1445, 87);
            this.ribbenPannel.TabIndex = 36;
            // 
            // pic_library
            // 
            this.pic_library.Image = global::GSMS.Properties.Resources.library;
            this.pic_library.ImageRotate = 0F;
            this.pic_library.Location = new System.Drawing.Point(422, 4);
            this.pic_library.Name = "pic_library";
            this.pic_library.Size = new System.Drawing.Size(90, 80);
            this.pic_library.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_library.TabIndex = 42;
            this.pic_library.TabStop = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Close_Timer
            // 
            this.Close_Timer.Tick += new System.EventHandler(this.Close_timer_Tick);
            // 
            // library_tblTableAdapter
            // 
            this.library_tblTableAdapter.ClearBeforeFill = true;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.guna2Panel4.Controls.Add(this.Btn_Events);
            this.guna2Panel4.Controls.Add(this.Btn_Library);
            this.guna2Panel4.Controls.Add(this.Btn_Teachers);
            this.guna2Panel4.Controls.Add(this.Btn_Students);
            this.guna2Panel4.Controls.Add(this.Home_btn);
            this.guna2Panel4.Controls.Add(this.label9);
            this.guna2Panel4.Controls.Add(this.logo_pic);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(220, 885);
            this.guna2Panel4.TabIndex = 79;
            // 
            // Btn_Events
            // 
            this.Btn_Events.BorderRadius = 10;
            this.Btn_Events.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Events.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Events.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Events.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Events.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(77)))));
            this.Btn_Events.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Events.ForeColor = System.Drawing.Color.White;
            this.Btn_Events.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(149)))), ((int)(((byte)(221)))));
            this.Btn_Events.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Btn_Events.Image = global::GSMS.Properties.Resources._1250932;
            this.Btn_Events.Location = new System.Drawing.Point(21, 590);
            this.Btn_Events.Name = "Btn_Events";
            this.Btn_Events.Size = new System.Drawing.Size(179, 51);
            this.Btn_Events.TabIndex = 31;
            this.Btn_Events.Tag = "Home";
            this.Btn_Events.Text = "EVENTS";
            this.Btn_Events.Click += new System.EventHandler(this.Btn_Events_Click);
            // 
            // Btn_Library
            // 
            this.Btn_Library.BorderRadius = 10;
            this.Btn_Library.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Library.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Library.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Library.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Library.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(77)))));
            this.Btn_Library.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Library.ForeColor = System.Drawing.Color.White;
            this.Btn_Library.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(149)))), ((int)(((byte)(221)))));
            this.Btn_Library.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Btn_Library.Image = global::GSMS.Properties.Resources._1245160;
            this.Btn_Library.Location = new System.Drawing.Point(21, 506);
            this.Btn_Library.Name = "Btn_Library";
            this.Btn_Library.Size = new System.Drawing.Size(179, 51);
            this.Btn_Library.TabIndex = 30;
            this.Btn_Library.Tag = "Home";
            this.Btn_Library.Text = "LIBRARY";
            this.Btn_Library.Click += new System.EventHandler(this.Btn_Library_Click);
            // 
            // Btn_Teachers
            // 
            this.Btn_Teachers.BorderRadius = 10;
            this.Btn_Teachers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Teachers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Teachers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Teachers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Teachers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(77)))));
            this.Btn_Teachers.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Teachers.ForeColor = System.Drawing.Color.White;
            this.Btn_Teachers.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(149)))), ((int)(((byte)(221)))));
            this.Btn_Teachers.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Btn_Teachers.Image = global::GSMS.Properties.Resources._1202881;
            this.Btn_Teachers.Location = new System.Drawing.Point(21, 425);
            this.Btn_Teachers.Name = "Btn_Teachers";
            this.Btn_Teachers.Size = new System.Drawing.Size(179, 51);
            this.Btn_Teachers.TabIndex = 29;
            this.Btn_Teachers.Tag = "Home";
            this.Btn_Teachers.Text = "TEACHERS";
            this.Btn_Teachers.Click += new System.EventHandler(this.Btn_Teachers_Click);
            // 
            // Btn_Students
            // 
            this.Btn_Students.BorderRadius = 10;
            this.Btn_Students.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Students.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Students.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Students.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Students.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(77)))));
            this.Btn_Students.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Students.ForeColor = System.Drawing.Color.White;
            this.Btn_Students.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(149)))), ((int)(((byte)(221)))));
            this.Btn_Students.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Btn_Students.Image = global::GSMS.Properties.Resources._1252284;
            this.Btn_Students.Location = new System.Drawing.Point(21, 341);
            this.Btn_Students.Name = "Btn_Students";
            this.Btn_Students.Size = new System.Drawing.Size(179, 51);
            this.Btn_Students.TabIndex = 28;
            this.Btn_Students.Tag = "Home";
            this.Btn_Students.Text = "STUDENTS";
            this.Btn_Students.Click += new System.EventHandler(this.Btn_Students_Click);
            // 
            // Home_btn
            // 
            this.Home_btn.BorderRadius = 10;
            this.Home_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Home_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Home_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Home_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Home_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(77)))));
            this.Home_btn.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_btn.ForeColor = System.Drawing.Color.White;
            this.Home_btn.Image = global::GSMS.Properties.Resources._69524;
            this.Home_btn.Location = new System.Drawing.Point(21, 262);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(179, 51);
            this.Home_btn.TabIndex = 27;
            this.Home_btn.Tag = "Home";
            this.Home_btn.Text = "HOME";
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(54, 840);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Copyright © 2022";
            // 
            // logo_pic
            // 
            this.logo_pic.Image = global::GSMS.Properties.Resources.Logo_GSMS;
            this.logo_pic.ImageRotate = 0F;
            this.logo_pic.Location = new System.Drawing.Point(0, 0);
            this.logo_pic.Name = "logo_pic";
            this.logo_pic.Size = new System.Drawing.Size(220, 219);
            this.logo_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_pic.TabIndex = 10;
            this.logo_pic.TabStop = false;
            // 
            // minimize_btn
            // 
            this.minimize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.minimize_btn.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimize_btn.FillColor = System.Drawing.Color.Transparent;
            this.minimize_btn.IconColor = System.Drawing.Color.Black;
            this.minimize_btn.Location = new System.Drawing.Point(1670, 12);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(31, 28);
            this.minimize_btn.TabIndex = 81;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.close_btn.CustomIconSize = 15F;
            this.close_btn.FillColor = System.Drawing.Color.Transparent;
            this.close_btn.IconColor = System.Drawing.Color.Black;
            this.close_btn.Location = new System.Drawing.Point(1707, 12);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(31, 28);
            this.close_btn.TabIndex = 80;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(722, 572);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "TOTAL BOOKS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(933, 572);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "AVAILABLE BOOKS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(1178, 572);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "BORROWED BOOKS";
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.Lbl_Total.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Total.Location = new System.Drawing.Point(722, 621);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(182, 29);
            this.Lbl_Total.TabIndex = 5;
            this.Lbl_Total.Text = "TOTAL BOOKS";
            // 
            // Lbl_Available
            // 
            this.Lbl_Available.AutoSize = true;
            this.Lbl_Available.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.Lbl_Available.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Available.Location = new System.Drawing.Point(949, 621);
            this.Lbl_Available.Name = "Lbl_Available";
            this.Lbl_Available.Size = new System.Drawing.Size(182, 29);
            this.Lbl_Available.TabIndex = 5;
            this.Lbl_Available.Text = "TOTAL BOOKS";
            // 
            // Lbl_Borrowed
            // 
            this.Lbl_Borrowed.AutoSize = true;
            this.Lbl_Borrowed.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.Lbl_Borrowed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Borrowed.Location = new System.Drawing.Point(1202, 621);
            this.Lbl_Borrowed.Name = "Lbl_Borrowed";
            this.Lbl_Borrowed.Size = new System.Drawing.Size(182, 29);
            this.Lbl_Borrowed.TabIndex = 5;
            this.Lbl_Borrowed.Text = "TOTAL BOOKS";
            // 
            // Library
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1750, 885);
            this.Controls.Add(this.minimize_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.middlePannel);
            this.Controls.Add(this.ribbenPannel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Library";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.middlePannel.ResumeLayout(false);
            this.middlePannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GridLibrary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarytblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsms_dbDataSet)).EndInit();
            this.ribbenPannel.ResumeLayout(false);
            this.ribbenPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_library)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel middlePannel;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button Btn_Remove;
        private Guna.UI2.WinForms.Guna2Button Btn_Update;
        private Guna.UI2.WinForms.Guna2Button Btn_add;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel ribbenPannel;
        private Guna.UI2.WinForms.Guna2DataGridView txt_GridLibrary;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txt_Author;
        private Guna.UI2.WinForms.Guna2TextBox txt_Shelves;
        private Guna.UI2.WinForms.Guna2TextBox txt_Rack;
        private Guna.UI2.WinForms.Guna2TextBox txt_Name;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Timer Close_Timer;
        private Guna.UI2.WinForms.Guna2ComboBox txt_Borrowed;
        private System.Windows.Forms.Label label13;
        private gsms_dbDataSet gsms_dbDataSet;
        private System.Windows.Forms.BindingSource librarytblBindingSource;
        private gsms_dbDataSetTableAdapters.Library_tblTableAdapter library_tblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelvesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowedBooksDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2PictureBox logo_pic;
        private Guna.UI2.WinForms.Guna2PictureBox pic_library;
        private Guna.UI2.WinForms.Guna2ControlBox minimize_btn;
        private Guna.UI2.WinForms.Guna2ControlBox close_btn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button Btn_Events;
        private Guna.UI2.WinForms.Guna2Button Btn_Library;
        private Guna.UI2.WinForms.Guna2Button Btn_Teachers;
        private Guna.UI2.WinForms.Guna2Button Btn_Students;
        private Guna.UI2.WinForms.Guna2Button Home_btn;
        private Guna.UI2.WinForms.Guna2TextBox txt_BookId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_Borrowed;
        private System.Windows.Forms.Label Lbl_Available;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.Label label3;
    }
}

