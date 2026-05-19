namespace GamingCafeAsset_InventorySystem
{
    partial class AddUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            this.lbltitle = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.lblPasswordHint = new System.Windows.Forms.Label();
            this.btnShowpass = new System.Windows.Forms.Button();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnHidepass = new System.Windows.Forms.Button();
            this.pnlStyleRight = new System.Windows.Forms.Panel();
            this.pnlStyleLeft = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.Color.Transparent;
            this.lbltitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbltitle.Location = new System.Drawing.Point(40, 218);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(373, 48);
            this.lbltitle.TabIndex = 2;
            this.lbltitle.Text = "USER REGISTRATION";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(95, 6);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(250, 241);
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // lblRegistration
            // 
            this.lblRegistration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistration.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistration.ForeColor = System.Drawing.Color.LightGray;
            this.lblRegistration.Location = new System.Drawing.Point(39, 257);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(377, 38);
            this.lblRegistration.TabIndex = 3;
            this.lblRegistration.Text = "Create a new system account";
            this.lblRegistration.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.lbltitle);
            this.pnlHeader.Controls.Add(this.pbLogo);
            this.pnlHeader.Controls.Add(this.lblRegistration);
            this.pnlHeader.Location = new System.Drawing.Point(350, 27);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(488, 318);
            this.pnlHeader.TabIndex = 8;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUser.Location = new System.Drawing.Point(14, 17);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(188, 48);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Username";
            // 
            // pnlData
            // 
            this.pnlData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.pnlData.Controls.Add(this.lblPasswordHint);
            this.pnlData.Controls.Add(this.btnShowpass);
            this.pnlData.Controls.Add(this.dtpDob);
            this.pnlData.Controls.Add(this.btnReset);
            this.pnlData.Controls.Add(this.rbtnInactive);
            this.pnlData.Controls.Add(this.rbtnActive);
            this.pnlData.Controls.Add(this.btnCancel);
            this.pnlData.Controls.Add(this.btnCreate);
            this.pnlData.Controls.Add(this.lblStatus);
            this.pnlData.Controls.Add(this.txtAddress);
            this.pnlData.Controls.Add(this.lblAddress);
            this.pnlData.Controls.Add(this.txtPhoneNum);
            this.pnlData.Controls.Add(this.lblPhoneNum);
            this.pnlData.Controls.Add(this.txtEmail);
            this.pnlData.Controls.Add(this.lblEmail);
            this.pnlData.Controls.Add(this.cbRoles);
            this.pnlData.Controls.Add(this.lblRole);
            this.pnlData.Controls.Add(this.lblDob);
            this.pnlData.Controls.Add(this.txtLastName);
            this.pnlData.Controls.Add(this.txtFirstName);
            this.pnlData.Controls.Add(this.lblLastName);
            this.pnlData.Controls.Add(this.lblFirstName);
            this.pnlData.Controls.Add(this.txtUser);
            this.pnlData.Controls.Add(this.lblPass);
            this.pnlData.Controls.Add(this.lblUser);
            this.pnlData.Controls.Add(this.pnlFooter);
            this.pnlData.Controls.Add(this.txtPass);
            this.pnlData.Controls.Add(this.btnHidepass);
            this.pnlData.Location = new System.Drawing.Point(75, 359);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(1013, 737);
            this.pnlData.TabIndex = 10;
            // 
            // lblPasswordHint
            // 
            this.lblPasswordHint.AutoSize = true;
            this.lblPasswordHint.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPasswordHint.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPasswordHint.Location = new System.Drawing.Point(205, 140);
            this.lblPasswordHint.Name = "lblPasswordHint";
            this.lblPasswordHint.Size = new System.Drawing.Size(164, 21);
            this.lblPasswordHint.TabIndex = 13;
            this.lblPasswordHint.Text = "Password Hint Label";
            // 
            // btnShowpass
            // 
            this.btnShowpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnShowpass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowpass.BackgroundImage")));
            this.btnShowpass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowpass.FlatAppearance.BorderSize = 0;
            this.btnShowpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowpass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowpass.Location = new System.Drawing.Point(940, 91);
            this.btnShowpass.Name = "btnShowpass";
            this.btnShowpass.Size = new System.Drawing.Size(39, 39);
            this.btnShowpass.TabIndex = 12;
            this.btnShowpass.UseVisualStyleBackColor = false;
            this.btnShowpass.Click += new System.EventHandler(this.btnShowpass_Click);
            // 
            // dtpDob
            // 
            this.dtpDob.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDob.CalendarForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtpDob.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.dtpDob.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.dtpDob.CalendarTitleForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtpDob.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dtpDob.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.dtpDob.Location = new System.Drawing.Point(253, 283);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(250, 29);
            this.dtpDob.TabIndex = 18;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.Location = new System.Drawing.Point(419, 592);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(267, 72);
            this.btnReset.TabIndex = 36;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.BackColor = System.Drawing.Color.Transparent;
            this.rbtnInactive.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.rbtnInactive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rbtnInactive.Location = new System.Drawing.Point(299, 333);
            this.rbtnInactive.Name = "rbtnInactive";
            this.rbtnInactive.Size = new System.Drawing.Size(154, 45);
            this.rbtnInactive.TabIndex = 30;
            this.rbtnInactive.TabStop = true;
            this.rbtnInactive.Text = "Inactive";
            this.rbtnInactive.UseVisualStyleBackColor = false;
            // 
            // rbtnActive
            // 
            this.rbtnActive.AutoSize = true;
            this.rbtnActive.BackColor = System.Drawing.Color.Transparent;
            this.rbtnActive.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.rbtnActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(120)))));
            this.rbtnActive.Location = new System.Drawing.Point(150, 333);
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.Size = new System.Drawing.Size(131, 45);
            this.rbtnActive.TabIndex = 28;
            this.rbtnActive.TabStop = true;
            this.rbtnActive.Text = "Active";
            this.rbtnActive.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(701, 592);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(289, 72);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(22, 592);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(382, 72);
            this.btnCreate.TabIndex = 31;
            this.btnCreate.Text = "CREATE ACCOUNT";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblStatus.Location = new System.Drawing.Point(14, 330);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(124, 48);
            this.lblStatus.TabIndex = 29;
            this.lblStatus.Text = "Status";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtAddress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtAddress.Location = new System.Drawing.Point(175, 524);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(815, 54);
            this.txtAddress.TabIndex = 27;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddress.Location = new System.Drawing.Point(15, 523);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(154, 48);
            this.lblAddress.TabIndex = 26;
            this.lblAddress.Text = "Address";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.txtPhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNum.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtPhoneNum.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPhoneNum.Location = new System.Drawing.Point(296, 459);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(694, 55);
            this.txtPhoneNum.TabIndex = 25;
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPhoneNum.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPhoneNum.Location = new System.Drawing.Point(15, 458);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(275, 48);
            this.lblPhoneNum.TabIndex = 24;
            this.lblPhoneNum.Text = "Phone Number";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Location = new System.Drawing.Point(136, 395);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(854, 55);
            this.txtEmail.TabIndex = 23;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmail.Location = new System.Drawing.Point(15, 395);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(111, 48);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email";
            // 
            // cbRoles
            // 
            this.cbRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.cbRoles.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbRoles.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoles.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Staff"});
            this.cbRoles.Location = new System.Drawing.Point(702, 293);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(288, 36);
            this.cbRoles.TabIndex = 21;
            this.cbRoles.SelectedIndexChanged += new System.EventHandler(this.cbRoles_SelectedIndexChanged);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblRole.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRole.Location = new System.Drawing.Point(513, 283);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(179, 48);
            this.lblRole.TabIndex = 20;
            this.lblRole.Text = "User Role";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblDob.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDob.Location = new System.Drawing.Point(15, 270);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(238, 48);
            this.lblDob.TabIndex = 19;
            this.lblDob.Text = "Date of Birth";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtLastName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastName.Location = new System.Drawing.Point(521, 212);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(469, 55);
            this.txtLastName.TabIndex = 17;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtFirstName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFirstName.Location = new System.Drawing.Point(22, 212);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(481, 55);
            this.txtFirstName.TabIndex = 16;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLastName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLastName.Location = new System.Drawing.Point(513, 161);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(196, 48);
            this.lblLastName.TabIndex = 15;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFirstName.Location = new System.Drawing.Point(15, 161);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(202, 48);
            this.lblFirstName.TabIndex = 14;
            this.lblFirstName.Text = "First Name";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUser.Location = new System.Drawing.Point(208, 20);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(782, 55);
            this.txtUser.TabIndex = 8;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPass.Location = new System.Drawing.Point(15, 77);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(179, 48);
            this.lblPass.TabIndex = 7;
            this.lblPass.Text = "Password";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.pnlFooter.Controls.Add(this.lblMessage);
            this.pnlFooter.Location = new System.Drawing.Point(0, 688);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1013, 49);
            this.pnlFooter.TabIndex = 35;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(209)))));
            this.lblMessage.Location = new System.Drawing.Point(217, 6);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(569, 28);
            this.lblMessage.TabIndex = 34;
            this.lblMessage.Text = "User records can be managed later from the Users module.";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPass.Location = new System.Drawing.Point(208, 82);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(782, 55);
            this.txtPass.TabIndex = 9;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // btnHidepass
            // 
            this.btnHidepass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnHidepass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHidepass.BackgroundImage")));
            this.btnHidepass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHidepass.FlatAppearance.BorderSize = 0;
            this.btnHidepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidepass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHidepass.Location = new System.Drawing.Point(940, 91);
            this.btnHidepass.Name = "btnHidepass";
            this.btnHidepass.Size = new System.Drawing.Size(39, 39);
            this.btnHidepass.TabIndex = 13;
            this.btnHidepass.UseVisualStyleBackColor = false;
            this.btnHidepass.Click += new System.EventHandler(this.btnHidepass_Click);
            // 
            // pnlStyleRight
            // 
            this.pnlStyleRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.pnlStyleRight.Location = new System.Drawing.Point(1149, -22);
            this.pnlStyleRight.Name = "pnlStyleRight";
            this.pnlStyleRight.Size = new System.Drawing.Size(65, 1258);
            this.pnlStyleRight.TabIndex = 11;
            // 
            // pnlStyleLeft
            // 
            this.pnlStyleLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.pnlStyleLeft.Location = new System.Drawing.Point(-31, -21);
            this.pnlStyleLeft.Name = "pnlStyleLeft";
            this.pnlStyleLeft.Size = new System.Drawing.Size(54, 1274);
            this.pnlStyleLeft.TabIndex = 12;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1173, 1151);
            this.Controls.Add(this.pnlStyleLeft);
            this.Controls.Add(this.pnlStyleRight);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlData);
            this.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddusersForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnShowpass;
        private System.Windows.Forms.Button btnHidepass;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlStyleRight;
        private System.Windows.Forms.Panel pnlStyleLeft;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblPasswordHint;
    }
}