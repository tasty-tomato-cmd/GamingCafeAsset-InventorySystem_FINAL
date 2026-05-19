namespace GamingCafeAsset_InventorySystem
{
    partial class AddGamesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGamesForm));
            this.pnlGamesLeftBorder = new System.Windows.Forms.Panel();
            this.pnlGamesRightBorder = new System.Windows.Forms.Panel();
            this.tblpnlGamesBody = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGamesGameDetails = new System.Windows.Forms.Panel();
            this.cbDevice = new System.Windows.Forms.ComboBox();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.dgvLiveUpdate = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtGamesGameId = new System.Windows.Forms.TextBox();
            this.txtDeviceID = new System.Windows.Forms.TextBox();
            this.lblGamesDeviceId = new System.Windows.Forms.Label();
            this.lblGamesId = new System.Windows.Forms.Label();
            this.rbGamesConsole = new System.Windows.Forms.RadioButton();
            this.rbGamesPC = new System.Windows.Forms.RadioButton();
            this.rbVip = new System.Windows.Forms.RadioButton();
            this.txtGameName = new System.Windows.Forms.TextBox();
            this.lblGamesGenre = new System.Windows.Forms.Label();
            this.lblGamesPlatform = new System.Windows.Forms.Label();
            this.lblGamesName = new System.Windows.Forms.Label();
            this.lblGamesDetails = new System.Windows.Forms.Label();
            this.pnlGamesButtons = new System.Windows.Forms.Panel();
            this.lblGamesBottomText = new System.Windows.Forms.Label();
            this.btnGamesCreate = new System.Windows.Forms.Button();
            this.btnGamesCancel = new System.Windows.Forms.Button();
            this.btnGamesReset = new System.Windows.Forms.Button();
            this.pnlGamesLogo = new System.Windows.Forms.Panel();
            this.lblGamesTag = new System.Windows.Forms.Label();
            this.lblGamesTitle = new System.Windows.Forms.Label();
            this.picGamesLogo = new System.Windows.Forms.PictureBox();
            this.pnlGamesGameDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiveUpdate)).BeginInit();
            this.pnlGamesButtons.SuspendLayout();
            this.pnlGamesLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGamesLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGamesLeftBorder
            // 
            this.pnlGamesLeftBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(10)))), ((int)(((byte)(113)))));
            this.pnlGamesLeftBorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.pnlGamesLeftBorder.Location = new System.Drawing.Point(-15, 180);
            this.pnlGamesLeftBorder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlGamesLeftBorder.Name = "pnlGamesLeftBorder";
            this.pnlGamesLeftBorder.Size = new System.Drawing.Size(70, 992);
            this.pnlGamesLeftBorder.TabIndex = 39;
            // 
            // pnlGamesRightBorder
            // 
            this.pnlGamesRightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(10)))), ((int)(((byte)(113)))));
            this.pnlGamesRightBorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.pnlGamesRightBorder.Location = new System.Drawing.Point(993, 181);
            this.pnlGamesRightBorder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlGamesRightBorder.Name = "pnlGamesRightBorder";
            this.pnlGamesRightBorder.Size = new System.Drawing.Size(70, 1009);
            this.pnlGamesRightBorder.TabIndex = 38;
            // 
            // tblpnlGamesBody
            // 
            this.tblpnlGamesBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblpnlGamesBody.BackColor = System.Drawing.Color.Transparent;
            this.tblpnlGamesBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tblpnlGamesBody.ColumnCount = 2;
            this.tblpnlGamesBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlGamesBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlGamesBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblpnlGamesBody.Location = new System.Drawing.Point(124, 176);
            this.tblpnlGamesBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblpnlGamesBody.Name = "tblpnlGamesBody";
            this.tblpnlGamesBody.RowCount = 1;
            this.tblpnlGamesBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlGamesBody.Size = new System.Drawing.Size(899, 882);
            this.tblpnlGamesBody.TabIndex = 33;
            // 
            // pnlGamesGameDetails
            // 
            this.pnlGamesGameDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGamesGameDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.pnlGamesGameDetails.Controls.Add(this.cbDevice);
            this.pnlGamesGameDetails.Controls.Add(this.lblDeviceName);
            this.pnlGamesGameDetails.Controls.Add(this.dgvLiveUpdate);
            this.pnlGamesGameDetails.Controls.Add(this.label1);
            this.pnlGamesGameDetails.Controls.Add(this.txtGenre);
            this.pnlGamesGameDetails.Controls.Add(this.txtGamesGameId);
            this.pnlGamesGameDetails.Controls.Add(this.txtDeviceID);
            this.pnlGamesGameDetails.Controls.Add(this.lblGamesDeviceId);
            this.pnlGamesGameDetails.Controls.Add(this.lblGamesId);
            this.pnlGamesGameDetails.Controls.Add(this.rbGamesConsole);
            this.pnlGamesGameDetails.Controls.Add(this.rbGamesPC);
            this.pnlGamesGameDetails.Controls.Add(this.rbVip);
            this.pnlGamesGameDetails.Controls.Add(this.txtGameName);
            this.pnlGamesGameDetails.Controls.Add(this.lblGamesGenre);
            this.pnlGamesGameDetails.Controls.Add(this.lblGamesPlatform);
            this.pnlGamesGameDetails.Controls.Add(this.lblGamesName);
            this.pnlGamesGameDetails.Controls.Add(this.lblGamesDetails);
            this.pnlGamesGameDetails.Location = new System.Drawing.Point(61, 180);
            this.pnlGamesGameDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlGamesGameDetails.Name = "pnlGamesGameDetails";
            this.pnlGamesGameDetails.Size = new System.Drawing.Size(926, 781);
            this.pnlGamesGameDetails.TabIndex = 37;
            // 
            // cbDevice
            // 
            this.cbDevice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.cbDevice.FormattingEnabled = true;
            this.cbDevice.Location = new System.Drawing.Point(245, 321);
            this.cbDevice.Name = "cbDevice";
            this.cbDevice.Size = new System.Drawing.Size(615, 40);
            this.cbDevice.TabIndex = 32;
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.BackColor = System.Drawing.Color.Transparent;
            this.lblDeviceName.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDeviceName.Location = new System.Drawing.Point(3, 317);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(249, 49);
            this.lblDeviceName.TabIndex = 31;
            this.lblDeviceName.Text = "Device Name:";
            this.lblDeviceName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvLiveUpdate
            // 
            this.dgvLiveUpdate.AllowUserToAddRows = false;
            this.dgvLiveUpdate.AllowUserToDeleteRows = false;
            this.dgvLiveUpdate.AllowUserToResizeColumns = false;
            this.dgvLiveUpdate.AllowUserToResizeRows = false;
            this.dgvLiveUpdate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLiveUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.dgvLiveUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLiveUpdate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLiveUpdate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLiveUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLiveUpdate.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLiveUpdate.EnableHeadersVisualStyles = false;
            this.dgvLiveUpdate.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.dgvLiveUpdate.Location = new System.Drawing.Point(2, 523);
            this.dgvLiveUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLiveUpdate.MultiSelect = false;
            this.dgvLiveUpdate.Name = "dgvLiveUpdate";
            this.dgvLiveUpdate.ReadOnly = true;
            this.dgvLiveUpdate.RowHeadersVisible = false;
            this.dgvLiveUpdate.RowHeadersWidth = 62;
            this.dgvLiveUpdate.RowTemplate.Height = 28;
            this.dgvLiveUpdate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLiveUpdate.Size = new System.Drawing.Size(921, 258);
            this.dgvLiveUpdate.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(1, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(921, 51);
            this.label1.TabIndex = 29;
            this.label1.Text = "LIVE UPDATE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGenre
            // 
            this.txtGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenre.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.Location = new System.Drawing.Point(245, 385);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGenre.Multiline = true;
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(615, 48);
            this.txtGenre.TabIndex = 28;
            // 
            // txtGamesGameId
            // 
            this.txtGamesGameId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGamesGameId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGamesGameId.Location = new System.Drawing.Point(245, 89);
            this.txtGamesGameId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGamesGameId.Multiline = true;
            this.txtGamesGameId.Name = "txtGamesGameId";
            this.txtGamesGameId.ReadOnly = true;
            this.txtGamesGameId.Size = new System.Drawing.Size(215, 50);
            this.txtGamesGameId.TabIndex = 27;
            this.txtGamesGameId.Text = "Auto Generated";
            this.txtGamesGameId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDeviceID
            // 
            this.txtDeviceID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeviceID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceID.Location = new System.Drawing.Point(638, 89);
            this.txtDeviceID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeviceID.Multiline = true;
            this.txtDeviceID.Name = "txtDeviceID";
            this.txtDeviceID.ReadOnly = true;
            this.txtDeviceID.Size = new System.Drawing.Size(222, 50);
            this.txtDeviceID.TabIndex = 26;
            this.txtDeviceID.Text = "Auto Generated";
            this.txtDeviceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGamesDeviceId
            // 
            this.lblGamesDeviceId.BackColor = System.Drawing.Color.Transparent;
            this.lblGamesDeviceId.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamesDeviceId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGamesDeviceId.Location = new System.Drawing.Point(466, 91);
            this.lblGamesDeviceId.Name = "lblGamesDeviceId";
            this.lblGamesDeviceId.Size = new System.Drawing.Size(182, 49);
            this.lblGamesDeviceId.TabIndex = 25;
            this.lblGamesDeviceId.Text = "Device ID:";
            this.lblGamesDeviceId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGamesId
            // 
            this.lblGamesId.BackColor = System.Drawing.Color.Transparent;
            this.lblGamesId.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamesId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGamesId.Location = new System.Drawing.Point(66, 91);
            this.lblGamesId.Name = "lblGamesId";
            this.lblGamesId.Size = new System.Drawing.Size(182, 49);
            this.lblGamesId.TabIndex = 24;
            this.lblGamesId.Text = "Game ID:";
            this.lblGamesId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rbGamesConsole
            // 
            this.rbGamesConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbGamesConsole.AutoSize = true;
            this.rbGamesConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(10)))), ((int)(((byte)(113)))));
            this.rbGamesConsole.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGamesConsole.ForeColor = System.Drawing.Color.AliceBlue;
            this.rbGamesConsole.Location = new System.Drawing.Point(675, 264);
            this.rbGamesConsole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbGamesConsole.Name = "rbGamesConsole";
            this.rbGamesConsole.Size = new System.Drawing.Size(165, 36);
            this.rbGamesConsole.TabIndex = 23;
            this.rbGamesConsole.TabStop = true;
            this.rbGamesConsole.Text = "🎮 Console";
            this.rbGamesConsole.UseVisualStyleBackColor = false;
            // 
            // rbGamesPC
            // 
            this.rbGamesPC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbGamesPC.AutoSize = true;
            this.rbGamesPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(10)))), ((int)(((byte)(113)))));
            this.rbGamesPC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGamesPC.ForeColor = System.Drawing.Color.AliceBlue;
            this.rbGamesPC.Location = new System.Drawing.Point(472, 264);
            this.rbGamesPC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbGamesPC.Name = "rbGamesPC";
            this.rbGamesPC.Size = new System.Drawing.Size(108, 36);
            this.rbGamesPC.TabIndex = 22;
            this.rbGamesPC.TabStop = true;
            this.rbGamesPC.Text = "💻 PC";
            this.rbGamesPC.UseVisualStyleBackColor = false;
            // 
            // rbVip
            // 
            this.rbVip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbVip.AutoSize = true;
            this.rbVip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(10)))), ((int)(((byte)(113)))));
            this.rbVip.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVip.ForeColor = System.Drawing.Color.AliceBlue;
            this.rbVip.Location = new System.Drawing.Point(291, 264);
            this.rbVip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbVip.Name = "rbVip";
            this.rbVip.Size = new System.Drawing.Size(75, 36);
            this.rbVip.TabIndex = 21;
            this.rbVip.TabStop = true;
            this.rbVip.Text = "VIP";
            this.rbVip.UseVisualStyleBackColor = false;
            // 
            // txtGameName
            // 
            this.txtGameName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameName.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGameName.Location = new System.Drawing.Point(245, 175);
            this.txtGameName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGameName.Multiline = true;
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.Size = new System.Drawing.Size(615, 50);
            this.txtGameName.TabIndex = 11;
            // 
            // lblGamesGenre
            // 
            this.lblGamesGenre.BackColor = System.Drawing.Color.Transparent;
            this.lblGamesGenre.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamesGenre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGamesGenre.Location = new System.Drawing.Point(118, 385);
            this.lblGamesGenre.Name = "lblGamesGenre";
            this.lblGamesGenre.Size = new System.Drawing.Size(108, 49);
            this.lblGamesGenre.TabIndex = 7;
            this.lblGamesGenre.Text = "Genre:";
            this.lblGamesGenre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGamesPlatform
            // 
            this.lblGamesPlatform.BackColor = System.Drawing.Color.Transparent;
            this.lblGamesPlatform.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamesPlatform.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGamesPlatform.Location = new System.Drawing.Point(56, 259);
            this.lblGamesPlatform.Name = "lblGamesPlatform";
            this.lblGamesPlatform.Size = new System.Drawing.Size(201, 49);
            this.lblGamesPlatform.TabIndex = 6;
            this.lblGamesPlatform.Text = "Platform:";
            this.lblGamesPlatform.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGamesName
            // 
            this.lblGamesName.BackColor = System.Drawing.Color.Transparent;
            this.lblGamesName.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamesName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGamesName.Location = new System.Drawing.Point(18, 175);
            this.lblGamesName.Name = "lblGamesName";
            this.lblGamesName.Size = new System.Drawing.Size(221, 49);
            this.lblGamesName.TabIndex = 5;
            this.lblGamesName.Text = "Game Name:";
            this.lblGamesName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGamesDetails
            // 
            this.lblGamesDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGamesDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.lblGamesDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamesDetails.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGamesDetails.Location = new System.Drawing.Point(1, 1);
            this.lblGamesDetails.Name = "lblGamesDetails";
            this.lblGamesDetails.Size = new System.Drawing.Size(921, 62);
            this.lblGamesDetails.TabIndex = 4;
            this.lblGamesDetails.Text = "🎮 GAME DETAILS";
            this.lblGamesDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGamesButtons
            // 
            this.pnlGamesButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.pnlGamesButtons.Controls.Add(this.lblGamesBottomText);
            this.pnlGamesButtons.Controls.Add(this.btnGamesCreate);
            this.pnlGamesButtons.Controls.Add(this.btnGamesCancel);
            this.pnlGamesButtons.Controls.Add(this.btnGamesReset);
            this.pnlGamesButtons.Location = new System.Drawing.Point(57, 963);
            this.pnlGamesButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlGamesButtons.Name = "pnlGamesButtons";
            this.pnlGamesButtons.Size = new System.Drawing.Size(928, 238);
            this.pnlGamesButtons.TabIndex = 36;
            // 
            // lblGamesBottomText
            // 
            this.lblGamesBottomText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.lblGamesBottomText.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamesBottomText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(209)))));
            this.lblGamesBottomText.Location = new System.Drawing.Point(6, 76);
            this.lblGamesBottomText.Name = "lblGamesBottomText";
            this.lblGamesBottomText.Size = new System.Drawing.Size(922, 62);
            this.lblGamesBottomText.TabIndex = 16;
            this.lblGamesBottomText.Text = "Game records can be managed later from the game module";
            this.lblGamesBottomText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGamesCreate
            // 
            this.btnGamesCreate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGamesCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(23)))), ((int)(((byte)(235)))));
            this.btnGamesCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGamesCreate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGamesCreate.Location = new System.Drawing.Point(5, 4);
            this.btnGamesCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGamesCreate.Name = "btnGamesCreate";
            this.btnGamesCreate.Size = new System.Drawing.Size(313, 68);
            this.btnGamesCreate.TabIndex = 22;
            this.btnGamesCreate.Text = "ADD GAME";
            this.btnGamesCreate.UseVisualStyleBackColor = false;
            this.btnGamesCreate.Click += new System.EventHandler(this.btnGamesCreate_Click);
            // 
            // btnGamesCancel
            // 
            this.btnGamesCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGamesCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(10)))), ((int)(((byte)(113)))));
            this.btnGamesCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGamesCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGamesCancel.Location = new System.Drawing.Point(629, 4);
            this.btnGamesCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGamesCancel.Name = "btnGamesCancel";
            this.btnGamesCancel.Size = new System.Drawing.Size(296, 68);
            this.btnGamesCancel.TabIndex = 21;
            this.btnGamesCancel.Text = "CANCEL";
            this.btnGamesCancel.UseVisualStyleBackColor = false;
            this.btnGamesCancel.Click += new System.EventHandler(this.btnGamesCancel_Click);
            // 
            // btnGamesReset
            // 
            this.btnGamesReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGamesReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnGamesReset.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGamesReset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGamesReset.Location = new System.Drawing.Point(325, 4);
            this.btnGamesReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGamesReset.Name = "btnGamesReset";
            this.btnGamesReset.Size = new System.Drawing.Size(297, 68);
            this.btnGamesReset.TabIndex = 20;
            this.btnGamesReset.Text = "RESET";
            this.btnGamesReset.UseVisualStyleBackColor = false;
            this.btnGamesReset.Click += new System.EventHandler(this.btnGamesReset_Click);
            // 
            // pnlGamesLogo
            // 
            this.pnlGamesLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGamesLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.pnlGamesLogo.Controls.Add(this.lblGamesTag);
            this.pnlGamesLogo.Controls.Add(this.lblGamesTitle);
            this.pnlGamesLogo.Controls.Add(this.picGamesLogo);
            this.pnlGamesLogo.Location = new System.Drawing.Point(-15, -35);
            this.pnlGamesLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlGamesLogo.Name = "pnlGamesLogo";
            this.pnlGamesLogo.Size = new System.Drawing.Size(1078, 212);
            this.pnlGamesLogo.TabIndex = 34;
            // 
            // lblGamesTag
            // 
            this.lblGamesTag.AutoSize = true;
            this.lblGamesTag.BackColor = System.Drawing.Color.Transparent;
            this.lblGamesTag.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamesTag.ForeColor = System.Drawing.Color.LightGray;
            this.lblGamesTag.Location = new System.Drawing.Point(266, 105);
            this.lblGamesTag.Name = "lblGamesTag";
            this.lblGamesTag.Size = new System.Drawing.Size(509, 32);
            this.lblGamesTag.TabIndex = 2;
            this.lblGamesTag.Text = "Add and organise available games for players";
            this.lblGamesTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGamesTitle
            // 
            this.lblGamesTitle.AutoSize = true;
            this.lblGamesTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGamesTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamesTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGamesTitle.Location = new System.Drawing.Point(254, 59);
            this.lblGamesTitle.Name = "lblGamesTitle";
            this.lblGamesTitle.Size = new System.Drawing.Size(772, 46);
            this.lblGamesTitle.TabIndex = 1;
            this.lblGamesTitle.Text = " 🎮 GAME MANAGEMENT                                      ";
            this.lblGamesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picGamesLogo
            // 
            this.picGamesLogo.BackColor = System.Drawing.Color.Transparent;
            this.picGamesLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picGamesLogo.BackgroundImage")));
            this.picGamesLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picGamesLogo.Location = new System.Drawing.Point(16, 16);
            this.picGamesLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picGamesLogo.Name = "picGamesLogo";
            this.picGamesLogo.Size = new System.Drawing.Size(202, 196);
            this.picGamesLogo.TabIndex = 0;
            this.picGamesLogo.TabStop = false;
            // 
            // AddGamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 1161);
            this.Controls.Add(this.pnlGamesButtons);
            this.Controls.Add(this.pnlGamesLeftBorder);
            this.Controls.Add(this.pnlGamesRightBorder);
            this.Controls.Add(this.pnlGamesLogo);
            this.Controls.Add(this.pnlGamesGameDetails);
            this.Controls.Add(this.tblpnlGamesBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddGamesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddGamesForm";
            this.pnlGamesGameDetails.ResumeLayout(false);
            this.pnlGamesGameDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiveUpdate)).EndInit();
            this.pnlGamesButtons.ResumeLayout(false);
            this.pnlGamesLogo.ResumeLayout(false);
            this.pnlGamesLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGamesLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGamesBottomText;
        private System.Windows.Forms.Button btnGamesCreate;
        private System.Windows.Forms.Button btnGamesReset;
        private System.Windows.Forms.Panel pnlGamesButtons;
        private System.Windows.Forms.Button btnGamesCancel;
        private System.Windows.Forms.Label lblGamesTag;
        private System.Windows.Forms.Label lblGamesTitle;
        private System.Windows.Forms.PictureBox picGamesLogo;
        private System.Windows.Forms.Panel pnlGamesLeftBorder;
        private System.Windows.Forms.Panel pnlGamesRightBorder;
        private System.Windows.Forms.Panel pnlGamesLogo;
        private System.Windows.Forms.Panel pnlGamesGameDetails;
        private System.Windows.Forms.TextBox txtGameName;
        private System.Windows.Forms.Label lblGamesGenre;
        private System.Windows.Forms.Label lblGamesPlatform;
        private System.Windows.Forms.Label lblGamesName;
        private System.Windows.Forms.Label lblGamesDetails;
        private System.Windows.Forms.TableLayoutPanel tblpnlGamesBody;
        private System.Windows.Forms.RadioButton rbGamesConsole;
        private System.Windows.Forms.RadioButton rbGamesPC;
        private System.Windows.Forms.RadioButton rbVip;
        private System.Windows.Forms.Label lblGamesDeviceId;
        private System.Windows.Forms.Label lblGamesId;
        private System.Windows.Forms.TextBox txtDeviceID;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtGamesGameId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLiveUpdate;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.ComboBox cbDevice;
    }
}