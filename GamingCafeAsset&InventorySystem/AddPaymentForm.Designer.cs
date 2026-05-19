namespace GamingCafeAsset_InventorySystem
{
    partial class AddPaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPaymentForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblBooking = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblDevice = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDeviceCharge = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblNameCust = new System.Windows.Forms.Label();
            this.cbBookingRef = new System.Windows.Forms.ComboBox();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.lblFood = new System.Windows.Forms.Label();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.rbtnPending = new System.Windows.Forms.RadioButton();
            this.rbtnRefund = new System.Windows.Forms.RadioButton();
            this.rbtnPaid = new System.Windows.Forms.RadioButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.txtBookingRef = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.dtpDop = new System.Windows.Forms.DateTimePicker();
            this.cbPaymentMethods = new System.Windows.Forms.ComboBox();
            this.pnlStyleUp = new System.Windows.Forms.Panel();
            this.pnlRIGHT = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlStyleUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(920, 607);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(442, 72);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.Color.Transparent;
            this.lbltitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbltitle.Location = new System.Drawing.Point(39, 221);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(455, 48);
            this.lbltitle.TabIndex = 2;
            this.lbltitle.Text = "PAYMENT MANAGEMENT";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(131, 3);
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
            this.lblRegistration.Location = new System.Drawing.Point(126, 269);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(255, 38);
            this.lblRegistration.TabIndex = 3;
            this.lblRegistration.Text = "Manage a payment";
            this.lblRegistration.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.lbltitle);
            this.pnlHeader.Controls.Add(this.pbLogo);
            this.pnlHeader.Controls.Add(this.lblRegistration);
            this.pnlHeader.Location = new System.Drawing.Point(463, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(488, 318);
            this.pnlHeader.TabIndex = 35;
            // 
            // lblBooking
            // 
            this.lblBooking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBooking.AutoSize = true;
            this.lblBooking.BackColor = System.Drawing.Color.Transparent;
            this.lblBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBooking.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBooking.Location = new System.Drawing.Point(177, 0);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(286, 48);
            this.lblBooking.TabIndex = 36;
            this.lblBooking.Text = "Booking Details";
            this.lblBooking.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPayment
            // 
            this.lblPayment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPayment.AutoSize = true;
            this.lblPayment.BackColor = System.Drawing.Color.Transparent;
            this.lblPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPayment.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPayment.Location = new System.Drawing.Point(908, 1);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(292, 48);
            this.lblPayment.TabIndex = 37;
            this.lblPayment.Text = "Payment Details";
            this.lblPayment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBookingID
            // 
            this.lblBookingID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.lblBookingID.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBookingID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBookingID.Location = new System.Drawing.Point(58, 73);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(215, 45);
            this.lblBookingID.TabIndex = 38;
            this.lblBookingID.Text = "Booking Ref:";
            this.lblBookingID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCustomer
            // 
            this.lblCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCustomer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCustomer.Location = new System.Drawing.Point(57, 133);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(156, 45);
            this.lblCustomer.TabIndex = 39;
            this.lblCustomer.Text = "Booking:";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDevice
            // 
            this.lblDevice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDevice.AutoSize = true;
            this.lblDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.lblDevice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblDevice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDevice.Location = new System.Drawing.Point(58, 264);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(128, 45);
            this.lblDevice.TabIndex = 40;
            this.lblDevice.Text = "Device:";
            this.lblDevice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHours
            // 
            this.lblHours.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHours.AutoSize = true;
            this.lblHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.lblHours.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHours.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHours.Location = new System.Drawing.Point(58, 329);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(120, 45);
            this.lblHours.TabIndex = 41;
            this.lblHours.Text = "Hours:";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDeviceCharge
            // 
            this.lblDeviceCharge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDeviceCharge.AutoSize = true;
            this.lblDeviceCharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.lblDeviceCharge.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblDeviceCharge.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDeviceCharge.Location = new System.Drawing.Point(58, 393);
            this.lblDeviceCharge.Name = "lblDeviceCharge";
            this.lblDeviceCharge.Size = new System.Drawing.Size(243, 45);
            this.lblDeviceCharge.TabIndex = 42;
            this.lblDeviceCharge.Text = "Device Charge:";
            this.lblDeviceCharge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalAmount.Location = new System.Drawing.Point(58, 520);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(234, 45);
            this.lblTotalAmount.TabIndex = 43;
            this.lblTotalAmount.Text = "Total Amount:";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPaymentMethod.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPaymentMethod.Location = new System.Drawing.Point(707, 142);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(287, 45);
            this.lblPaymentMethod.TabIndex = 44;
            this.lblPaymentMethod.Text = "Payment Method:";
            this.lblPaymentMethod.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.lblPaymentStatus.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPaymentStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPaymentStatus.Location = new System.Drawing.Point(707, 227);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(259, 45);
            this.lblPaymentStatus.TabIndex = 45;
            this.lblPaymentStatus.Text = "Payment Status:";
            this.lblPaymentStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.lblPaymentDate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPaymentDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPaymentDate.Location = new System.Drawing.Point(707, 382);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(238, 45);
            this.lblPaymentDate.TabIndex = 46;
            this.lblPaymentDate.Text = "Payment Date:";
            this.lblPaymentDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlData
            // 
            this.pnlData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.pnlData.Controls.Add(this.txtCustomer);
            this.pnlData.Controls.Add(this.lblNameCust);
            this.pnlData.Controls.Add(this.cbBookingRef);
            this.pnlData.Controls.Add(this.txtDeviceName);
            this.pnlData.Controls.Add(this.lblFood);
            this.pnlData.Controls.Add(this.txtFood);
            this.pnlData.Controls.Add(this.rbtnPending);
            this.pnlData.Controls.Add(this.rbtnRefund);
            this.pnlData.Controls.Add(this.rbtnPaid);
            this.pnlData.Controls.Add(this.txtTotal);
            this.pnlData.Controls.Add(this.txtCharge);
            this.pnlData.Controls.Add(this.txtHours);
            this.pnlData.Controls.Add(this.pnlMiddle);
            this.pnlData.Controls.Add(this.txtBookingRef);
            this.pnlData.Controls.Add(this.btnReset);
            this.pnlData.Controls.Add(this.btnCreate);
            this.pnlData.Controls.Add(this.pnlFooter);
            this.pnlData.Controls.Add(this.btnCancel);
            this.pnlData.Controls.Add(this.dtpDop);
            this.pnlData.Controls.Add(this.lblBookingID);
            this.pnlData.Controls.Add(this.lblCustomer);
            this.pnlData.Controls.Add(this.cbPaymentMethods);
            this.pnlData.Controls.Add(this.lblDevice);
            this.pnlData.Controls.Add(this.lblTotalAmount);
            this.pnlData.Controls.Add(this.lblPaymentDate);
            this.pnlData.Controls.Add(this.lblHours);
            this.pnlData.Controls.Add(this.lblPaymentStatus);
            this.pnlData.Controls.Add(this.lblDeviceCharge);
            this.pnlData.Controls.Add(this.lblPaymentMethod);
            this.pnlData.Controls.Add(this.pnlStyleUp);
            this.pnlData.Location = new System.Drawing.Point(51, 336);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(1378, 746);
            this.pnlData.TabIndex = 48;
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.txtCustomer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCustomer.Location = new System.Drawing.Point(185, 198);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(433, 50);
            this.txtCustomer.TabIndex = 63;
            // 
            // lblNameCust
            // 
            this.lblNameCust.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNameCust.AutoSize = true;
            this.lblNameCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.lblNameCust.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblNameCust.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNameCust.Location = new System.Drawing.Point(57, 198);
            this.lblNameCust.Name = "lblNameCust";
            this.lblNameCust.Size = new System.Drawing.Size(117, 45);
            this.lblNameCust.TabIndex = 62;
            this.lblNameCust.Text = "Name:";
            this.lblNameCust.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbBookingRef
            // 
            this.cbBookingRef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.cbBookingRef.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbBookingRef.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBookingRef.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbBookingRef.FormattingEnabled = true;
            this.cbBookingRef.Items.AddRange(new object[] {
            "Cash",
            "Bkash",
            "Nagad",
            "Rocket",
            "Card"});
            this.cbBookingRef.Location = new System.Drawing.Point(268, 142);
            this.cbBookingRef.Name = "cbBookingRef";
            this.cbBookingRef.Size = new System.Drawing.Size(350, 36);
            this.cbBookingRef.TabIndex = 61;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.txtDeviceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeviceName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.txtDeviceName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDeviceName.Location = new System.Drawing.Point(185, 264);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.ReadOnly = true;
            this.txtDeviceName.Size = new System.Drawing.Size(433, 50);
            this.txtDeviceName.TabIndex = 60;
            // 
            // lblFood
            // 
            this.lblFood.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFood.AutoSize = true;
            this.lblFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.lblFood.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblFood.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFood.Location = new System.Drawing.Point(58, 458);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(221, 45);
            this.lblFood.TabIndex = 59;
            this.lblFood.Text = "Food Charge:";
            this.lblFood.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtFood
            // 
            this.txtFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.txtFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFood.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.txtFood.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFood.Location = new System.Drawing.Point(301, 460);
            this.txtFood.Name = "txtFood";
            this.txtFood.ReadOnly = true;
            this.txtFood.Size = new System.Drawing.Size(317, 50);
            this.txtFood.TabIndex = 58;
            // 
            // rbtnPending
            // 
            this.rbtnPending.AutoSize = true;
            this.rbtnPending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.rbtnPending.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.rbtnPending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.rbtnPending.Location = new System.Drawing.Point(964, 326);
            this.rbtnPending.Name = "rbtnPending";
            this.rbtnPending.Size = new System.Drawing.Size(133, 36);
            this.rbtnPending.TabIndex = 57;
            this.rbtnPending.TabStop = true;
            this.rbtnPending.Text = "Pending";
            this.rbtnPending.UseVisualStyleBackColor = false;
            // 
            // rbtnRefund
            // 
            this.rbtnRefund.AutoSize = true;
            this.rbtnRefund.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.rbtnRefund.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.rbtnRefund.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rbtnRefund.Location = new System.Drawing.Point(964, 278);
            this.rbtnRefund.Name = "rbtnRefund";
            this.rbtnRefund.Size = new System.Drawing.Size(149, 36);
            this.rbtnRefund.TabIndex = 30;
            this.rbtnRefund.TabStop = true;
            this.rbtnRefund.Text = "Refunded";
            this.rbtnRefund.UseVisualStyleBackColor = false;
            // 
            // rbtnPaid
            // 
            this.rbtnPaid.AutoSize = true;
            this.rbtnPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.rbtnPaid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.rbtnPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(120)))));
            this.rbtnPaid.Location = new System.Drawing.Point(964, 236);
            this.rbtnPaid.Name = "rbtnPaid";
            this.rbtnPaid.Size = new System.Drawing.Size(88, 36);
            this.rbtnPaid.TabIndex = 28;
            this.rbtnPaid.TabStop = true;
            this.rbtnPaid.Text = "Paid";
            this.rbtnPaid.UseVisualStyleBackColor = false;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.txtTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotal.Location = new System.Drawing.Point(298, 523);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(320, 50);
            this.txtTotal.TabIndex = 54;
            // 
            // txtCharge
            // 
            this.txtCharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.txtCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCharge.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.txtCharge.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCharge.Location = new System.Drawing.Point(301, 395);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.ReadOnly = true;
            this.txtCharge.Size = new System.Drawing.Size(317, 50);
            this.txtCharge.TabIndex = 53;
            // 
            // txtHours
            // 
            this.txtHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.txtHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHours.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.txtHours.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtHours.Location = new System.Drawing.Point(184, 329);
            this.txtHours.Name = "txtHours";
            this.txtHours.ReadOnly = true;
            this.txtHours.Size = new System.Drawing.Size(434, 50);
            this.txtHours.TabIndex = 52;
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.pnlMiddle.Location = new System.Drawing.Point(654, 73);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(25, 518);
            this.pnlMiddle.TabIndex = 50;
            // 
            // txtBookingRef
            // 
            this.txtBookingRef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.txtBookingRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookingRef.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.txtBookingRef.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBookingRef.Location = new System.Drawing.Point(268, 74);
            this.txtBookingRef.Name = "txtBookingRef";
            this.txtBookingRef.ReadOnly = true;
            this.txtBookingRef.Size = new System.Drawing.Size(349, 50);
            this.txtBookingRef.TabIndex = 48;
            this.txtBookingRef.Text = "Auto Generated";
            this.txtBookingRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.Location = new System.Drawing.Point(610, 607);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(280, 72);
            this.btnReset.TabIndex = 36;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(66, 607);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(516, 72);
            this.btnCreate.TabIndex = 31;
            this.btnCreate.Text = "CREATE PAYMENT";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.pnlFooter.Controls.Add(this.lblMessage);
            this.pnlFooter.Location = new System.Drawing.Point(0, 694);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1378, 49);
            this.pnlFooter.TabIndex = 35;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(209)))));
            this.lblMessage.Location = new System.Drawing.Point(352, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(642, 28);
            this.lblMessage.TabIndex = 34;
            this.lblMessage.Text = "Payment records can be managed later from the Payment module.";
            // 
            // dtpDop
            // 
            this.dtpDop.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDop.CalendarForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtpDop.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.dtpDop.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.dtpDop.CalendarTitleForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtpDop.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dtpDop.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.dtpDop.Location = new System.Drawing.Point(951, 395);
            this.dtpDop.Name = "dtpDop";
            this.dtpDop.Size = new System.Drawing.Size(407, 29);
            this.dtpDop.TabIndex = 18;
            // 
            // cbPaymentMethods
            // 
            this.cbPaymentMethods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.cbPaymentMethods.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbPaymentMethods.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentMethods.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbPaymentMethods.FormattingEnabled = true;
            this.cbPaymentMethods.Items.AddRange(new object[] {
            "Cash",
            "Bkash",
            "Nagad",
            "Rocket",
            "Card"});
            this.cbPaymentMethods.Location = new System.Drawing.Point(1000, 146);
            this.cbPaymentMethods.Name = "cbPaymentMethods";
            this.cbPaymentMethods.Size = new System.Drawing.Size(358, 36);
            this.cbPaymentMethods.TabIndex = 21;
            // 
            // pnlStyleUp
            // 
            this.pnlStyleUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.pnlStyleUp.Controls.Add(this.lblBooking);
            this.pnlStyleUp.Controls.Add(this.lblPayment);
            this.pnlStyleUp.Location = new System.Drawing.Point(0, 0);
            this.pnlStyleUp.Name = "pnlStyleUp";
            this.pnlStyleUp.Size = new System.Drawing.Size(1378, 56);
            this.pnlStyleUp.TabIndex = 49;
            // 
            // pnlRIGHT
            // 
            this.pnlRIGHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.pnlRIGHT.Location = new System.Drawing.Point(1460, -11);
            this.pnlRIGHT.Name = "pnlRIGHT";
            this.pnlRIGHT.Size = new System.Drawing.Size(71, 1223);
            this.pnlRIGHT.TabIndex = 51;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.pnlLeft.Location = new System.Drawing.Point(-98, -34);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(123, 1246);
            this.pnlLeft.TabIndex = 52;
            // 
            // AddPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1487, 1163);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRIGHT);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlData);
            this.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlStyleUp.ResumeLayout(false);
            this.pnlStyleUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDeviceCharge;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DateTimePicker dtpDop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rbtnRefund;
        private System.Windows.Forms.RadioButton rbtnPaid;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cbPaymentMethods;
        private System.Windows.Forms.TextBox txtBookingRef;
        private System.Windows.Forms.Panel pnlStyleUp;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.Panel pnlRIGHT;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.RadioButton rbtnPending;
        private System.Windows.Forms.TextBox txtFood;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.ComboBox cbBookingRef;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblNameCust;
    }
}