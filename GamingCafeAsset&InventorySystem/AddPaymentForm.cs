using System;
using System.Data;
using System.Windows.Forms;

namespace GamingCafeAsset_InventorySystem
{
    public partial class AddPaymentForm : Form
    {

        private LoggedInUser currentUser;

        private bool isUpdateMode = false;

        private int paymentID;

        public AddPaymentForm(
          LoggedInUser user)
        {
            InitializeComponent();

            currentUser = user;

            LoadActiveBookings();
            LoadPaymentMethods();

            PaymentEvents();

            ResetScreen();

            rbtnRefund.Enabled = false;
        }

        public AddPaymentForm(
          LoggedInUser user,
          int paymentID,
          int bookingID,
          string customerName,
          string deviceName,
          double totalHours,
          double deviceCharge,
          double foodCharge,
          double totalAmount,
          string paymentMethod,
          string paymentStatus,
          DateTime paymentDate)
        {
            InitializeComponent();

            currentUser = user;

            isUpdateMode = true;

            this.paymentID = paymentID;

            LoadActiveBookings();
            LoadPaymentMethods();

            PaymentEvents();

            btnCreate.Text = "UPDATE PAYMENT";

            cbBookingRef.SelectedValue = bookingID;

            cbBookingRef.Enabled = false;

            txtBookingRef.Text =
              bookingID.ToString();

            txtCustomer.Text =
              customerName;

            txtDeviceName.Text =
              deviceName;

            txtHours.Text =
              totalHours.ToString("0.00");

            txtCharge.Text =
              deviceCharge.ToString("0.00");

            txtFood.Text =
              foodCharge.ToString("0.00");

            txtTotal.Text =
              totalAmount.ToString("0.00");

            cbPaymentMethods.Text =
              paymentMethod;

            dtpDop.Value =
              paymentDate;

            if (paymentStatus == "Paid")
            {
                rbtnPaid.Checked = true;
            }
            else if (paymentStatus == "Pending")
            {
                rbtnPending.Checked = true;
            }
            else if (paymentStatus == "Refunded")
            {
                rbtnRefund.Checked = true;
            }
        }

        private void PaymentEvents()
        {
            cbBookingRef.SelectedIndexChanged +=
              cbBookingRef_SelectedIndexChanged;
        }

        private void LoadActiveBookings()
        {
            DBAccessHelper db =
              new DBAccessHelper();

            string query = "";

            if (!isUpdateMode)
            {
                query =
                  "SELECT " +

                  "Booking.BookingID, " +

                  "CAST(Booking.BookingID AS VARCHAR) + " +
                  "' - ' + " +
                  "Booking.CustomerName + " +
                  "' - ' + " +
                  "Device.DeviceName " +

                  "AS BookingInfo " +

                  "FROM Booking " +

                  "INNER JOIN Device " +
                  "ON Booking.DeviceID = Device.DeviceID " +

                  "WHERE Booking.BookingStatus='Active'";
            }
            else
            {
                query =
                  "SELECT " +

                  "Booking.BookingID, " +

                  "CAST(Booking.BookingID AS VARCHAR) + " +
                  "' - ' + " +
                  "Booking.CustomerName + " +
                  "' - ' + " +
                  "Device.DeviceName " +

                  "AS BookingInfo " +

                  "FROM Booking " +

                  "INNER JOIN Device " +
                  "ON Booking.DeviceID = Device.DeviceID";
            }

            ResultSet result =
              db.GetQueryData(query);

            if (!result.HasError &&
              result.Data != null)
            {
                cbBookingRef.DataSource =
                  result.Data;

                cbBookingRef.DisplayMember =
                  "BookingInfo";

                cbBookingRef.ValueMember =
                  "BookingID";

                cbBookingRef.SelectedIndex = -1;
            }
        }

        private void LoadPaymentMethods()
        {
            cbPaymentMethods.Items.Clear();

            cbPaymentMethods.Items.Add("Cash");
            cbPaymentMethods.Items.Add("Card");
            cbPaymentMethods.Items.Add("Bkash");
            cbPaymentMethods.Items.Add("Nagad");
            cbPaymentMethods.Items.Add("Rocket");

            cbPaymentMethods.SelectedIndex = -1;
        }

        private void cbBookingRef_SelectedIndexChanged(
          object sender,
          EventArgs e)
        {
            if (cbBookingRef.SelectedValue == null)
            {
                return;
            }

            if (!int.TryParse(
                cbBookingRef.SelectedValue.ToString(),
                out int bookingID))
            {
                return;
            }

            LoadBookingDetails(
              bookingID
            );
        }

        private void LoadBookingDetails(
          int bookingID)
        {
            DBAccessHelper db =
              new DBAccessHelper();

            string query =
              "SELECT " +

              "Booking.BookingID, " +
              "Booking.CustomerName, " +
              "Booking.TotalHours, " +

              "Device.DeviceName, " +
              "Device.HourlyRate " +

              "FROM Booking " +

              "INNER JOIN Device " +
              "ON Booking.DeviceID = Device.DeviceID " +

              "WHERE Booking.BookingID=" +
              bookingID;

            ResultSet result =
              db.GetQueryData(query);

            if (result.HasError ||
              result.Data == null ||
              result.Data.Rows.Count == 0)
            {
                return;
            }

            DataRow row =
              result.Data.Rows[0];

            string customerName =
              row["CustomerName"].ToString();

            string deviceName =
              row["DeviceName"].ToString();

            double totalHours =
              Convert.ToDouble(
                row["TotalHours"]
              );

            double hourlyRate =
              Convert.ToDouble(
                row["HourlyRate"]
              );

            double deviceCharge =
              totalHours * hourlyRate;

            double foodCharge = 0;

            string foodQuery =
              "SELECT " +
              "ISNULL(SUM(Price * Quantity), 0) " +
              "AS FoodCharge " +

              "FROM FoodItem " +

              "WHERE BookingID=" +
              bookingID;

            ResultSet foodResult =
              db.GetQueryData(foodQuery);

            if (!foodResult.HasError &&
              foodResult.Data != null &&
              foodResult.Data.Rows.Count > 0)
            {
                foodCharge =
                  Convert.ToDouble(
                    foodResult.Data.Rows[0]["FoodCharge"]
                  );
            }

            double totalAmount =
              deviceCharge + foodCharge;

            txtBookingRef.Text =
              bookingID.ToString();

            txtCustomer.Text =
              customerName;

            txtDeviceName.Text =
              deviceName;

            txtHours.Text =
              totalHours.ToString("0.00");

            txtCharge.Text =
              deviceCharge.ToString("0.00");

            txtFood.Text =
              foodCharge.ToString("0.00");

            txtTotal.Text =
              totalAmount.ToString("0.00");
        }

        private void btnCreate_Click(
          object sender,
          EventArgs e)
        {

            if (cbBookingRef.SelectedValue == null)
            {
                MessageBox.Show(
                  "Please select a booking."
                );

                return;
            }

            if (cbPaymentMethods.SelectedItem == null)
            {
                MessageBox.Show(
                  "Please select a payment method."
                );

                return;
            }

            string paymentStatus = "";

            if (rbtnPaid.Checked)
            {
                paymentStatus = "Paid";
            }
            else if (rbtnPending.Checked)
            {
                paymentStatus = "Pending";
            }
            else if (rbtnRefund.Checked)
            {
                paymentStatus = "Refunded";
            }
            else
            {
                MessageBox.Show(
                  "Please select payment status."
                );

                return;
            }

            int bookingID =
              Convert.ToInt32(
                cbBookingRef.SelectedValue
              );

            double totalAmount =
              Convert.ToDouble(
                txtTotal.Text
              );

            string paymentMethod =
              cbPaymentMethods.Text;

            string paymentDate =
              dtpDop.Value.ToString("yyyy-MM-dd");

            string createdAt =
              DateTime.Now.ToString(
                "yyyy-MM-dd HH:mm:ss"
              );

            DBAccessHelper db =
              new DBAccessHelper();

            int deviceID = 0;

            ResultSet deviceResult =
              db.GetQueryData(

                "SELECT DeviceID " +
                "FROM Booking " +
                "WHERE BookingID=" +
                bookingID
              );

            if (!deviceResult.HasError &&
              deviceResult.Data != null &&
              deviceResult.Data.Rows.Count > 0)
            {
                deviceID =
                  Convert.ToInt32(
                    deviceResult.Data.Rows[0]["DeviceID"]
                  );
            }

            if (!isUpdateMode)
            {
                string insertQuery =
                  "INSERT INTO Payment " +

                  "(BookingID, " +
                  "PaymentAmount, " +
                  "PaymentMethod, " +
                  "PaymentDate, " +
                  "PaymentStatus, " +
                  "CreatedAt) " +

                  "VALUES (" +

                  bookingID + ", " +

                  totalAmount + ", '" +

                  paymentMethod.Replace("'", "''") + "', '" +

                  paymentDate + "', '" +

                  paymentStatus + "', '" +

                  createdAt + "')";

                ResultSet result =
                  db.ExecuteNonQuery(insertQuery);

                if (result.HasError)
                {
                    MessageBox.Show(
                      result.Message,
                      "Payment Failed",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error
                    );

                    return;
                }
            }
            else
            {
                ResultSet statusResult =
                  db.GetQueryData(

                    "SELECT PaymentStatus " +
                    "FROM Payment " +
                    "WHERE PaymentID=" + paymentID
                  );

                if (!statusResult.HasError &&
                  statusResult.Data != null &&
                  statusResult.Data.Rows.Count > 0)
                {
                    string currentStatus =
                      statusResult.Data.Rows[0]["PaymentStatus"].ToString();

                    if (currentStatus == "Paid" &&
                      paymentStatus != "Paid")
                    {
                        MessageBox.Show(
                          "Paid payments cannot be changed.",
                          "Update Blocked",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning
                        );

                        return;
                    }

                    if (currentStatus == "Refunded" &&
                      paymentStatus == "Paid")
                    {
                        MessageBox.Show(
                          "Refunded payments cannot be changed to Paid.",
                          "Update Blocked",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning
                        );

                        return;
                    }

                    if (currentStatus == "Pending" &&
                      paymentStatus == "Refunded")
                    {
                        MessageBox.Show(
                          "Pending payments cannot be changed to Refunded.",
                          "Update Blocked",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning
                        );

                        return;
                    }
                }

                string updateQuery =
                  "UPDATE Payment SET " +

                  "BookingID=" + bookingID + ", " +

                  "PaymentAmount=" + totalAmount + ", " +

                  "PaymentMethod='" +
                  paymentMethod.Replace("'", "''") + "', " +

                  "PaymentDate='" +
                  paymentDate + "', " +

                  "PaymentStatus='" +
                  paymentStatus + "' " +

                  "WHERE PaymentID=" +
                  paymentID;

                ResultSet result =
                  db.ExecuteNonQuery(updateQuery);

                if (result.HasError)
                {
                    MessageBox.Show(
                      result.Message,
                      "Update Failed",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error
                    );

                    return;
                }
            }

            string bookingStatus =
              "Completed";

            string deviceStatus =
              "Available";

            if (paymentStatus == "Pending")
            {
                bookingStatus =
                  "Active";

                deviceStatus =
                  "Occupied";
            }
            else if (paymentStatus == "Refunded")
            {
                bookingStatus =
                  "Cancelled";

                deviceStatus =
                  "Available";
            }
            else if (paymentStatus == "Paid")
            {
                bookingStatus =
                  "Completed";

                deviceStatus =
                  "Available";
            }

            db.ExecuteNonQuery(

              "UPDATE Booking SET " +

              "BookingStatus='" +
              bookingStatus + "' " +

              "WHERE BookingID=" +
              bookingID
            );

            db.ExecuteNonQuery(

              "UPDATE Device SET " +

              "Status='" +
              deviceStatus + "' " +

              "WHERE DeviceID=" +
              deviceID
            );

            if (!isUpdateMode)
            {
                MessageBox.Show(
                  "Payment created successfully!",
                  "Success",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                  "Payment updated successfully!",
                  "Success",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information
                );
            }

            ResetScreen();

            this.Close();
        }

        private void ResetScreen()
        {
            txtBookingRef.Clear();
            txtDeviceName.Clear();
            txtCharge.Clear();
            txtCustomer.Clear();
            txtFood.Clear();
            txtTotal.Clear();
            txtHours.Clear();

            txtCharge.Text = "0.00";
            txtFood.Text = "0.00";
            txtTotal.Text = "0.00";

            cbBookingRef.SelectedIndex = -1;

            cbPaymentMethods.SelectedIndex = -1;

            rbtnPaid.Checked = false;
            rbtnPending.Checked = false;
            rbtnRefund.Checked = false;

            dtpDop.Value =
              DateTime.Now;
        }

        private void btnReset_Click(
          object sender,
          EventArgs e)
        {
            ResetScreen();
        }

        private void btnCancel_Click(
          object sender,
          EventArgs e)
        {
            this.Close();
        }
    }
}
