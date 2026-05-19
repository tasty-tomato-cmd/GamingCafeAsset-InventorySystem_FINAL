namespace GamingCafeAsset_InventorySystem
{
    partial class AddBookingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookingForm));
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlDevice = new System.Windows.Forms.Panel();
            this.cbDevice = new System.Windows.Forms.ComboBox();
            this.lblDeviceNAME = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.rbCompleted = new System.Windows.Forms.RadioButton();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.txtTotalHours = new System.Windows.Forms.TextBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.rbCancel = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDevice = new System.Windows.Forms.Label();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblBottomText = new System.Windows.Forms.Label();
            this.pnlRightBorder = new System.Windows.Forms.Panel();
            this.pnlLeftBorder = new System.Windows.Forms.Panel();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlDevice.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.pnlLogo.Controls.Add(this.lblTitle);
            this.pnlLogo.Controls.Add(this.lblTag);
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Location = new System.Drawing.Point(-16, -2);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(1183, 306);
            this.pnlLogo.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(228, 43);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(795, 46);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = " Session Management and Device Allocation Panel";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.BackColor = System.Drawing.Color.Transparent;
            this.lblTag.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTag.ForeColor = System.Drawing.Color.LightGray;
            this.lblTag.Location = new System.Drawing.Point(253, 89);
            this.lblTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(197, 32);
            this.lblTag.TabIndex = 2;
            this.lblTag.Text = "Manage sessions";
            this.lblTag.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Location = new System.Drawing.Point(29, 2);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(216, 188);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlDevice
            // 
            this.pnlDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.pnlDevice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDevice.Controls.Add(this.cbDevice);
            this.pnlDevice.Controls.Add(this.lblDeviceNAME);
            this.pnlDevice.Controls.Add(this.dtpEndTime);
            this.pnlDevice.Controls.Add(this.dtpStartTime);
            this.pnlDevice.Controls.Add(this.rbCompleted);
            this.pnlDevice.Controls.Add(this.dtpBookingDate);
            this.pnlDevice.Controls.Add(this.lblBookingDate);
            this.pnlDevice.Controls.Add(this.txtTotalHours);
            this.pnlDevice.Controls.Add(this.lblEndTime);
            this.pnlDevice.Controls.Add(this.rbCancel);
            this.pnlDevice.Controls.Add(this.rbActive);
            this.pnlDevice.Controls.Add(this.lblHours);
            this.pnlDevice.Controls.Add(this.lblStartTime);
            this.pnlDevice.Controls.Add(this.lblStatus);
            this.pnlDevice.Controls.Add(this.lblDevice);
            this.pnlDevice.Location = new System.Drawing.Point(564, 221);
            this.pnlDevice.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDevice.Name = "pnlDevice";
            this.pnlDevice.Size = new System.Drawing.Size(509, 594);
            this.pnlDevice.TabIndex = 1;
            // 
            // cbDevice
            // 
            this.cbDevice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.cbDevice.FormattingEnabled = true;
            this.cbDevice.Location = new System.Drawing.Point(227, 410);
            this.cbDevice.Name = "cbDevice";
            this.cbDevice.Size = new System.Drawing.Size(245, 40);
            this.cbDevice.TabIndex = 35;
            // 
            // lblDeviceNAME
            // 
            this.lblDeviceNAME.BackColor = System.Drawing.Color.Transparent;
            this.lblDeviceNAME.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceNAME.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDeviceNAME.Location = new System.Drawing.Point(6, 403);
            this.lblDeviceNAME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeviceNAME.Name = "lblDeviceNAME";
            this.lblDeviceNAME.Size = new System.Drawing.Size(214, 47);
            this.lblDeviceNAME.TabIndex = 34;
            this.lblDeviceNAME.Text = "Device Name:";
            this.lblDeviceNAME.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEndTime.CustomFormat = "hh:mm tt";
            this.dtpEndTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(258, 271);
            this.dtpEndTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(215, 39);
            this.dtpEndTime.TabIndex = 33;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartTime.CustomFormat = "hh:mm tt";
            this.dtpStartTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(36, 271);
            this.dtpStartTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(215, 39);
            this.dtpStartTime.TabIndex = 32;
            // 
            // rbCompleted
            // 
            this.rbCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbCompleted.AutoSize = true;
            this.rbCompleted.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCompleted.ForeColor = System.Drawing.Color.Lime;
            this.rbCompleted.Location = new System.Drawing.Point(139, 71);
            this.rbCompleted.Margin = new System.Windows.Forms.Padding(4);
            this.rbCompleted.Name = "rbCompleted";
            this.rbCompleted.Size = new System.Drawing.Size(158, 36);
            this.rbCompleted.TabIndex = 31;
            this.rbCompleted.TabStop = true;
            this.rbCompleted.Text = "Completed";
            this.rbCompleted.UseVisualStyleBackColor = true;
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBookingDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingDate.Location = new System.Drawing.Point(28, 518);
            this.dtpBookingDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(444, 39);
            this.dtpBookingDate.TabIndex = 30;
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.BackColor = System.Drawing.Color.Transparent;
            this.lblBookingDate.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBookingDate.Location = new System.Drawing.Point(-8, 467);
            this.lblBookingDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(270, 47);
            this.lblBookingDate.TabIndex = 29;
            this.lblBookingDate.Text = "Booking Date:";
            this.lblBookingDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTotalHours
            // 
            this.txtTotalHours.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalHours.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalHours.Location = new System.Drawing.Point(227, 332);
            this.txtTotalHours.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalHours.Name = "txtTotalHours";
            this.txtTotalHours.ReadOnly = true;
            this.txtTotalHours.Size = new System.Drawing.Size(246, 47);
            this.txtTotalHours.TabIndex = 28;
            // 
            // lblEndTime
            // 
            this.lblEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndTime.BackColor = System.Drawing.Color.Transparent;
            this.lblEndTime.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEndTime.Location = new System.Drawing.Point(270, 218);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(166, 109);
            this.lblEndTime.TabIndex = 24;
            this.lblEndTime.Text = "End Time:";
            this.lblEndTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rbCancel
            // 
            this.rbCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbCancel.AutoSize = true;
            this.rbCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCancel.ForeColor = System.Drawing.Color.Red;
            this.rbCancel.Location = new System.Drawing.Point(139, 156);
            this.rbCancel.Margin = new System.Windows.Forms.Padding(4);
            this.rbCancel.Name = "rbCancel";
            this.rbCancel.Size = new System.Drawing.Size(144, 36);
            this.rbCancel.TabIndex = 21;
            this.rbCancel.TabStop = true;
            this.rbCancel.Text = "Cancelled";
            this.rbCancel.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            this.rbActive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbActive.AutoSize = true;
            this.rbActive.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActive.ForeColor = System.Drawing.Color.Yellow;
            this.rbActive.Location = new System.Drawing.Point(139, 112);
            this.rbActive.Margin = new System.Windows.Forms.Padding(4);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(106, 36);
            this.rbActive.TabIndex = 20;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // lblHours
            // 
            this.lblHours.BackColor = System.Drawing.Color.Transparent;
            this.lblHours.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHours.Location = new System.Drawing.Point(29, 332);
            this.lblHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(184, 47);
            this.lblHours.TabIndex = 18;
            this.lblHours.Text = "Total Hours:";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStartTime
            // 
            this.lblStartTime.BackColor = System.Drawing.Color.Transparent;
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblStartTime.Location = new System.Drawing.Point(27, 219);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(166, 47);
            this.lblStartTime.TabIndex = 17;
            this.lblStartTime.Text = "Start Time:";
            this.lblStartTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblStatus.Location = new System.Drawing.Point(29, 66);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(112, 47);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDevice
            // 
            this.lblDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.lblDevice.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDevice.Location = new System.Drawing.Point(3, -1);
            this.lblDevice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(507, 48);
            this.lblDevice.TabIndex = 3;
            this.lblDevice.Text = "Sessions Details";
            this.lblDevice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.pnlCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustomer.Controls.Add(this.txtBookingID);
            this.pnlCustomer.Controls.Add(this.txtNotes);
            this.pnlCustomer.Controls.Add(this.lblNotes);
            this.pnlCustomer.Controls.Add(this.lblCustomer);
            this.pnlCustomer.Controls.Add(this.txtPhone);
            this.pnlCustomer.Controls.Add(this.txtName);
            this.pnlCustomer.Controls.Add(this.lblPhone);
            this.pnlCustomer.Controls.Add(this.lblName);
            this.pnlCustomer.Controls.Add(this.lblBookingID);
            this.pnlCustomer.Location = new System.Drawing.Point(83, 221);
            this.pnlCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(483, 595);
            this.pnlCustomer.TabIndex = 3;
            // 
            // txtBookingID
            // 
            this.txtBookingID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookingID.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingID.Location = new System.Drawing.Point(141, 94);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.ReadOnly = true;
            this.txtBookingID.Size = new System.Drawing.Size(290, 47);
            this.txtBookingID.TabIndex = 17;
            this.txtBookingID.Text = "Auto Generated";
            this.txtBookingID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(141, 337);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(290, 153);
            this.txtNotes.TabIndex = 15;
            // 
            // lblNotes
            // 
            this.lblNotes.BackColor = System.Drawing.Color.Transparent;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNotes.Location = new System.Drawing.Point(21, 337);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(112, 47);
            this.lblNotes.TabIndex = 14;
            this.lblNotes.Text = "Notes:";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCustomer
            // 
            this.lblCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCustomer.Location = new System.Drawing.Point(0, 0);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(481, 49);
            this.lblCustomer.TabIndex = 4;
            this.lblCustomer.Text = "Customer Details";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(141, 241);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(290, 47);
            this.txtPhone.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(141, 166);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(290, 47);
            this.txtName.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPhone.Location = new System.Drawing.Point(15, 236);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(119, 47);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblName.Location = new System.Drawing.Point(22, 160);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(112, 47);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBookingID
            // 
            this.lblBookingID.BackColor = System.Drawing.Color.Transparent;
            this.lblBookingID.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBookingID.Location = new System.Drawing.Point(43, 94);
            this.lblBookingID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(91, 47);
            this.lblBookingID.TabIndex = 16;
            this.lblBookingID.Text = "Ref:";
            this.lblBookingID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.pnlButtons.Controls.Add(this.btnCreate);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnReset);
            this.pnlButtons.Controls.Add(this.lblBottomText);
            this.pnlButtons.Location = new System.Drawing.Point(83, 815);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(990, 136);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreate.Location = new System.Drawing.Point(7, 8);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(316, 68);
            this.btnCreate.TabIndex = 22;
            this.btnCreate.Text = "CREATE BOOKING";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(671, 8);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(316, 68);
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
            this.btnReset.Location = new System.Drawing.Point(329, 8);
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
            this.lblBottomText.Location = new System.Drawing.Point(-11, 80);
            this.lblBottomText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBottomText.Name = "lblBottomText";
            this.lblBottomText.Size = new System.Drawing.Size(1006, 56);
            this.lblBottomText.TabIndex = 16;
            this.lblBottomText.Text = "Booking records can be managed later from the booking module";
            this.lblBottomText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRightBorder
            // 
            this.pnlRightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.pnlRightBorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.pnlRightBorder.Location = new System.Drawing.Point(1079, 205);
            this.pnlRightBorder.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRightBorder.Name = "pnlRightBorder";
            this.pnlRightBorder.Size = new System.Drawing.Size(157, 808);
            this.pnlRightBorder.TabIndex = 31;
            // 
            // pnlLeftBorder
            // 
            this.pnlLeftBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.pnlLeftBorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.pnlLeftBorder.Location = new System.Drawing.Point(-16, 204);
            this.pnlLeftBorder.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLeftBorder.Name = "pnlLeftBorder";
            this.pnlLeftBorder.Size = new System.Drawing.Size(93, 881);
            this.pnlLeftBorder.TabIndex = 32;
            // 
            // AddBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1151, 951);
            this.Controls.Add(this.pnlCustomer);
            this.Controls.Add(this.pnlLeftBorder);
            this.Controls.Add(this.pnlDevice);
            this.Controls.Add(this.pnlRightBorder);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlLogo);
            this.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddBookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Booking Form";
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlDevice.ResumeLayout(false);
            this.pnlDevice.PerformLayout();
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlDevice;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.RadioButton rbCancel;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtTotalHours;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlRightBorder;
        private System.Windows.Forms.Panel pnlLeftBorder;
        private System.Windows.Forms.Label lblBottomText;
        private System.Windows.Forms.RadioButton rbCompleted;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label lblDeviceNAME;
        private System.Windows.Forms.ComboBox cbDevice;
    }
}

