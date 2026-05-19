using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GamingCafeAsset_InventorySystem
{
    public partial class AddPaymentForm : Form
    {
        // =====================================================
        // FIELDS
        // =====================================================

        private bool isUpdateMode = false;

        private int paymentID = 0;
        private int bookingID = 0;
        private int oldDeviceID = 0;

        private LoggedInUser currentUser;

        // =====================================================
        // CONSTRUCTOR (CREATE)
        // =====================================================

        public AddPaymentForm(LoggedInUser user)
        {
            InitializeComponent();
            currentUser = user;
        }

        // =====================================================
        // CONSTRUCTOR (UPDATE)
        // =====================================================

        public AddPaymentForm(
          LoggedInUser user,
          int paymentID,
          int bookingID,
          int deviceID,
          string deviceName,
          string customerName,
          decimal hours,
          decimal totalAmount,
          string notes,
          string paymentMethod,
          string paymentStatus
        )
        {
            InitializeComponent();

            currentUser = user;

            this.paymentID = paymentID;
            this.bookingID = bookingID;
            this.oldDeviceID = deviceID;

            isUpdateMode = true;

            LoadDevicesForUpdate(deviceName);

            txtCustomer.Text = customerName;
            txtHours.Text = hours.ToString();
            txtNote.Text = notes;
            txtTotal.Text = totalAmount.ToString("0.00");
            cbPaymentMethods.Text = paymentMethod;

            rbtnPaid.Checked = paymentStatus == "Paid";
            rbtnRefund.Checked = paymentStatus == "Refunded";
            rbtnPending.Checked = paymentStatus == "Pending";

            btnCreate.Text = "Update Payment";

            CalculateCharges();
        }

        // =====================================================
        // GET ACTIVE BOOKING ID FOR DEVICE (USED IN UPDATE MODE)
        // =====================================================

        private int GetActiveBookingId(int deviceID)
        {
            DBAccessHelper db = new DBAccessHelper();

            string query =
              "SELECT TOP 1 BookingID FROM Booking " +
              "WHERE DeviceID=" + deviceID + " " +
              "AND BookingStatus='Active' " +
              "ORDER BY BookingID DESC";

            ResultSet result = db.GetQueryData(query);

            if (result.Data.Rows.Count > 0)
                return Convert.ToInt32(result.Data.Rows[0]["BookingID"]);

            return 0;
        }

        // =====================================================
        // LOAD DEVICES
        // =====================================================

        private void LoadDevices()
        {
            DBAccessHelper db = new DBAccessHelper();

            string query =
              "SELECT DeviceID, DeviceName FROM Device WHERE Status='Available' ORDER BY DeviceName";

            ResultSet result = db.GetQueryData(query);

            cbDevice.DataSource = result.Data;
            cbDevice.DisplayMember = "DeviceName";
            cbDevice.ValueMember = "DeviceID";
            cbDevice.SelectedIndex = -1;
        }

        private void LoadDevicesForUpdate(string currentDevice)
        {
            DBAccessHelper db = new DBAccessHelper();

            string safeDevice = currentDevice.Replace("'", "''");

            string query =
              "SELECT DeviceID, DeviceName FROM Device " +
              "WHERE Status='Available' OR DeviceName='" + safeDevice + "' " +
              "ORDER BY DeviceName";

            ResultSet result = db.GetQueryData(query);

            cbDevice.DataSource = result.Data;
            cbDevice.DisplayMember = "DeviceName";
            cbDevice.ValueMember = "DeviceID";

            cbDevice.SelectedIndex =
              cbDevice.FindStringExact(currentDevice);
        }

        // =====================================================
        // CHARGE CALCULATION
        // =====================================================

        private void CalculateCharges()
        {
            try
            {
                if (cbDevice.SelectedValue == null) return;

                if (!decimal.TryParse(txtHours.Text, out decimal hours))
                {
                    txtCharge.Text = "";
                    txtFood.Text = "";
                    txtTotal.Text = "";
                    return;
                }

                int deviceID = Convert.ToInt32(cbDevice.SelectedValue);

                DBAccessHelper db = new DBAccessHelper();

                // =====================================================
                // DEVICE CHARGE
                // =====================================================

                string deviceQuery =
                  "SELECT HourlyRate FROM Device WHERE DeviceID=" + deviceID;

                ResultSet deviceResult = db.GetQueryData(deviceQuery);

                decimal deviceTotal = 0;

                // refund rule
                bool isRefunded =
                  (rbtnRefund.Checked || txtNote.Text.Contains("Refunded"));

                if (!isRefunded)
                {
                    if (deviceResult.Data.Rows.Count > 0)
                    {
                        decimal rate =
                          Convert.ToDecimal(deviceResult.Data.Rows[0]["HourlyRate"]);

                        deviceTotal = rate * hours;
                    }
                }

                txtCharge.Text = deviceTotal.ToString("0.00");

                // =====================================================
                // FOOD CHARGE (AUTO DETECT BOOKING)
                // =====================================================
                decimal foodTotal = 0;

                // always try to detect booking from device
                int activeBookingId = bookingID;

                if (activeBookingId == 0 && cbDevice.SelectedValue != null)
                {
                    deviceID = Convert.ToInt32(cbDevice.SelectedValue);
                    activeBookingId = GetActiveBookingId(deviceID);
                }

                if (activeBookingId > 0)
                {
                    string foodQuery =
                      "SELECT ISNULL(SUM(Price * Quantity),0) AS FoodTotal " +
                      "FROM FoodItem WHERE BookingID=" + activeBookingId;

                    ResultSet foodResult = db.GetQueryData(foodQuery);

                    if (foodResult.Data.Rows.Count > 0)
                    {
                        foodTotal = Convert.ToDecimal(foodResult.Data.Rows[0]["FoodTotal"]);
                    }

                    bookingID = activeBookingId;
                }

                txtFood.Text = foodTotal.ToString("0.00");

                // =====================================================
                // FINAL TOTAL
                // =====================================================
                decimal grandTotal = deviceTotal + foodTotal;

                txtTotal.Text = grandTotal.ToString("0.00");
            }
            catch
            {
                txtCharge.Text = "";
                txtFood.Text = "";
                txtTotal.Text = "";
            }
        }

        private string GetDeviceStatus(string paymentStatus)
        {
            switch (paymentStatus)
            {
                case "Paid":
                    return "Available";

                case "Refunded":
                    return "Available";

                case "Pending":
                    return "Occupied";

                default:
                    return "Available";
            }
        }

        // =====================================================
        // SAVE
        // =====================================================

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cbDevice.SelectedValue == null ||
              string.IsNullOrWhiteSpace(txtCustomer.Text) ||
              !decimal.TryParse(txtHours.Text, out decimal hours))
            {
                MessageBox.Show("Fill all required fields.");
                return;
            }

            int deviceID = Convert.ToInt32(cbDevice.SelectedValue);
            decimal totalAmount = Convert.ToDecimal(txtTotal.Text);

            string customer = txtCustomer.Text.Replace("'", "''");
            string notes = txtNote.Text.Replace("'", "''");
            string method = cbPaymentMethods.Text.Replace("'", "''");

            string status =
              rbtnPaid.Checked ? "Paid" :
              rbtnRefund.Checked ? "Refunded" : "Pending";

            DBAccessHelper db = new DBAccessHelper();

            // =====================================================
            // UPDATE
            // =====================================================

            if (isUpdateMode)
            {
                db.ExecuteNonQuery(
                  "UPDATE Booking SET " +
                  "UserID=" + currentUser.UserID + "," +
                  "DeviceID=" + deviceID + "," +
                  "TotalHours=" + hours + "," +
                  "EndTime=DATEADD(HOUR," + hours + ",StartTime)," +
                  "BookingStatus='" + (status == "Paid" ? "Completed" : status == "Refunded" ? "Cancelled" : "Active") + "'," +
                  "Notes='" + notes + "'," +
                  "CustomerName='" + customer + "' " +
                  "WHERE BookingID=" + bookingID
                );

                db.ExecuteNonQuery(
                  "UPDATE Payment SET " +
                  "PaymentAmount=" + totalAmount + "," +
                  "PaymentMethod='" + method + "'," +
                  "PaymentStatus='" + status + "' " +
                  "WHERE PaymentID=" + paymentID
                );

                if (oldDeviceID != deviceID)
                {
                    db.ExecuteNonQuery("UPDATE Device SET Status='Available' WHERE DeviceID=" + oldDeviceID);
                }

                db.ExecuteNonQuery("UPDATE Device SET Status='" + GetDeviceStatus(status) + "' WHERE DeviceID=" + deviceID);

                MessageBox.Show("Payment updated.");
                Close();
            }

            // =====================================================
            // INSERT
            // =====================================================
            else
            {
                db.ExecuteNonQuery(
                  "INSERT INTO Booking (UserID,DeviceID,StartTime,EndTime,TotalHours,BookingDate,BookingStatus,Notes,CustomerName,CustomerPhone) " +
                  "VALUES (" +
                  currentUser.UserID + "," + deviceID + ",GETDATE()," +
                  "DATEADD(HOUR," + hours + ",GETDATE())," +
                  hours + ",GETDATE()," +
                  "'" + (status == "Paid" ? "Completed" : status == "Refunded" ? "Cancelled" : "Active") + "'," +
                  "'" + notes + "','" + customer + "','')"
                );

                int newBookingID =
                  Convert.ToInt32(db.GetQueryData("SELECT TOP 1 BookingID FROM Booking ORDER BY BookingID DESC")
                    .Data.Rows[0]["BookingID"]);

                db.ExecuteNonQuery(
                  "INSERT INTO Payment (BookingID,PaymentAmount,PaymentMethod,PaymentDate,PaymentStatus,CreatedAt) " +
                  "VALUES (" + newBookingID + "," + totalAmount + ",'" + method + "',GETDATE(),'" + status + "',GETDATE())"
                );

                db.ExecuteNonQuery("UPDATE Device SET Status='" + GetDeviceStatus(status) + "' WHERE DeviceID=" + deviceID);

                MessageBox.Show("Payment created.");
                LoadDevices();
                btnReset.PerformClick();
            }
        }

        // =====================================================
        // RESET
        // =====================================================

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbDevice.SelectedIndex = -1;
            cbPaymentMethods.SelectedIndex = -1;
            txtCustomer.Clear();
            txtHours.Clear();
            txtNote.Clear();
            txtFood.Clear();
            txtCharge.Clear();
            txtTotal.Clear();

            rbtnPaid.Checked = false;
            rbtnRefund.Checked = false;
            rbtnPending.Checked = false;

            bookingID = 0;
            oldDeviceID = 0;
        }

        private void AddPaymentForm_Load(object sender, EventArgs e)
        {
            if (!isUpdateMode)
                LoadDevices();
        }

        private void cbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateCharges();
        }

        private void txtHours_TextChanged(object sender, EventArgs e)
        {
            CalculateCharges();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
