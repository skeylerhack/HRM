﻿namespace VietSoftHRM
{
    partial class frmLogin
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::VietSoftHRM.SplashScreenMain), true, true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbo_database = new DevExpress.XtraEditors.LookUpEdit();
            this.che_Repass = new System.Windows.Forms.CheckBox();
            this.che_Reuser = new System.Windows.Forms.CheckBox();
            this.btn_Register = new DevExpress.XtraEditors.SimpleButton();
            this.btn_login = new DevExpress.XtraEditors.SimpleButton();
            this.pan_pass = new System.Windows.Forms.Panel();
            this.pan_user = new System.Windows.Forms.Panel();
            this.pan_database = new System.Windows.Forms.Panel();
            this.pic_pass = new DevExpress.XtraEditors.PictureEdit();
            this.pic_user = new DevExpress.XtraEditors.PictureEdit();
            this.pic_database = new DevExpress.XtraEditors.PictureEdit();
            this.txt_pass = new DevExpress.XtraEditors.TextEdit();
            this.txt_user = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_database.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_database.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 100;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.imageSlider1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 420);
            this.panel1.TabIndex = 0;
            // 
            // imageSlider1
            // 
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.Location = new System.Drawing.Point(0, 0);
            this.imageSlider1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(312, 420);
            this.imageSlider1.TabIndex = 0;
            this.imageSlider1.Text = "imageSlider1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.cbo_database);
            this.panel2.Controls.Add(this.che_Repass);
            this.panel2.Controls.Add(this.che_Reuser);
            this.panel2.Controls.Add(this.btn_Register);
            this.panel2.Controls.Add(this.btn_login);
            this.panel2.Controls.Add(this.pan_pass);
            this.panel2.Controls.Add(this.pan_user);
            this.panel2.Controls.Add(this.pan_database);
            this.panel2.Controls.Add(this.pic_pass);
            this.panel2.Controls.Add(this.pic_user);
            this.panel2.Controls.Add(this.pic_database);
            this.panel2.Controls.Add(this.txt_pass);
            this.panel2.Controls.Add(this.txt_user);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(312, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 420);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cbo_database
            // 
            this.cbo_database.Location = new System.Drawing.Point(44, 84);
            this.cbo_database.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_database.Name = "cbo_database";
            this.cbo_database.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbo_database.Properties.Appearance.Options.UseBackColor = true;
            this.cbo_database.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cbo_database.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_database.Properties.NullText = "Database";
            this.cbo_database.Size = new System.Drawing.Size(311, 24);
            this.cbo_database.TabIndex = 11;
            this.cbo_database.Click += new System.EventHandler(this.Cbo_database_Click);
            this.cbo_database.Validated += new System.EventHandler(this.Cbo_database_Validated);
            // 
            // che_Repass
            // 
            this.che_Repass.AutoSize = true;
            this.che_Repass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.che_Repass.Location = new System.Drawing.Point(192, 249);
            this.che_Repass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.che_Repass.Name = "che_Repass";
            this.che_Repass.Size = new System.Drawing.Size(163, 24);
            this.che_Repass.TabIndex = 4;
            this.che_Repass.Text = "Remember Password";
            this.che_Repass.UseVisualStyleBackColor = true;
            // 
            // che_Reuser
            // 
            this.che_Reuser.AutoSize = true;
            this.che_Reuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.che_Reuser.Location = new System.Drawing.Point(17, 249);
            this.che_Reuser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.che_Reuser.Name = "che_Reuser";
            this.che_Reuser.Size = new System.Drawing.Size(129, 24);
            this.che_Reuser.TabIndex = 3;
            this.che_Reuser.Text = "Remember user";
            this.che_Reuser.UseVisualStyleBackColor = true;
            // 
            // btn_Register
            // 
            this.btn_Register.Appearance.BackColor = System.Drawing.Color.White;
            this.btn_Register.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btn_Register.Appearance.BorderColor = System.Drawing.Color.White;
            this.btn_Register.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_Register.Appearance.Options.UseBackColor = true;
            this.btn_Register.Appearance.Options.UseBorderColor = true;
            this.btn_Register.Appearance.Options.UseForeColor = true;
            this.btn_Register.AppearanceHovered.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Register.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_Register.AppearanceHovered.Options.UseFont = true;
            this.btn_Register.AppearanceHovered.Options.UseForeColor = true;
            this.btn_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Register.Location = new System.Drawing.Point(16, 350);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(339, 54);
            this.btn_Register.TabIndex = 6;
            this.btn_Register.Text = "Register";
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_login
            // 
            this.btn_login.Appearance.BackColor = System.Drawing.Color.Black;
            this.btn_login.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.btn_login.Appearance.BorderColor = System.Drawing.Color.Black;
            this.btn_login.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_login.Appearance.Options.UseBackColor = true;
            this.btn_login.Appearance.Options.UseBorderColor = true;
            this.btn_login.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btn_login.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.btn_login.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.btn_login.AppearanceHovered.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold);
            this.btn_login.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btn_login.AppearanceHovered.Options.UseBackColor = true;
            this.btn_login.AppearanceHovered.Options.UseBorderColor = true;
            this.btn_login.AppearanceHovered.Options.UseFont = true;
            this.btn_login.AppearanceHovered.Options.UseForeColor = true;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Location = new System.Drawing.Point(16, 287);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(339, 54);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pan_pass
            // 
            this.pan_pass.BackColor = System.Drawing.Color.Gray;
            this.pan_pass.Location = new System.Drawing.Point(19, 227);
            this.pan_pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_pass.Name = "pan_pass";
            this.pan_pass.Size = new System.Drawing.Size(336, 2);
            this.pan_pass.TabIndex = 3;
            // 
            // pan_user
            // 
            this.pan_user.BackColor = System.Drawing.Color.Gray;
            this.pan_user.Location = new System.Drawing.Point(20, 167);
            this.pan_user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_user.Name = "pan_user";
            this.pan_user.Size = new System.Drawing.Size(336, 2);
            this.pan_user.TabIndex = 3;
            // 
            // pan_database
            // 
            this.pan_database.BackColor = System.Drawing.Color.Gray;
            this.pan_database.Location = new System.Drawing.Point(19, 111);
            this.pan_database.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_database.Name = "pan_database";
            this.pan_database.Size = new System.Drawing.Size(336, 2);
            this.pan_database.TabIndex = 3;
            this.pan_database.Paint += new System.Windows.Forms.PaintEventHandler(this.pan_database_Paint);
            // 
            // pic_pass
            // 
            this.pic_pass.EditValue = global::VietSoftHRM.Properties.Resources.icon_pass;
            this.pic_pass.Location = new System.Drawing.Point(16, 191);
            this.pic_pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_pass.Name = "pic_pass";
            this.pic_pass.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pic_pass.Properties.Appearance.Options.UseBackColor = true;
            this.pic_pass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pic_pass.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_pass.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_pass.Size = new System.Drawing.Size(31, 38);
            this.pic_pass.TabIndex = 2;
            // 
            // pic_user
            // 
            this.pic_user.EditValue = global::VietSoftHRM.Properties.Resources.icon_user;
            this.pic_user.Location = new System.Drawing.Point(16, 131);
            this.pic_user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_user.Name = "pic_user";
            this.pic_user.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pic_user.Properties.Appearance.Options.UseBackColor = true;
            this.pic_user.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pic_user.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_user.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_user.Size = new System.Drawing.Size(31, 38);
            this.pic_user.TabIndex = 2;
            this.pic_user.EditValueChanged += new System.EventHandler(this.pic_user_EditValueChanged);
            // 
            // pic_database
            // 
            this.pic_database.EditValue = global::VietSoftHRM.Properties.Resources.icon_data;
            this.pic_database.Location = new System.Drawing.Point(16, 74);
            this.pic_database.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_database.Name = "pic_database";
            this.pic_database.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pic_database.Properties.Appearance.Options.UseBackColor = true;
            this.pic_database.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pic_database.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_database.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_database.Size = new System.Drawing.Size(31, 38);
            this.pic_database.TabIndex = 2;
            this.pic_database.EditValueChanged += new System.EventHandler(this.pic_database_EditValueChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.EditValue = "Password";
            this.txt_pass.Location = new System.Drawing.Point(44, 200);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_pass.Properties.Appearance.Options.UseBackColor = true;
            this.txt_pass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_pass.Properties.PasswordChar = '•';
            this.txt_pass.Size = new System.Drawing.Size(311, 24);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.Click += new System.EventHandler(this.Txt_pass_Click);
            this.txt_pass.Validated += new System.EventHandler(this.Txt_pass_Validated);
            // 
            // txt_user
            // 
            this.txt_user.EditValue = "Username";
            this.txt_user.Location = new System.Drawing.Point(44, 140);
            this.txt_user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_user.Name = "txt_user";
            this.txt_user.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_user.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txt_user.Properties.Appearance.Options.UseBackColor = true;
            this.txt_user.Properties.Appearance.Options.UseForeColor = true;
            this.txt_user.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_user.Size = new System.Drawing.Size(311, 24);
            this.txt_user.TabIndex = 1;
            this.txt_user.Click += new System.EventHandler(this.Txt_user_Click);
            this.txt_user.Validated += new System.EventHandler(this.Txt_user_Validated);
            // 
            // labelControl1
            // 
            this.labelControl1.AllowHtmlString = true;
            this.labelControl1.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.labelControl1.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl1.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.AutoEllipsis = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(371, 63);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Sign Up";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 420);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_database.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_database.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_user;
        private DevExpress.XtraEditors.TextEdit txt_pass;
        private System.Windows.Forms.Panel pan_database;
        private DevExpress.XtraEditors.SimpleButton btn_login;
        private DevExpress.XtraEditors.PictureEdit pic_database;
        private System.Windows.Forms.CheckBox che_Repass;
        private System.Windows.Forms.CheckBox che_Reuser;
        private System.Windows.Forms.Panel pan_user;
        private System.Windows.Forms.Panel pan_pass;
        private DevExpress.XtraEditors.SimpleButton btn_Register;
        private DevExpress.XtraEditors.PictureEdit pic_pass;
        private DevExpress.XtraEditors.PictureEdit pic_user;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private DevExpress.XtraEditors.LookUpEdit cbo_database;
    }
}