using System;
using System.Windows.Forms;

namespace GamingCafeAsset_InventorySystem
{
    public partial class AddDeviceForm : Form
    {
        // =====================================================
        // FIELDS
        // =====================================================

        private LoggedInUser currentUser;
        private bool isUpdateMode = false;
        private int deviceID;

        // =====================================================
        // CREATE MODE CONSTRUCTOR
        // =====================================================

        public AddDeviceForm(LoggedInUser user)
        {
            InitializeComponent();
            currentUser = user;

            ResetScreen();

            LoadDevices();
        }

        // =====================================================
        // Datagrid view for live update
        // =====================================================

        private void DisableSorting()
        {
            foreach (DataGridViewColumn column in dgvLiveUpdate.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void LoadDevices()
        {
            DBAccessHelper db = new DBAccessHelper();

            string query =
              "SELECT " +
              "Device.DeviceID AS [Device No.], " +
              "Device.DeviceName AS [Device Name], " +
              "DeviceCategory.CategoryName AS [Category], " +
              "Device.Status AS [Status], " +
              "Device.LocationNumber AS [Location Number], " +
              "Device.HourlyRate AS [Hourly Rate] " +
              "FROM Device " +
              "LEFT JOIN DeviceCategoryMap ON Device.DeviceID = DeviceCategoryMap.DeviceID " +
              "LEFT JOIN DeviceCategory ON DeviceCategoryMap.CategoryID = DeviceCategory.CategoryID";

            ResultSet result = db.GetQueryData(query);

            if (!result.HasError)
            {
                dgvLiveUpdate.DataSource = result.Data;
            }

            DisableSorting();
        }

        // =====================================================
        // UPDATE MODE CONSTRUCTOR
        // =====================================================

        public AddDeviceForm(
          int deviceID,
          string name,
          string category,
          string status,
          string locationNumber,
          double hourlyRate)
        {
            InitializeComponent();

            isUpdateMode = true;
            this.deviceID = deviceID;

            btnCreate.Text = "UPDATE DEVICE";

            LoadDevices();

            txtName.Text = name;
            txtLocationNumber.Text = locationNumber;
            txtHourlyRate.Text = hourlyRate.ToString("F2");

            cbCategory.Text = category;

            if (status == "Available")
                rbAvailable.Checked = true;
            else if (status == "Occupied")
                rbOccupied.Checked = true;
            else
                rbUnavailable.Checked = true;
        }

        // =====================================================
        // RESET BUTTON
        // =====================================================

        private void ResetScreen()
        {
            txtName.Clear();
            txtHourlyRate.Clear();
            txtLocationNumber.Clear();

            cbCategory.SelectedIndex = -1;

            rbAvailable.Checked = false;
            rbOccupied.Checked = false;
            rbUnavailable.Checked = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetScreen();

            LoadDevices();
        }

        // =====================================================
        // CANCEL BUTTON
        // =====================================================

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // =====================================================
        // CREATE / UPDATE BUTTON
        // =====================================================

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string category = cbCategory.Text;
            string location = txtLocationNumber.Text.Trim();
            string hourly = txtHourlyRate.Text.Trim();

            // =================================================
            // VALIDATION
            // =================================================

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Device name is required!");
                return;
            }

            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Please select a category!");
                return;
            }

            if (string.IsNullOrEmpty(location))
            {
                MessageBox.Show("Location number is required!");
                return;
            }

            if (string.IsNullOrEmpty(hourly))
            {
                MessageBox.Show("Hourly rate is required!");
                return;
            }

            if (!double.TryParse(hourly, out double hourlyRate))
            {
                MessageBox.Show("Invalid hourly rate!");
                return;
            }

            // =================================================
            // STATUS
            // =================================================

            string status = "";

            if (rbAvailable.Checked)
                status = "Available";
            else if (rbOccupied.Checked)
                status = "Occupied";
            else if (rbUnavailable.Checked)
                status = "Unavailable";
            else
            {
                MessageBox.Show("Please select device status!");
                return;
            }

            DBAccessHelper db = new DBAccessHelper();

            if (!isUpdateMode)
            {
                // =====================================================
                // INSERT DEVICE
                // =====================================================

                string query =
                  "INSERT INTO Device " +
                  "(DeviceName, Status, LocationNumber, HourlyRate) " +
                  "VALUES ('" +
                  name.Replace("'", "''") + "', '" +
                  status + "', '" +
                  location.Replace("'", "''") + "', " +
                  hourlyRate + ")";

                ResultSet result = db.ExecuteNonQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // =====================================================
                // GET NEW DEVICE ID
                // =====================================================

                string idQuery = "SELECT MAX(DeviceID) FROM Device";
                ResultSet idResult = db.GetQueryData(idQuery);

                int newDeviceId = Convert.ToInt32(idResult.Data.Rows[0][0]);

                // =====================================================
                // GET CATEGORY ID
                // =====================================================

                string catQuery =
                  "SELECT CategoryID FROM DeviceCategory " +
                  "WHERE CategoryName = '" + category + "'";

                ResultSet catResult = db.GetQueryData(catQuery);

                int categoryId = Convert.ToInt32(catResult.Data.Rows[0]["CategoryID"]);

                // =====================================================
                // INSERT INTO MAP TABLE
                // =====================================================

                string mapQuery =
                  "INSERT INTO DeviceCategoryMap (DeviceID, CategoryID) VALUES (" +
                  newDeviceId + ", " + categoryId + ")";

                db.ExecuteNonQuery(mapQuery);

                MessageBox.Show("Device added successfully!");

                ResetScreen();

                LoadDevices();
            }
            else
            {
                // =====================================================
                // UPDATE DEVICE TABLE
                // =====================================================

                string query =
                  "UPDATE Device SET " +
                  "DeviceName = '" + name.Replace("'", "''") + "', " +
                  "Status = '" + status + "', " +
                  "LocationNumber = '" + location.Replace("'", "''") + "', " +
                  "HourlyRate = " + hourlyRate + " " +
                  "WHERE DeviceID = " + deviceID;

                ResultSet result = db.ExecuteNonQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // =====================================================
                // UPDATE CATEGORY MAPPING
                // =====================================================

                string catQuery =
                  "SELECT CategoryID FROM DeviceCategory " +
                  "WHERE CategoryName = '" + category + "'";

                ResultSet catResult = db.GetQueryData(catQuery);

                int categoryId = Convert.ToInt32(catResult.Data.Rows[0]["CategoryID"]);

                // remove old mapping
                string deleteMap =
                  "DELETE FROM DeviceCategoryMap WHERE DeviceID = " + deviceID;

                db.ExecuteNonQuery(deleteMap);

                // insert new mapping
                string insertMap =
                  "INSERT INTO DeviceCategoryMap (DeviceID, CategoryID) VALUES (" +
                  deviceID + ", " + categoryId + ")";

                db.ExecuteNonQuery(insertMap);

                MessageBox.Show("Device updated successfully!");

                ResetScreen();

                LoadDevices();
            }
        }
    }
}
