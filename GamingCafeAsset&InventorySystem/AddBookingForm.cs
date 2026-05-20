using System;
using System.Data;
using System.Windows.Forms;

namespace GamingCafeAsset_InventorySystem
{
    public partial class AddBookingForm : Form
    {
        private LoggedInUser currentUser;
        private bool isUpdateMode = false;
        private int bookingId;
        private int deviceID;

        private bool isLoading = false;

        public AddBookingForm(LoggedInUser user)
        {
            InitializeComponent();

            isLoading = true;

            currentUser = user;

            LoadDevices();

            dtpStartTime.ValueChanged += dtpStartTime_ValueChanged;
            dtpEndTime.ValueChanged += dtpEndTime_ValueChanged;

            isLoading = false;
            rbCompleted.Enabled = false;
            rbCancel.Enabled = false;
        }

        public AddBookingForm(
          int bookingId,
          int deviceID,
          string customerName,
          string customerPhone,
          DateTime startTime,
          DateTime endTime,
          DateTime bookingDate,
          double totalHours,
          string status,
          string notes)
        {
            InitializeComponent();

            btnCreate.Text = "UPDATE BOOKING";

            isLoading = true;

            this.isUpdateMode = true;
            this.bookingId = bookingId;
            this.deviceID = deviceID;

            dtpStartTime.ValueChanged += dtpStartTime_ValueChanged;
            dtpEndTime.ValueChanged += dtpEndTime_ValueChanged;

            txtName.Text = customerName;
            txtPhone.Text = customerPhone;
            txtNotes.Text = notes;

            dtpStartTime.Value = startTime;
            dtpEndTime.Value = endTime;
            dtpBookingDate.Value = bookingDate;

            if (status == "Active") rbActive.Checked = true;
            else if (status == "Cancelled") rbCancel.Checked = true;
            else if (status == "Completed") rbCompleted.Checked = true;

            LoadDevices();

            isLoading = false;

            rbCompleted.Enabled = true;
            rbCancel.Enabled = true;

            UpdateTotalHours();
        }

        private void LoadDevices()
        {
            DBAccessHelper db = new DBAccessHelper();

            string query =
              "SELECT DeviceID, DeviceName, Status FROM Device ";

            if (isUpdateMode)
            {
                query +=
                  "WHERE Status = 'Available' OR DeviceID = " + deviceID;
            }
            else
            {
                query += "WHERE Status = 'Available'";
            }

            ResultSet result = db.GetQueryData(query);

            if (!result.HasError && result.Data != null)
            {
                cbDevice.DataSource = null;
                cbDevice.DisplayMember = "DeviceName";
                cbDevice.ValueMember = "DeviceID";
                cbDevice.DataSource = result.Data;

                cbDevice.SelectedIndex = -1;

                if (isUpdateMode)
                {
                    cbDevice.SelectedValue = deviceID;
                }
            }
        }

        private void dtpStartTime_ValueChanged(object sender, EventArgs e)
        {
            if (isLoading) return;
            UpdateTotalHours();
        }

        private void dtpEndTime_ValueChanged(object sender, EventArgs e)
        {
            if (isLoading) return;
            UpdateTotalHours();
        }

        private void UpdateTotalHours()
        {
            DateTime startTime = dtpStartTime.Value;
            DateTime endTime = dtpEndTime.Value;

            if (endTime <= startTime)
            {
                txtTotalHours.Text = "0.00";
                return;
            }

            txtTotalHours.Text = (endTime - startTime).TotalHours.ToString("F2");
        }

        private void ResetScreen()
        {
            txtName.Clear();
            txtPhone.Clear();
            txtNotes.Clear();
            txtTotalHours.Clear();

            dtpStartTime.Value = DateTime.Now;
            dtpEndTime.Value = DateTime.Now.AddHours(1);
            dtpBookingDate.Value = DateTime.Now;

            rbActive.Checked = false;
            rbCancel.Checked = false;
            rbCompleted.Checked = false;

            cbDevice.SelectedIndex = -1;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetScreen();
            UpdateTotalHours();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string notes = txtNotes.Text;

            DateTime bookingDate = dtpBookingDate.Value;
            DateTime startTime = dtpStartTime.Value;
            DateTime endTime = dtpEndTime.Value;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Customer name is required!");
                return;
            }

            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Customer phone is required!");
                return;
            }

            if (!PhoneEmailValidation.IsValidPhone(phone))
            {
                MessageBox.Show(
                  "Phone number must be exactly 11 digits!",
                  "Invalid Phone Number",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
                );

                return;
            }

            if (endTime <= startTime)
            {
                MessageBox.Show("End time must be greater than start time!");
                return;
            }

            string status = "";

            if (rbActive.Checked)
            {
                status = "Active";
            }
            else if (rbCompleted.Checked)
            {
                status = "Completed";
            }
            else if (rbCancel.Checked)
            {
                status = "Cancelled";
            }

            if (string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Please select booking status!");
                return;
            }

            if (cbDevice.SelectedValue == null)
            {
                MessageBox.Show("Please select a device!");
                return;
            }

            deviceID = Convert.ToInt32(cbDevice.SelectedValue);
            double totalHours = (endTime - startTime).TotalHours;

            DBAccessHelper db = new DBAccessHelper();

            if (!isUpdateMode)
            {
                string check =
                  "SELECT COUNT(*) FROM Booking " +
                  "WHERE DeviceID = " + deviceID + " AND BookingStatus = 'Active'";

                ResultSet r = db.GetQueryData(check);

                if (!r.HasError && Convert.ToInt32(r.Data.Rows[0][0]) > 0)
                {
                    MessageBox.Show("This device already has an active booking!");
                    return;
                }

                string query =
                  "INSERT INTO Booking " +
                  "(UserID, StartTime, EndTime, TotalHours, BookingDate, BookingStatus, Notes, CustomerName, CustomerPhone, DeviceID) " +
                  "VALUES (" +
                  currentUser.UserID + ", '" +
                  startTime.ToString("yyyy-MM-dd HH:mm:ss") + "', '" +
                  endTime.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                  totalHours + ", '" +
                  bookingDate.ToString("yyyy-MM-dd") + "', '" +
                  status + "', '" +
                  notes.Replace("'", "''") + "', '" +
                  name.Replace("'", "''") + "', '" +
                  phone.Replace("'", "''") + "', " +
                  deviceID + ")";

                ResultSet result = db.ExecuteNonQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message, "Error");
                }
                else
                {
                    if (status == "Active")
                        new DataDeletionHelper().SetDeviceStatus(deviceID, "Occupied");

                    MessageBox.Show("Booking created successfully!");
                    ResetScreen();
                    this.Close();
                }
            }
            else
            {
                string statusQuery =
                  "SELECT BookingStatus " +
                  "FROM Booking " +
                  "WHERE BookingID = " + bookingId;

                ResultSet statusResult =
                  db.GetQueryData(statusQuery);

                string currentStatus = "";

                if (!statusResult.HasError &&
                  statusResult.Data != null &&
                  statusResult.Data.Rows.Count > 0)
                {
                    currentStatus =
                      statusResult.Data.Rows[0]["BookingStatus"].ToString();
                }

                if (currentStatus == "Completed" || currentStatus == "Cancelled")
                {
                    MessageBox.Show(
                      "Completed or cancelled bookings cannot be changed.",
                      "Invalid Status Change",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning
                    );

                    return;
                }

                string query =
                  "UPDATE Booking SET " +
                  "StartTime = '" + startTime.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                  "EndTime = '" + endTime.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                  "TotalHours = " + totalHours + ", " +
                  "BookingDate = '" + bookingDate.ToString("yyyy-MM-dd") + "', " +
                  "BookingStatus = '" + status + "', " +
                  "Notes = '" + notes.Replace("'", "''") + "', " +
                  "CustomerName = '" + name.Replace("'", "''") + "', " +
                  "CustomerPhone = '" + phone.Replace("'", "''") + "', " +
                  "DeviceID = " + deviceID + " " +
                  "WHERE BookingID = " + bookingId;

                ResultSet result = db.ExecuteNonQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message, "Error");
                }
                else
                {
                    var helper = new DataDeletionHelper();

                    if (status == "Active")
                        helper.SetDeviceStatus(deviceID, "Occupied");
                    else
                        helper.SetDeviceStatus(deviceID, "Available");

                    MessageBox.Show("Booking updated successfully!");
                    ResetScreen();
                    this.Close();
                }
            }
        }
    }
}
