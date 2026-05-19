namespace GamingCafeAsset_InventorySystem
{
    partial class AddDeviceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDeviceForm));
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDeviceDetails = new System.Windows.Forms.Label();
            this.lblRef = new System.Windows.Forms.Label();
            this.rbAvailable = new System.Windows.Forms.RadioButton();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.txtLocationNumber = new System.Windows.Forms.TextBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.rbOccupied = new System.Windows.Forms.RadioButton();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.lblLocatioNumber = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblBottomText = new System.Windows.Forms.Label();
            this.pnlLeftBorder = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.dgvLiveUpdate = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblSessionDetails = new System.Windows.Forms.Label();
            this.pnlDevice = new System.Windows.Forms.Panel();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.pnlRightBorder = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlLiveUpdate = new System.Windows.Forms.Panel();
            this.lblLiveUpdate = new System.Windows.Forms.Label();
            this.rbUnavailable = new System.Windows.Forms.RadioButton();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiveUpdate)).BeginInit();
            this.pnlCustomer.SuspendLayout();
            this.pnlDevice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlLogo.SuspendLayout();
            this.pnlLiveUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(187, 220);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(291, 47);
            this.txtName.TabIndex = 9;
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCategory.Location = new System.Drawing.Point(25, 333);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(154, 47);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category:";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblName.Location = new System.Drawing.Point(67, 223);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(112, 47);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDeviceDetails
            // 
            this.lblDeviceDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeviceDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.lblDeviceDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceDetails.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDeviceDetails.Location = new System.Drawing.Point(92, 206);
            this.lblDeviceDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeviceDetails.Name = "lblDeviceDetails";
            this.lblDeviceDetails.Size = new System.Drawing.Size(521, 60);
            this.lblDeviceDetails.TabIndex = 4;
            this.lblDeviceDetails.Text = "Device Details";
            this.lblDeviceDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRef
            // 
            this.lblRef.BackColor = System.Drawing.Color.Transparent;
            this.lblRef.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRef.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRef.Location = new System.Drawing.Point(80, 114);
            this.lblRef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(114, 47);
            this.lblRef.TabIndex = 16;
            this.lblRef.Text = "Ref:";
            this.lblRef.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rbAvailable
            // 
            this.rbAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAvailable.AutoSize = true;
            this.rbAvailable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAvailable.ForeColor = System.Drawing.Color.Lime;
            this.rbAvailable.Location = new System.Drawing.Point(151, 86);
            this.rbAvailable.Margin = new System.Windows.Forms.Padding(4);
            this.rbAvailable.Name = "rbAvailable";
            this.rbAvailable.Size = new System.Drawing.Size(137, 36);
            this.rbAvailable.TabIndex = 31;
            this.rbAvailable.TabStop = true;
            this.rbAvailable.Text = "Available";
            this.rbAvailable.UseVisualStyleBackColor = true;
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBookingDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingDate.Location = new System.Drawing.Point(29, 475);
            this.dtpBookingDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(457, 39);
            this.dtpBookingDate.TabIndex = 30;
            // 
            // txtLocationNumber
            // 
            this.txtLocationNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocationNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationNumber.Location = new System.Drawing.Point(316, 218);
            this.txtLocationNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocationNumber.Name = "txtLocationNumber";
            this.txtLocationNumber.Size = new System.Drawing.Size(170, 47);
            this.txtLocationNumber.TabIndex = 28;
            // 
            // lblEndTime
            // 
            this.lblEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndTime.BackColor = System.Drawing.Color.Transparent;
            this.lblEndTime.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEndTime.Location = new System.Drawing.Point(284, 241);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(166, 0);
            this.lblEndTime.TabIndex = 24;
            this.lblEndTime.Text = "End Time:";
            this.lblEndTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rbOccupied
            // 
            this.rbOccupied.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbOccupied.AutoSize = true;
            this.rbOccupied.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOccupied.ForeColor = System.Drawing.Color.Yellow;
            this.rbOccupied.Location = new System.Drawing.Point(151, 123);
            this.rbOccupied.Margin = new System.Windows.Forms.Padding(4);
            this.rbOccupied.Name = "rbOccupied";
            this.rbOccupied.Size = new System.Drawing.Size(140, 36);
            this.rbOccupied.TabIndex = 21;
            this.rbOccupied.TabStop = true;
            this.rbOccupied.Text = "Occupied";
            this.rbOccupied.UseVisualStyleBackColor = true;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.BackColor = System.Drawing.Color.Transparent;
            this.lblHourlyRate.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHourlyRate.Location = new System.Drawing.Point(28, 334);
            this.lblHourlyRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(205, 47);
            this.lblHourlyRate.TabIndex = 18;
            this.lblHourlyRate.Text = "Hourly Rate:";
            this.lblHourlyRate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLocatioNumber
            // 
            this.lblLocatioNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblLocatioNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocatioNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLocatioNumber.Location = new System.Drawing.Point(28, 218);
            this.lblLocatioNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocatioNumber.Name = "lblLocatioNumber";
            this.lblLocatioNumber.Size = new System.Drawing.Size(280, 47);
            this.lblLocatioNumber.TabIndex = 17;
            this.lblLocatioNumber.Text = "Location Number:";
            this.lblLocatioNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreate.Location = new System.Drawing.Point(3, 337);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(353, 68);
            this.btnCreate.TabIndex = 22;
            this.btnCreate.Text = "ADD DEVICE";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(701, 337);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(344, 68);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.Location = new System.Drawing.Point(361, 337);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(335, 68);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblBottomText
            // 
            this.lblBottomText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.lblBottomText.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBottomText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(209)))));
            this.lblBottomText.Location = new System.Drawing.Point(-6, 409);
            this.lblBottomText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBottomText.Name = "lblBottomText";
            this.lblBottomText.Size = new System.Drawing.Size(1058, 64);
            this.lblBottomText.TabIndex = 16;
            this.lblBottomText.Text = "Devices records can be managed later from the devices module";
            this.lblBottomText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLeftBorder
            // 
            this.pnlLeftBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.pnlLeftBorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.pnlLeftBorder.Location = new System.Drawing.Point(5, 206);
            this.pnlLeftBorder.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLeftBorder.Name = "pnlLeftBorder";
            this.pnlLeftBorder.Size = new System.Drawing.Size(76, 1003);
            this.pnlLeftBorder.TabIndex = 39;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.pnlButtons.Controls.Add(this.dgvLiveUpdate);
            this.pnlButtons.Controls.Add(this.btnCreate);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnReset);
            this.pnlButtons.Controls.Add(this.lblBottomText);
            this.pnlButtons.Location = new System.Drawing.Point(89, 736);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1049, 473);
            this.pnlButtons.TabIndex = 36;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLiveUpdate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLiveUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLiveUpdate.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLiveUpdate.EnableHeadersVisualStyles = false;
            this.dgvLiveUpdate.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.dgvLiveUpdate.Location = new System.Drawing.Point(3, 2);
            this.dgvLiveUpdate.MultiSelect = false;
            this.dgvLiveUpdate.Name = "dgvLiveUpdate";
            this.dgvLiveUpdate.ReadOnly = true;
            this.dgvLiveUpdate.RowHeadersVisible = false;
            this.dgvLiveUpdate.RowHeadersWidth = 62;
            this.dgvLiveUpdate.RowTemplate.Height = 28;
            this.dgvLiveUpdate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLiveUpdate.Size = new System.Drawing.Size(1043, 331);
            this.dgvLiveUpdate.TabIndex = 23;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblStatus.Location = new System.Drawing.Point(28, 86);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(112, 47);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtRef
            // 
            this.txtRef.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRef.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef.Location = new System.Drawing.Point(185, 114);
            this.txtRef.Margin = new System.Windows.Forms.Padding(4);
            this.txtRef.Name = "txtRef";
            this.txtRef.ReadOnly = true;
            this.txtRef.Size = new System.Drawing.Size(293, 47);
            this.txtRef.TabIndex = 17;
            this.txtRef.Text = "Auto Generated";
            this.txtRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.pnlCustomer.Controls.Add(this.cbCategory);
            this.pnlCustomer.Controls.Add(this.txtRef);
            this.pnlCustomer.Controls.Add(this.txtName);
            this.pnlCustomer.Controls.Add(this.lblCategory);
            this.pnlCustomer.Controls.Add(this.lblName);
            this.pnlCustomer.Controls.Add(this.lblRef);
            this.pnlCustomer.Location = new System.Drawing.Point(92, 206);
            this.pnlCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(521, 473);
            this.pnlCustomer.TabIndex = 37;
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "PC",
            "Console",
            "VIP"});
            this.cbCategory.Location = new System.Drawing.Point(187, 337);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(291, 40);
            this.cbCategory.TabIndex = 19;
            // 
            // lblSessionDetails
            // 
            this.lblSessionDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSessionDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.lblSessionDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionDetails.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSessionDetails.Location = new System.Drawing.Point(4, -1);
            this.lblSessionDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSessionDetails.Name = "lblSessionDetails";
            this.lblSessionDetails.Size = new System.Drawing.Size(520, 60);
            this.lblSessionDetails.TabIndex = 3;
            this.lblSessionDetails.Text = "Sessions Details";
            this.lblSessionDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDevice
            // 
            this.pnlDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.pnlDevice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDevice.Controls.Add(this.rbUnavailable);
            this.pnlDevice.Controls.Add(this.txtHourlyRate);
            this.pnlDevice.Controls.Add(this.rbAvailable);
            this.pnlDevice.Controls.Add(this.dtpBookingDate);
            this.pnlDevice.Controls.Add(this.txtLocationNumber);
            this.pnlDevice.Controls.Add(this.lblEndTime);
            this.pnlDevice.Controls.Add(this.rbOccupied);
            this.pnlDevice.Controls.Add(this.lblHourlyRate);
            this.pnlDevice.Controls.Add(this.lblLocatioNumber);
            this.pnlDevice.Controls.Add(this.lblStatus);
            this.pnlDevice.Controls.Add(this.lblSessionDetails);
            this.pnlDevice.Location = new System.Drawing.Point(616, 207);
            this.pnlDevice.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDevice.Name = "pnlDevice";
            this.pnlDevice.Size = new System.Drawing.Size(522, 472);
            this.pnlDevice.TabIndex = 34;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHourlyRate.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourlyRate.Location = new System.Drawing.Point(241, 331);
            this.txtHourlyRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(245, 47);
            this.txtHourlyRate.TabIndex = 32;
            // 
            // pnlRightBorder
            // 
            this.pnlRightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.pnlRightBorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.pnlRightBorder.Location = new System.Drawing.Point(1146, 207);
            this.pnlRightBorder.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRightBorder.Name = "pnlRightBorder";
            this.pnlRightBorder.Size = new System.Drawing.Size(72, 1002);
            this.pnlRightBorder.TabIndex = 38;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(264, 59);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(290, 48);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Gaming Stations";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.BackColor = System.Drawing.Color.Transparent;
            this.lblTag.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblTag.ForeColor = System.Drawing.Color.LightGray;
            this.lblTag.Location = new System.Drawing.Point(269, 117);
            this.lblTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(551, 30);
            this.lblTag.TabIndex = 2;
            this.lblTag.Text = "Manage PCs, consoles, peripherals, and station details.";
            this.lblTag.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Location = new System.Drawing.Point(0, -11);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(253, 225);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.pnlLogo.Controls.Add(this.lblTitle);
            this.pnlLogo.Controls.Add(this.lblTag);
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Location = new System.Drawing.Point(5, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(1213, 203);
            this.pnlLogo.TabIndex = 35;
            // 
            // pnlLiveUpdate
            // 
            this.pnlLiveUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.pnlLiveUpdate.Controls.Add(this.lblLiveUpdate);
            this.pnlLiveUpdate.Location = new System.Drawing.Point(92, 680);
            this.pnlLiveUpdate.Name = "pnlLiveUpdate";
            this.pnlLiveUpdate.Size = new System.Drawing.Size(1046, 55);
            this.pnlLiveUpdate.TabIndex = 40;
            // 
            // lblLiveUpdate
            // 
            this.lblLiveUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLiveUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.lblLiveUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiveUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLiveUpdate.Location = new System.Drawing.Point(262, 0);
            this.lblLiveUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLiveUpdate.Name = "lblLiveUpdate";
            this.lblLiveUpdate.Size = new System.Drawing.Size(513, 55);
            this.lblLiveUpdate.TabIndex = 18;
            this.lblLiveUpdate.Text = "Live Update";
            this.lblLiveUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbUnavailable
            // 
            this.rbUnavailable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbUnavailable.AutoSize = true;
            this.rbUnavailable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUnavailable.ForeColor = System.Drawing.Color.Red;
            this.rbUnavailable.Location = new System.Drawing.Point(151, 158);
            this.rbUnavailable.Margin = new System.Windows.Forms.Padding(4);
            this.rbUnavailable.Name = "rbUnavailable";
            this.rbUnavailable.Size = new System.Drawing.Size(166, 36);
            this.rbUnavailable.TabIndex = 33;
            this.rbUnavailable.TabStop = true;
            this.rbUnavailable.Text = "Unavailable";
            this.rbUnavailable.UseVisualStyleBackColor = true;
            // 
            // AddDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 1210);
            this.Controls.Add(this.lblDeviceDetails);
            this.Controls.Add(this.pnlCustomer);
            this.Controls.Add(this.pnlLiveUpdate);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlLeftBorder);
            this.Controls.Add(this.pnlDevice);
            this.Controls.Add(this.pnlRightBorder);
            this.Controls.Add(this.pnlLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddDeviceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Device";
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiveUpdate)).EndInit();
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.pnlDevice.ResumeLayout(false);
            this.pnlDevice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlLiveUpdate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDeviceDetails;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.RadioButton rbAvailable;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.TextBox txtLocationNumber;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.RadioButton rbOccupied;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label lblLocatioNumber;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblBottomText;
        private System.Windows.Forms.Panel pnlLeftBorder;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Label lblSessionDetails;
        private System.Windows.Forms.Panel pnlDevice;
        private System.Windows.Forms.Panel pnlRightBorder;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Panel pnlLiveUpdate;
        private System.Windows.Forms.Label lblLiveUpdate;
        private System.Windows.Forms.DataGridView dgvLiveUpdate;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.RadioButton rbUnavailable;
    }
}

