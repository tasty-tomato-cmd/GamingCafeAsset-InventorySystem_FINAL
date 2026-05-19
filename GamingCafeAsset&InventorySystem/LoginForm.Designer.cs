namespace GamingCafeAsset_InventorySystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnShowpass = new System.Windows.Forms.Button();
            this.btnHidepass = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtPass.Location = new System.Drawing.Point(398, 206);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(556, 81);
            this.txtPass.TabIndex = 7;
            this.txtPass.Text = "admin123";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtUser.Location = new System.Drawing.Point(398, 119);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(556, 81);
            this.txtUser.TabIndex = 6;
            this.txtUser.Text = "admin00";
            // 
            // lblPass
            // 
            this.lblPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblPass.Location = new System.Drawing.Point(34, 206);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(358, 81);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "PASSWORD";
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblUser.Location = new System.Drawing.Point(34, 119);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(358, 81);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "USERNAME";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.btnShowpass);
            this.pnlLogin.Controls.Add(this.btnHidepass);
            this.pnlLogin.Controls.Add(this.lblTitle);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtPass);
            this.pnlLogin.Controls.Add(this.txtUser);
            this.pnlLogin.Controls.Add(this.lblUser);
            this.pnlLogin.Controls.Add(this.lblPass);
            this.pnlLogin.Location = new System.Drawing.Point(195, 250);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(992, 404);
            this.pnlLogin.TabIndex = 8;
            // 
            // btnShowpass
            // 
            this.btnShowpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.btnShowpass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowpass.BackgroundImage")));
            this.btnShowpass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowpass.FlatAppearance.BorderSize = 0;
            this.btnShowpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowpass.ForeColor = System.Drawing.Color.Black;
            this.btnShowpass.Location = new System.Drawing.Point(880, 217);
            this.btnShowpass.Name = "btnShowpass";
            this.btnShowpass.Size = new System.Drawing.Size(56, 61);
            this.btnShowpass.TabIndex = 11;
            this.btnShowpass.UseVisualStyleBackColor = false;
            this.btnShowpass.Click += new System.EventHandler(this.btnShowpass_Click);
            // 
            // btnHidepass
            // 
            this.btnHidepass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.btnHidepass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHidepass.BackgroundImage")));
            this.btnHidepass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHidepass.FlatAppearance.BorderSize = 0;
            this.btnHidepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidepass.ForeColor = System.Drawing.Color.Black;
            this.btnHidepass.Location = new System.Drawing.Point(880, 217);
            this.btnHidepass.Name = "btnHidepass";
            this.btnHidepass.Size = new System.Drawing.Size(56, 61);
            this.btnHidepass.TabIndex = 12;
            this.btnHidepass.UseVisualStyleBackColor = false;
            this.btnHidepass.Click += new System.EventHandler(this.btnHidepass_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblTitle.Location = new System.Drawing.Point(34, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(920, 81);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Gaming Café Management System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Bahnschrift", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Location = new System.Drawing.Point(34, 299);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(920, 81);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbIcon.Image")));
            this.pbIcon.Location = new System.Drawing.Point(533, 14);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(332, 257);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 9;
            this.pbIcon.TabStop = false;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picClose.BackgroundImage")));
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClose.Location = new System.Drawing.Point(1322, 623);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(48, 46);
            this.picClose.TabIndex = 10;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 681);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pbIcon);
            this.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Button btnShowpass;
        private System.Windows.Forms.Button btnHidepass;
        private System.Windows.Forms.PictureBox picClose;
    }
}