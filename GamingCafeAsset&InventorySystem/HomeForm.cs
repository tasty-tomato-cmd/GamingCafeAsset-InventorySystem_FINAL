using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GamingCafeAsset_InventorySystem
{
    public partial class HomeForm : Form
    {

        private LoggedInUser currentUser;

        private string currentModule = string.Empty;

        public HomeForm(LoggedInUser user)
        {
            InitializeComponent();

            dgvInfo.DataBindingComplete += (s, e) => {
                dgvInfo.ClearSelection();
                dgvInfo.CurrentCell = null;
            };

            currentUser = user;

            lblWelcome.Text = "Welcome back, " + currentUser.FirstName + " " + currentUser.LastName + "!";

            lblSystem.Text = currentUser.UserTypeName + " | Gaming Café Management System";

            SetPermissions();

            LoadDashboard();
        }

        private void SetPermissions()
        {
            if (currentUser.UserTypeName == "Admin")
            {

            }
            else if (currentUser.UserTypeName == "Manager")
            {
                HideButtonRow(btnUsers);

                btnDelete.Enabled = false;
            }
            else if (currentUser.UserTypeName == "Staff")
            {
                HideButtonRow(btnUsers);
                HideButtonRow(btnDevices);
                HideButtonRow(btnGames);

                btnUpdate.Enabled = true;

                btnDelete.Enabled = false;
            }
        }
        private void HideButtonRow(Button button)
        {
            int row =
              tblpnlBtns.GetRow(button);

            button.Visible = false;

            tblpnlBtns.RowStyles[row].Height = 0;

            tblpnlBtns.RowStyles[row].SizeType =
              SizeType.Absolute;
        }

        private void DisableSorting()
        {
            foreach (DataGridViewColumn column in dgvInfo.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void LoadData(string query)
        {
            DBAccessHelper db = new DBAccessHelper();

            ResultSet result = db.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }

            dgvInfo.DataSource = result.Data;

            DisableSorting();
        }

        private void LoadCurrentModule()
        {
            switch (currentModule)
            {
                case "Dashboard":
                    LoadDashboard();
                    break;

                case "Users":
                    LoadUsersData();
                    break;

                case "Bookings":
                    LoadBookingsData();
                    break;

                case "Devices":
                    LoadDevicesData();
                    break;

                case "Food Items":
                    LoadFoodItemsData();
                    break;

                case "Payments":
                    LoadPaymentsData();
                    break;

                case "Games":
                    LoadGamesData();
                    break;
            }
        }

        private void LoadUsersData()
        {
            LoadData(
              "SELECT " +
              "Users.UserID AS [Reference No.], " +
              "Users.Username, " +
              "'********' AS [Password], " +
              "Users.FirstName AS [First Name], " +
              "Users.LastName AS [Last Name], " +
              "Users.DateOfBirth AS [Date Of Birth], " +
              "Users.Email, " +
              "Users.PhoneNumber AS [Phone Number], " +
              "Users.Address, " +
              "Users.CreatedAt AS [Created Date], " +
              "CASE WHEN Users.IsActive = 1 THEN 'Active' ELSE 'Inactive' END AS Status, " +
              "UserType.UserTypeName AS [Role] " +
              "FROM Users " +
              "JOIN UserType ON Users.UserTypeID = UserType.UserTypeID"
            );
        }

        private void LoadBookingsData()
        {
            LoadData(
              "SELECT " +
              "Booking.BookingID AS [Booking No.], " +
              "Booking.CustomerName AS [Customer Name], " +
              "Booking.CustomerPhone AS [Customer Phone], " +
              "Users.FirstName + ' ' + Users.LastName AS [Handled By], " +
              "Device.DeviceID AS [Device No.], " +
              "Device.DeviceName AS [Device Name], " +
              "Booking.StartTime AS [Start Time], " +
              "Booking.EndTime AS [End Time], " +
              "ROUND(Booking.TotalHours, 2) AS [Total Hours], " +
              "Booking.BookingDate AS [Booking Date], " +
              "Booking.BookingStatus AS [Booking Status], " +
              "Booking.Notes AS [Notes] " +
              "FROM Booking " +
              "JOIN Users ON Booking.UserID = Users.UserID " +
              "JOIN Device ON Booking.DeviceID = Device.DeviceID"
            );
        }

        private void LoadDevicesData()
        {
            LoadData(
              "SELECT " +
              "Device.DeviceID AS [Device No.], " +
              "Device.DeviceName AS [Device Name], " +
              "DeviceCategory.CategoryName AS [Category], " +
              "CAST(ROUND(Device.HourlyRate, 2) AS DECIMAL(10,2)) AS [Hourly Rate], " +
              "Device.Status, " +
              "Device.LocationNumber AS [Location Number] " +

              "FROM Device " +

              "LEFT JOIN DeviceCategoryMap " +
              "ON Device.DeviceID = DeviceCategoryMap.DeviceID " +

              "LEFT JOIN DeviceCategory " +
              "ON DeviceCategoryMap.CategoryID = DeviceCategory.CategoryID"
            );
        }

        private void LoadFoodItemsData()
        {
            LoadData(
              "SELECT " +

              "FoodItem.FoodID AS [Food No.], " +
              "FoodItem.FoodName AS [Food Name], " +

              "STRING_AGG(FoodCategory.CategoryName, ', ') " +
              "AS [Category], " +

              "CAST(ROUND(FoodItem.Price, 2) AS DECIMAL(10,2)) " +
              "AS [Unit Price], " +

              "FoodItem.Quantity AS [Quantity], " +

              "CAST(ROUND(FoodItem.Price * FoodItem.Quantity, 2) " +
              "AS DECIMAL(10,2)) AS [Total Price], " +

              "Booking.CustomerName AS [Customer Name], " +
              "Booking.BookingStatus AS [Booking Status], " +
              "Booking.BookingID AS [Booking No.] " +

              "FROM FoodItem " +

              "LEFT JOIN FoodItemCategory " +
              "ON FoodItem.FoodID = FoodItemCategory.FoodID " +

              "LEFT JOIN FoodCategory " +
              "ON FoodItemCategory.CategoryID = FoodCategory.CategoryID " +

              "LEFT JOIN Booking " +
              "ON FoodItem.BookingID = Booking.BookingID " +

              "GROUP BY " +
              "FoodItem.FoodID, " +
              "FoodItem.FoodName, " +
              "FoodItem.Price, " +
              "FoodItem.Quantity, " +
              "Booking.CustomerName, " +
              "Booking.BookingStatus, " +
              "Booking.BookingID"
            );
        }

        private void LoadPaymentsData()
        {
            LoadData(

              "SELECT " +

              "Payment.PaymentID AS [Payment No.], " +
              "Payment.BookingID AS [Booking No.], " +

              "Booking.CustomerName AS [Customer Name], " +

              "ISNULL(Device.DeviceName, 'No Device') " +
              "AS [Device], " +

              "CAST(ROUND(Booking.TotalHours, 2) " +
              "AS DECIMAL(10,2)) AS [Total Hours], " +

              "CAST(ROUND(CASE " +
              "WHEN Booking.BookingStatus = 'Cancelled' " +
              "THEN 0 " +
              "ELSE ISNULL(Device.HourlyRate,0) * Booking.TotalHours " +
              "END, 2) AS DECIMAL(10,2)) " +
              "AS [Device Charge], " +

              "CAST(ROUND(ISNULL(FoodTotals.FoodCharge, 0), 2) " +
              "AS DECIMAL(10,2)) AS [Food Charge], " +

              "CAST(ROUND(Payment.PaymentAmount, 2) " +
              "AS DECIMAL(10,2)) AS [Total Amount], " +

              "Payment.PaymentMethod AS [Payment Method], " +
              "Payment.PaymentDate AS [Payment Date], " +
              "Payment.PaymentStatus AS [Payment Status], " +
              "Booking.BookingStatus AS [Booking Status], " +

              "ISNULL(Booking.Notes, '') AS [Notes] " +

              "FROM Payment " +

              "INNER JOIN Booking " +
              "ON Payment.BookingID = Booking.BookingID " +

              "LEFT JOIN Device " +
              "ON Booking.DeviceID = Device.DeviceID " +

              "LEFT JOIN ( " +

              "SELECT " +
              "BookingID, " +
              "SUM(Price * Quantity) AS FoodCharge " +

              "FROM FoodItem " +

              "GROUP BY BookingID " +

              ") FoodTotals " +

              "ON Booking.BookingID = FoodTotals.BookingID"

            );
        }

        private void LoadGamesData()
        {
            LoadData(
              "SELECT " +
              "Games.GameID AS [Game No.], " +
              "Games.GameName AS [Game Name], " +
              "Games.GamePlatform AS [Platform], " +
              "Games.Genre, " +
              "ISNULL(Device.DeviceName, 'No Device Assigned') AS [Device] " +

              "FROM Games " +

              "LEFT JOIN DeviceGames ON Games.GameID = DeviceGames.GameID " +
              "LEFT JOIN Device ON DeviceGames.DeviceID = Device.DeviceID"
            );
        }

        private void LoadDashboard()
        {
            currentModule = "Dashboard";

            lblInfo.Text = "Dashboard Overview";

            txtSearch.Text = "Search Dashboard...";

            ResetButtonColors();

            btnDashboard.BackColor =
              Color.FromArgb(75, 100, 145);

            LoadData(

              "SELECT " +

              "Device.DeviceName AS [Device], " +

              "CASE " +
              "WHEN Device.Status = 'Available' THEN 'No Current Customer' " +
              "ELSE ISNULL(B.CustomerName, 'Unknown') " +
              "END AS [Current Customer], " +

              "Device.Status AS [Status], " +

              "CASE " +
              "WHEN B.BookingStatus = 'Active' " +
              "THEN CONVERT(VARCHAR, B.EndTime, 100) " +
              "ELSE 'N/A' " +
              "END AS [Session Ends], " +

              "CAST(ROUND(Device.HourlyRate, 2) AS DECIMAL(10,2)) " +
              "AS [Hourly Rate], " +

              "ISNULL(GameList.Games, 'No Game Assigned') " +
              "AS [Current Games] " +

              "FROM Device " +

              "OUTER APPLY ( " +
              "SELECT TOP 1 * FROM Booking " +
              "WHERE Booking.DeviceID = Device.DeviceID " +
              "ORDER BY " +
              "CASE " +
              "WHEN Booking.BookingStatus = 'Active' THEN 1 " +
              "ELSE 2 " +
              "END, " +
              "Booking.BookingID DESC " +
              ") B " +

              "OUTER APPLY ( " +
              "SELECT STRING_AGG(Games.GameName, ', ') AS Games " +
              "FROM DeviceGames " +
              "INNER JOIN Games " +
              "ON DeviceGames.GameID = Games.GameID " +
              "WHERE DeviceGames.DeviceID = Device.DeviceID " +
              ") GameList " +

              "WHERE Device.Status IN " +
              "('Available', 'Occupied', 'Reserved') " +

              "ORDER BY " +

              "CASE " +
              "WHEN Device.Status = 'Occupied' THEN 1 " +
              "WHEN Device.Status = 'Reserved' THEN 2 " +
              "ELSE 3 " +
              "END, " +

              "Device.DeviceName"
            );
        }

        private void ResetButtonColors()
        {
            btnDashboard.BackColor = Color.FromArgb(50, 65, 90);

            btnUsers.BackColor = Color.FromArgb(220, 60, 90);

            btnBookings.BackColor = Color.FromArgb(220, 60, 90);

            btnDevices.BackColor = Color.FromArgb(220, 60, 90);

            btnFoodItems.BackColor = Color.FromArgb(220, 60, 90);

            btnPayments.BackColor = Color.FromArgb(220, 60, 90);

            btnGames.BackColor = Color.FromArgb(220, 60, 90);
        }

        private void ModuleButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            ResetButtonColors();

            btn.BackColor = Color.FromArgb(85, 110, 160);

            currentModule = btn.Text;

            lblInfo.Text = btn.Text;

            txtSearch.Text = "Search " + btn.Text + "...";

            if (currentUser.UserTypeName == "Manager")
            {
                if (btn.Text == "Games")
                {
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnDelete.Enabled = false;
                }
            }

            switch (btn.Text)
            {
                case "Users":
                    LoadUsersData();
                    break;

                case "Bookings":
                    LoadBookingsData();
                    break;

                case "Devices":
                    LoadDevicesData();
                    break;

                case "Food Items":
                    LoadFoodItemsData();
                    break;

                case "Payments":
                    LoadPaymentsData();
                    break;

                case "Games":
                    LoadGamesData();
                    break;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentModule))
            {
                currentModule = "Dashboard";
            }

            txtSearch.Text = "Search " + currentModule + "...";

            LoadCurrentModule();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text.StartsWith("Search"))
            {
                txtSearch.Clear();
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                if (string.IsNullOrEmpty(currentModule))
                {
                    txtSearch.Text = "Search...";
                }
                else
                {
                    txtSearch.Text = "Search " + currentModule + "...";
                }
            }
        }

        private void SearchModuleData()
        {
            string searchText = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText) || searchText.StartsWith("Search"))
            {
                return;
            }

            string query = "";

            switch (currentModule)
            {
                case "Dashboard":

                    query =
                      "SELECT " +

                      "Device.DeviceName AS [Device], " +

                      "CASE " +
                      "WHEN Device.Status = 'Available' THEN 'No Current Customer' " +
                      "ELSE ISNULL(B.CustomerName, 'Unknown') " +
                      "END AS [Current Customer], " +

                      "Device.Status AS [Status], " +

                      "CASE " +
                      "WHEN B.BookingStatus = 'Active' " +
                      "THEN CONVERT(VARCHAR, B.EndTime, 100) " +
                      "ELSE 'N/A' " +
                      "END AS [Session Ends], " +

                      "CAST(ROUND(Device.HourlyRate, 2) AS DECIMAL(10,2)) " +
                      "AS [Hourly Rate], " +

                      "ISNULL(GameList.Games, 'No Game Assigned') " +
                      "AS [Current Games] " +

                      "FROM Device " +

                      "OUTER APPLY ( " +
                      "SELECT TOP 1 * FROM Booking " +
                      "WHERE Booking.DeviceID = Device.DeviceID " +
                      "ORDER BY " +
                      "CASE " +
                      "WHEN Booking.BookingStatus = 'Active' THEN 1 " +
                      "ELSE 2 " +
                      "END, " +
                      "Booking.BookingID DESC " +
                      ") B " +

                      "OUTER APPLY ( " +
                      "SELECT STRING_AGG(Games.GameName, ', ') AS Games " +
                      "FROM DeviceGames " +
                      "INNER JOIN Games " +
                      "ON DeviceGames.GameID = Games.GameID " +
                      "WHERE DeviceGames.DeviceID = Device.DeviceID " +
                      ") GameList " +

                      "WHERE " +

                      "Device.DeviceName LIKE '%" + searchText + "%' OR " +

                      "Device.Status LIKE '%" + searchText + "%' OR " +

                      "ISNULL(B.CustomerName, 'Unknown') LIKE '%" + searchText + "%' OR " +

                      "ISNULL(GameList.Games, 'No Game Assigned') LIKE '%" + searchText + "%' OR " +

                      "CAST(Device.HourlyRate AS VARCHAR) LIKE '%" + searchText + "%' OR " +

                      "ISNULL(B.BookingStatus, '') LIKE '%" + searchText + "%' " +

                      "ORDER BY " +

                      "CASE " +
                      "WHEN Device.Status = 'Occupied' THEN 1 " +
                      "WHEN Device.Status = 'Reserved' THEN 2 " +
                      "ELSE 3 " +
                      "END, " +

                      "Device.DeviceName";

                    break;

                case "Users":

                    query =
                      "SELECT " +
                      "Users.UserID AS [Reference No.], " +
                      "Users.Username, " +
                      "'********' AS [Password], " +
                      "Users.FirstName AS [First Name], " +
                      "Users.LastName AS [Last Name], " +
                      "Users.DateOfBirth AS [Date Of Birth], " +
                      "Users.Email, " +
                      "Users.PhoneNumber AS [Phone Number], " +
                      "Users.Address, " +
                      "Users.CreatedAt AS [Created Date], " +

                      "CASE WHEN Users.IsActive = 1 THEN 'Active' ELSE 'Inactive' END AS Status, " +

                      "UserType.UserTypeName AS [Role] " +

                      "FROM Users " +

                      "JOIN UserType ON Users.UserTypeID = UserType.UserTypeID " +

                      "WHERE " +
                      "CAST(Users.UserID AS VARCHAR) LIKE '%" + searchText + "%' OR " +
                      "Users.Username LIKE '%" + searchText + "%' OR " +
                      "Users.FirstName LIKE '%" + searchText + "%' OR " +
                      "Users.LastName LIKE '%" + searchText + "%' OR " +
                      "CAST(Users.DateOfBirth AS VARCHAR) LIKE '%" + searchText + "%' OR " +
                      "Users.Email LIKE '%" + searchText + "%' OR " +
                      "Users.PhoneNumber LIKE '%" + searchText + "%' OR " +
                      "Users.Address LIKE '%" + searchText + "%' OR " +
                      "CAST(Users.CreatedAt AS VARCHAR) LIKE '%" + searchText + "%' OR " +
                      "UserType.UserTypeName LIKE '%" + searchText + "%' OR " +
                      "CASE WHEN Users.IsActive = 1 THEN 'Active' ELSE 'Inactive' END LIKE '%" + searchText + "%'";

                    break;

                case "Bookings":

                    query =
                      "SELECT " +
                      "Booking.BookingID AS [Booking No.], " +
                      "Booking.CustomerName AS [Customer Name], " +
                      "Booking.CustomerPhone AS [Customer Phone], " +
                      "Users.FirstName + ' ' + Users.LastName AS [Handled By], " +
                      "Device.DeviceID AS [Device No.], " +
                      "Device.DeviceName AS [Device Name], " +
                      "Booking.StartTime AS [Start Time], " +
                      "Booking.EndTime AS [End Time], " +
                      "ROUND(Booking.TotalHours, 2) AS [Total Hours], " +
                      "Booking.BookingDate AS [Booking Date], " +
                      "Booking.BookingStatus AS [Booking Status], " +
                      "Booking.Notes AS [Notes] " +

                      "FROM Booking " +
                      "JOIN Users ON Booking.UserID = Users.UserID " +
                      "JOIN Device ON Booking.DeviceID = Device.DeviceID " +

                      "WHERE " +
                      "CAST(Booking.BookingID AS VARCHAR) LIKE '%" + searchText + "%' OR " +
                      "Booking.CustomerName LIKE '%" + searchText + "%' OR " +
                      "Booking.CustomerPhone LIKE '%" + searchText + "%' OR " +
                      "(Users.FirstName + ' ' + Users.LastName) LIKE '%" + searchText + "%' OR " +
                      "Device.DeviceName LIKE '%" + searchText + "%' OR " +
                      "CAST(Device.DeviceID AS VARCHAR) LIKE '%" + searchText + "%' OR " +
                      "CAST(Booking.StartTime AS VARCHAR) LIKE '%" + searchText + "%' OR " +
                      "CAST(Booking.EndTime AS VARCHAR) LIKE '%" + searchText + "%' OR " +
                      "CAST(Booking.TotalHours AS VARCHAR) LIKE '%" + searchText + "%' OR " +
                      "CAST(Booking.BookingDate AS VARCHAR) LIKE '%" + searchText + "%' OR " +
                      "Booking.BookingStatus LIKE '%" + searchText + "%' OR " +
                      "Booking.Notes LIKE '%" + searchText + "%'";

                    break;

                case "Devices":

                    query =
                      "SELECT " +
                      "Device.DeviceID AS [Device No.], " +
                      "Device.DeviceName AS [Device Name], " +
                      "DeviceCategory.CategoryName AS [Category], " +
                      "CAST(ROUND(Device.HourlyRate, 2) AS DECIMAL(10,2)) AS [Hourly Rate], " +
                      "Device.Status, " +
                      "Device.LocationNumber AS [Location Number] " +

                      "FROM Device " +

                      "LEFT JOIN DeviceCategoryMap " +
                      "ON Device.DeviceID = DeviceCategoryMap.DeviceID " +

                      "LEFT JOIN DeviceCategory " +
                      "ON DeviceCategoryMap.CategoryID = DeviceCategory.CategoryID " +

                      "WHERE " +
                      "CAST(Device.DeviceID AS VARCHAR) LIKE '%" + searchText + "%' OR " +
                      "Device.DeviceName LIKE '%" + searchText + "%' OR " +
                      "ISNULL(DeviceCategory.CategoryName, '') LIKE '%" + searchText + "%' OR " +
                      "CAST(Device.HourlyRate AS VARCHAR) LIKE '%" + searchText + "%' OR " +
                      "Device.Status LIKE '%" + searchText + "%' OR " +
                      "CAST(Device.LocationNumber AS VARCHAR) LIKE '%" + searchText + "%'";

                    break;

                case "Food Items":

                    query =
                      "SELECT " +

                      "FoodItem.FoodID AS [Food No.], " +
                      "FoodItem.FoodName AS [Food Name], " +

                      "STRING_AGG(FoodCategory.CategoryName, ', ') " +
                      "AS [Category], " +

                      "CAST(ROUND(FoodItem.Price, 2) AS DECIMAL(10,2)) " +
                      "AS [Unit Price], " +

                      "FoodItem.Quantity AS [Quantity], " +

                      "CAST(ROUND(FoodItem.Price * FoodItem.Quantity, 2) " +
                      "AS DECIMAL(10,2)) AS [Total Price], " +

                      "Booking.CustomerName AS [Customer Name], " +
                      "Booking.BookingStatus AS [Booking Status], " +
                      "Booking.BookingID AS [Booking No.] " +

                      "FROM FoodItem " +

                      "LEFT JOIN FoodItemCategory " +
                      "ON FoodItem.FoodID = FoodItemCategory.FoodID " +

                      "LEFT JOIN FoodCategory " +
                      "ON FoodItemCategory.CategoryID = FoodCategory.CategoryID " +

                      "LEFT JOIN Booking " +
                      "ON FoodItem.BookingID = Booking.BookingID " +

                      "WHERE " +
                      "CAST(FoodItem.FoodID AS VARCHAR) LIKE '%" + searchText + "%' OR " +
                      "FoodItem.FoodName LIKE '%" + searchText + "%' OR " +
                      "ISNULL(FoodCategory.CategoryName, '') LIKE '%" + searchText + "%' OR " +
                      "CAST(FoodItem.Price AS VARCHAR) LIKE '%" + searchText + "%' OR " +
                      "CAST(FoodItem.Quantity AS VARCHAR) LIKE '%" + searchText + "%' OR " +
                      "CAST((FoodItem.Price * FoodItem.Quantity) AS VARCHAR) LIKE '%" + searchText + "%' OR " +
                      "ISNULL(Booking.CustomerName, '') LIKE '%" + searchText + "%' OR " +
                      "ISNULL(Booking.BookingStatus, '') LIKE '%" + searchText + "%' OR " +
                      "CAST(Booking.BookingID AS VARCHAR) LIKE '%" + searchText + "%' " +

                      "GROUP BY " +
                      "FoodItem.FoodID, " +
                      "FoodItem.FoodName, " +
                      "FoodItem.Price, " +
                      "FoodItem.Quantity, " +
                      "Booking.CustomerName, " +
                      "Booking.BookingStatus, " +
                      "Booking.BookingID";

                    break;

                case "Payments":

                    query =
                      "SELECT " +

                      "Payment.PaymentID AS [Payment No.], " +
                      "Booking.BookingID AS [Booking No.], " +
                      "Booking.CustomerName AS [Customer Name], " +

                      "ISNULL(Device.DeviceName, 'No Device') " +
                      "AS [Device], " +

                      "CAST(ROUND(Booking.TotalHours, 2) " +
                      "AS DECIMAL(10,2)) AS [Total Hours], " +

                      "CAST(ROUND(CASE " +
                      "WHEN Booking.BookingStatus = 'Cancelled' THEN 0 " +
                      "ELSE ISNULL(Device.HourlyRate,0) * Booking.TotalHours " +
                      "END, 2) AS DECIMAL(10,2)) " +
                      "AS [Device Charge], " +

                      "CAST(ROUND(ISNULL(FoodTotals.FoodCharge, 0), 2) " +
                      "AS DECIMAL(10,2)) AS [Food Charge], " +

                      "CAST(ROUND(Payment.PaymentAmount, 2) " +
                      "AS DECIMAL(10,2)) AS [Total Amount], " +

                      "Payment.PaymentMethod AS [Payment Method], " +
                      "Payment.PaymentDate AS [Payment Date], " +
                      "Payment.PaymentStatus AS [Payment Status], " +
                      "Booking.BookingStatus AS [Booking Status], " +

                      "ISNULL(Booking.Notes, '') AS [Notes] " +

                      "FROM Payment " +

                      "INNER JOIN Booking " +
                      "ON Payment.BookingID = Booking.BookingID " +

                      "LEFT JOIN Device " +
                      "ON Booking.DeviceID = Device.DeviceID " +

                      "LEFT JOIN ( " +

                      "SELECT " +
                      "BookingID, " +
                      "SUM(Price * Quantity) AS FoodCharge " +

                      "FROM FoodItem " +

                      "GROUP BY BookingID " +

                      ") FoodTotals " +

                      "ON Booking.BookingID = FoodTotals.BookingID " +

                      "WHERE " +

                      "CAST(Payment.PaymentID AS VARCHAR) " +
                      "LIKE '%" + searchText + "%' OR " +

                      "CAST(Booking.BookingID AS VARCHAR) " +
                      "LIKE '%" + searchText + "%' OR " +

                      "ISNULL(Booking.CustomerName, '') " +
                      "LIKE '%" + searchText + "%' OR " +

                      "ISNULL(Device.DeviceName, '') " +
                      "LIKE '%" + searchText + "%' OR " +

                      "CAST(Booking.TotalHours AS VARCHAR) " +
                      "LIKE '%" + searchText + "%' OR " +

                      "CAST(CASE " +
                      "WHEN Booking.BookingStatus = 'Cancelled' THEN 0 " +
                      "ELSE ISNULL(Device.HourlyRate,0) * Booking.TotalHours " +
                      "END AS VARCHAR) " +
                      "LIKE '%" + searchText + "%' OR " +

                      "CAST(ISNULL(FoodTotals.FoodCharge, 0) AS VARCHAR) " +
                      "LIKE '%" + searchText + "%' OR " +

                      "CAST(Payment.PaymentAmount AS VARCHAR) " +
                      "LIKE '%" + searchText + "%' OR " +

                      "ISNULL(Payment.PaymentMethod, '') " +
                      "LIKE '%" + searchText + "%' OR " +

                      "CAST(Payment.PaymentDate AS VARCHAR) " +
                      "LIKE '%" + searchText + "%' OR " +

                      "ISNULL(Payment.PaymentStatus, '') " +
                      "LIKE '%" + searchText + "%' OR " +

                      "ISNULL(Booking.BookingStatus, '') " +
                      "LIKE '%" + searchText + "%' OR " +

                      "ISNULL(Booking.Notes, '') " +
                      "LIKE '%" + searchText + "%'";

                    break;

                case "Games":

                    query =
                      "SELECT " +
                      "Games.GameID AS [Game No.], " +
                      "Games.GameName AS [Game Name], " +
                      "Games.GamePlatform AS [Platform], " +
                      "Games.Genre, " +
                      "ISNULL(Device.DeviceName, 'No Device Assigned') AS [Available Device] " +

                      "FROM Games " +

                      "LEFT JOIN DeviceGames " +
                      "ON Games.GameID = DeviceGames.GameID " +

                      "LEFT JOIN Device " +
                      "ON DeviceGames.DeviceID = Device.DeviceID " +

                      "WHERE " +
                      "CAST(Games.GameID AS VARCHAR) LIKE '%" + searchText + "%' OR " +
                      "Games.GameName LIKE '%" + searchText + "%' OR " +
                      "Games.GamePlatform LIKE '%" + searchText + "%' OR " +
                      "Games.Genre LIKE '%" + searchText + "%' OR " +
                      "ISNULL(Device.DeviceName, '') LIKE '%" + searchText + "%'";

                    break;
            }

            DBAccessHelper db = new DBAccessHelper();

            ResultSet result = db.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show(result.Message);

                return;
            }

            if (result.Data.Rows.Count == 0)
            {
                dgvInfo.DataSource = null;

                MessageBox.Show(
                  "No matching records found.",
                  "Search Result",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information
                );

                return;
            }

            dgvInfo.DataSource = result.Data;

            DisableSorting();

            dgvInfo.ClearSelection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchModuleData();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                  "Logging out...\nSee you again at Café De Naegus ;)",
                  "Logout",
                  MessageBoxButtons.OKCancel,
                  MessageBoxIcon.Information
                );

                if (result == DialogResult.OK)
                {
                    currentUser = null;

                    this.Close();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(
                  exp.Message,
                  "Logout Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                );
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (currentModule)
            {
                case "Users":

                    AddUserForm addUserForm = new AddUserForm();

                    addUserForm.ShowDialog();

                    break;

                case "Bookings":

                    AddBookingForm addBookingForm = new AddBookingForm(currentUser);

                    addBookingForm.ShowDialog();

                    break;

                case "Devices":

                    AddDeviceForm addDeviceForm = new AddDeviceForm(currentUser);

                    addDeviceForm.ShowDialog();

                    break;

                case "Food Items":

                    AddFoodItemForm addFoodItemForm = new AddFoodItemForm(currentUser);

                    addFoodItemForm.ShowDialog();

                    break;

                case "Payments":

                    AddPaymentForm form = new AddPaymentForm(currentUser);

                    form.ShowDialog();

                    break;

                case "Games":

                    AddGamesForm addGameForm = new AddGamesForm(currentUser);

                    addGameForm.ShowDialog();

                    break;

                default:

                    MessageBox.Show(
                      "Please select a module first.",
                      "No Module Selected",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information
                    );

                    break;
            }

            LoadCurrentModule();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            switch (currentModule)
            {
                case "Users":

                    if (dgvInfo.SelectedRows.Count == 0)
                    {
                        MessageBox.Show(
                          "Please select a user first.",
                          "No User Selected",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning
                        );
                        return;
                    }

                    DataGridViewRow row = dgvInfo.SelectedRows[0];

                    int userID = Convert.ToInt32(row.Cells["Reference No."].Value);

                    string username = row.Cells["Username"].Value?.ToString() ?? "";
                    string firstName = row.Cells["First Name"].Value?.ToString() ?? "";
                    string lastName = row.Cells["Last Name"].Value?.ToString() ?? "";
                    string email = row.Cells["Email"].Value?.ToString() ?? "";
                    string phone = row.Cells["Phone Number"].Value?.ToString() ?? "";
                    string address = row.Cells["Address"].Value?.ToString() ?? "";
                    string role = (row.Cells["Role"].Value?.ToString() ?? "").Trim();

                    string statusText = row.Cells["Status"].Value?.ToString() ?? "Inactive";
                    int isActive = statusText == "Active" ? 1 : 0;

                    DateTime dob;
                    if (!DateTime.TryParse(row.Cells["Date Of Birth"].Value?.ToString(), out dob))
                    {
                        dob = DateTime.Now;
                    }

                    UpdateUserForm updateUserForm = new UpdateUserForm(
                      userID,
                      username,
                      firstName,
                      lastName,
                      email,
                      phone,
                      address,
                      role,
                      isActive,
                      dob
                    );

                    updateUserForm.ShowDialog();

                    break;

                case "Bookings":

                    if (dgvInfo.SelectedRows.Count == 0)
                    {
                        MessageBox.Show(
                          "Please select a booking first.",
                          "No Booking Selected",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning
                        );
                        return;
                    }

                    row = dgvInfo.SelectedRows[0];

                    if (!int.TryParse(row.Cells["Booking No."].Value?.ToString(), out int bookingId))
                    {
                        MessageBox.Show("Invalid booking selected.");
                        return;
                    }

                    string customerName = row.Cells["Customer Name"].Value?.ToString() ?? "";
                    string customerPhone = row.Cells["Customer Phone"].Value?.ToString() ?? "";
                    string handledBy = row.Cells["Handled By"].Value?.ToString() ?? "";

                    DateTime startTime = DateTime.TryParse(
                      row.Cells["Start Time"].Value?.ToString(),
                      out DateTime st) ? st : DateTime.Now;

                    DateTime endTime = DateTime.TryParse(
                      row.Cells["End Time"].Value?.ToString(),
                      out DateTime et) ? et : DateTime.Now.AddHours(1);

                    double totalHours = double.TryParse(
                      row.Cells["Total Hours"].Value?.ToString(),
                      out double th) ? th : 0;

                    DateTime bookingDate = DateTime.TryParse(
                      row.Cells["Booking Date"].Value?.ToString(),
                      out DateTime bd) ? bd : DateTime.Now;

                    string status = row.Cells["Booking Status"].Value?.ToString() ?? "";
                    string notes = row.Cells["Notes"].Value?.ToString() ?? "";

                    int deviceId = 0;

                    if (row.Cells["Device No."] != null)
                    {
                        int.TryParse(row.Cells["Device No."].Value?.ToString(), out deviceId);
                    }

                    AddBookingForm updateBookingForm = new AddBookingForm(
                      bookingId,
                      deviceId,
                      customerName,
                      customerPhone,
                      startTime,
                      endTime,
                      bookingDate,
                      totalHours,
                      status,
                      notes
                    );

                    updateBookingForm.ShowDialog();

                    break;

                case "Devices":

                    if (dgvInfo.SelectedRows.Count == 0)
                    {
                        MessageBox.Show(
                          "Please select a device first.",
                          "No Device Selected",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning
                        );
                        return;
                    }

                    row = dgvInfo.SelectedRows[0];

                    int deviceID = Convert.ToInt32(row.Cells["Device No."].Value);

                    string name = row.Cells["Device Name"].Value?.ToString() ?? "";
                    string category = row.Cells["Category"].Value?.ToString() ?? "";
                    status = row.Cells["Status"].Value?.ToString() ?? "";
                    string locationNumber = row.Cells["Location Number"].Value?.ToString() ?? "";

                    double hourlyRate = 0;
                    double.TryParse(row.Cells["Hourly Rate"].Value?.ToString(), out hourlyRate);

                    AddDeviceForm updateDeviceForm = new AddDeviceForm(
                      deviceID,
                      name,
                      category,
                      status,
                      locationNumber,
                      hourlyRate
                    );

                    updateDeviceForm.ShowDialog();

                    break;

                case "Games":

                    if (dgvInfo.SelectedRows.Count == 0)
                    {
                        MessageBox.Show(
                          "Please select a game first.",
                          "No Game Selected",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning
                        );
                        return;
                    }

                    row = dgvInfo.SelectedRows[0];

                    int gameID = Convert.ToInt32(row.Cells["Game No."].Value);

                    string gameName = row.Cells["Game Name"].Value?.ToString() ?? "";
                    string platform = row.Cells["Platform"].Value?.ToString() ?? "";
                    string genre = row.Cells["Genre"].Value?.ToString() ?? "";
                    string deviceName = row.Cells["Device"].Value?.ToString() ?? "";

                    deviceID = 0;

                    if (!string.IsNullOrWhiteSpace(deviceName) &&
                      deviceName != "No Device Assigned")
                    {
                        DBAccessHelper db = new DBAccessHelper();

                        string query =
                          "SELECT DeviceID FROM Device " +
                          "WHERE DeviceName = '" +
                          deviceName.Replace("'", "''") + "'";

                        ResultSet result = db.GetQueryData(query);

                        if (!result.HasError &&
                          result.Data != null &&
                          result.Data.Rows.Count > 0)
                        {
                            deviceID = Convert.ToInt32(
                              result.Data.Rows[0]["DeviceID"]
                            );
                        }
                    }

                    AddGamesForm updateGameForm = new AddGamesForm(
                      gameID,
                      deviceID,
                      gameName,
                      platform,
                      genre
                    );

                    updateGameForm.ShowDialog();

                    break;

                case "Food Items":

                    if (dgvInfo.SelectedRows.Count == 0)
                    {
                        MessageBox.Show(
                          "Please select a food item first.",
                          "No Food Item Selected",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning
                        );

                        return;
                    }

                    row = dgvInfo.SelectedRows[0];

                    if (!int.TryParse(
                        row.Cells["Food No."].Value?.ToString(),
                        out int foodID))
                    {
                        MessageBox.Show("Invalid food item selected.");
                        return;
                    }

                    if (!int.TryParse(
                        row.Cells["Booking No."].Value?.ToString(),
                        out int bookingID))
                    {
                        MessageBox.Show("Invalid booking linked to food item.");
                        return;
                    }

                    string foodName =
                      row.Cells["Food Name"].Value?.ToString() ?? "";

                    double price =
                      double.TryParse(
                        row.Cells["Unit Price"].Value?.ToString(),
                        out double p) ? p : 0;

                    int quantity =
                      int.TryParse(
                        row.Cells["Quantity"].Value?.ToString(),
                        out int q) ? q : 1;

                    AddFoodItemForm updateFoodItemForm =
                      new AddFoodItemForm(
                        currentUser,
                        foodID,
                        bookingID,
                        foodName,
                        price,
                        quantity
                      );

                    updateFoodItemForm.ShowDialog();

                    break;

                case "Payments":

                    if (dgvInfo.SelectedRows.Count == 0)
                    {
                        MessageBox.Show(
                          "Please select a payment first.",
                          "No Payment Selected",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning
                        );

                        return;
                    }

                    row = dgvInfo.SelectedRows[0];

                    if (!int.TryParse(
                        row.Cells["Payment No."].Value?.ToString(),
                        out int paymentID))
                    {
                        MessageBox.Show("Invalid payment selected.");
                        return;
                    }

                    if (!int.TryParse(
                        row.Cells["Booking No."].Value?.ToString(),
                        out bookingID))
                    {
                        MessageBox.Show("Invalid booking selected.");
                        return;
                    }

                    customerName =
                      row.Cells["Customer Name"].Value?.ToString() ?? "";

                    deviceName =
                      row.Cells["Device"].Value?.ToString() ?? "";

                    totalHours =
                      double.TryParse(
                        row.Cells["Total Hours"].Value?.ToString(),
                        out th) ? th : 0;

                    double deviceCharge =
                      double.TryParse(
                        row.Cells["Device Charge"].Value?.ToString(),
                        out double dc) ? dc : 0;

                    double foodCharge =
                      double.TryParse(
                        row.Cells["Food Charge"].Value?.ToString(),
                        out double fc) ? fc : 0;

                    double totalAmount =
                      double.TryParse(
                        row.Cells["Total Amount"].Value?.ToString(),
                        out double ta) ? ta : 0;

                    string paymentMethod =
                      row.Cells["Payment Method"].Value?.ToString() ?? "";

                    string paymentStatus =
                      row.Cells["Payment Status"].Value?.ToString() ?? "";

                    DateTime paymentDate =
                      DateTime.TryParse(
                        row.Cells["Payment Date"].Value?.ToString(),
                        out DateTime pd) ? pd : DateTime.Now;

                    AddPaymentForm updatePaymentForm =
                      new AddPaymentForm(
                        currentUser,
                        paymentID,
                        bookingID,
                        customerName,
                        deviceName,
                        totalHours,
                        deviceCharge,
                        foodCharge,
                        totalAmount,
                        paymentMethod,
                        paymentStatus,
                        paymentDate
                      );

                    updatePaymentForm.ShowDialog();

                    break;

                default:

                    MessageBox.Show(
                      "Please select a module first.",
                      "No Module Selected",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information
                    );

                    break;
            }

            LoadCurrentModule();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            switch (currentModule)
            {
                case "Users":

                    if (dgvInfo.SelectedRows.Count == 0)
                    {
                        MessageBox.Show(
                          "Please select a user first.",
                          "No User Selected",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning
                        );

                        return;
                    }

                    DataGridViewRow row = dgvInfo.SelectedRows[0];

                    if (!int.TryParse(
                        row.Cells["Reference No."].Value?.ToString(),
                        out int userId))
                    {
                        MessageBox.Show("Invalid user selected.");
                        return;
                    }

                    string userType =
                      row.Cells["Role"].Value?.ToString() ?? "";

                    string username =
                      row.Cells["Username"].Value?.ToString() ?? "";

                    if (userType.Equals(
                        "Admin",
                        StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show(
                          "Admin accounts cannot be deleted.",
                          "Delete Blocked",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning
                        );

                        return;
                    }

                    DialogResult confirmResult =
                      MessageBox.Show(
                        "Delete user: " + username + "?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                      );

                    if (confirmResult == DialogResult.No)
                    {
                        return;
                    }

                    DataDeletionHelper deletionHelper =
                      new DataDeletionHelper();

                    ResultSet result =
                      deletionHelper.DeleteUser(userId);

                    if (result.HasError)
                    {
                        MessageBox.Show(
                          result.Message,
                          "Delete Failed",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                          "User deleted successfully.",
                          "Success",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information
                        );
                    }

                    break;

                case "Bookings":

                    int bookingID =
                      Convert.ToInt32(
                        dgvInfo.CurrentRow.Cells["Booking No."].Value
                      );

                    DBAccessHelper db =
                      new DBAccessHelper();

                    int deviceID = 0;

                    ResultSet deviceResult =
                      db.GetQueryData(

                        "SELECT DeviceID " +

                        "FROM Booking " +

                        "WHERE BookingID=" + bookingID
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

                    db.ExecuteNonQuery(

                      "DELETE FROM FoodItemCategory " +

                      "WHERE FoodID IN (" +

                      "SELECT FoodID FROM FoodItem " +

                      "WHERE BookingID=" + bookingID +

                      ")"
                    );

                    db.ExecuteNonQuery(

                      "DELETE FROM FoodItem " +

                      "WHERE BookingID=" + bookingID
                    );

                    db.ExecuteNonQuery(

                      "DELETE FROM Payment " +

                      "WHERE BookingID=" + bookingID
                    );

                    result =
                      db.ExecuteNonQuery(

                        "DELETE FROM Booking " +

                        "WHERE BookingID=" + bookingID
                      );

                    if (result.HasError)
                    {
                        MessageBox.Show(
                          result.Message,
                          "Delete Failed",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error
                        );

                        return;
                    }

                    if (deviceID > 0)
                    {
                        new DataDeletionHelper()
                          .SetDeviceStatus(deviceID, "Available");
                    }

                    MessageBox.Show(
                      "Booking deleted successfully!",
                      "Success",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information
                    );

                    LoadBookingsData();

                    break;

                case "Devices":

                    if (dgvInfo.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Select a device first.");
                        return;
                    }

                    row = dgvInfo.SelectedRows[0];

                    if (!int.TryParse(row.Cells["Device No."].Value?.ToString(), out int deviceId))
                    {
                        MessageBox.Show("Invalid device.");
                        return;
                    }

                    string deviceName = row.Cells["Device Name"].Value?.ToString() ?? "";

                    db = new DBAccessHelper();
                    DataDeletionHelper helper = new DataDeletionHelper();

                    string statusQuery =
                      "SELECT Status FROM Device WHERE DeviceID = " + deviceId;

                    ResultSet statusResult = db.GetQueryData(statusQuery);

                    if (statusResult.HasError || statusResult.Data == null || statusResult.Data.Rows.Count == 0)
                    {
                        MessageBox.Show("Unable to verify device status.");
                        return;
                    }

                    string status = statusResult.Data.Rows[0]["Status"].ToString();

                    if (status == "Occupied" || status == "Active")
                    {
                        MessageBox.Show(
                          "This device is currently in use.\n\n" +
                          "It cannot be deleted while active.\n" +
                          "Please mark it as 'Unavailable' first from the update screen.",
                          "Delete Blocked",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information
                        );

                        return;
                    }

                    bool hasBooking = helper.HasDeviceBooking(deviceId);

                    if (hasBooking)
                    {
                        MessageBox.Show(
                          "This device has booking history.\n\n" +
                          "Please mark it as 'Unavailable' instead of deletion.",
                          "Action Not Allowed",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information
                        );

                        helper.SetDeviceStatus(deviceId, "Unavailable");
                        return;
                    }

                    DialogResult confirm = MessageBox.Show(
                      "Are you sure you want to delete device: " + deviceName + "?",
                      "Confirm Delete",
                      MessageBoxButtons.YesNo,
                      MessageBoxIcon.Warning
                    );

                    if (confirm == DialogResult.No)
                        return;

                    helper.DeleteDeviceCategoryMap(deviceId);
                    helper.DeleteDeviceGameMap(deviceId);
                    helper.DeleteBookingsByDevice(deviceId);

                    result = helper.DeleteDevice(deviceId);

                    if (result.HasError)
                    {
                        MessageBox.Show(result.Message, "Delete Failed");
                    }
                    else
                    {
                        MessageBox.Show("Device deleted successfully.");
                    }

                    break;

                case "Food Items":

                    if (dgvInfo.SelectedRows.Count == 0)
                    {
                        MessageBox.Show(
                          "Please select a food item first.",
                          "No Food Item Selected",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning
                        );

                        return;
                    }

                    row = dgvInfo.SelectedRows[0];

                    if (!int.TryParse(
                        row.Cells["Food No."].Value?.ToString(),
                        out int foodID))
                    {
                        MessageBox.Show("Invalid food item selected.");
                        return;
                    }

                    string foodName =
                      row.Cells["Food Name"].Value?.ToString() ?? "";

                    confirm =
                      MessageBox.Show(
                        "Are you sure you want to delete this food item?\n\n" +
                        "Food: " + foodName,
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                      );

                    if (confirm == DialogResult.No)
                    {
                        return;
                    }

                    db = new DBAccessHelper();

                    result =
                      db.ExecuteNonQuery(
                        "DELETE FROM FoodItemCategory " +
                        "WHERE FoodID = " + foodID
                      );

                    if (result.HasError)
                    {
                        MessageBox.Show(
                          result.Message,
                          "Delete Failed",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error
                        );

                        return;
                    }

                    result =
                      db.ExecuteNonQuery(
                        "DELETE FROM FoodItem " +
                        "WHERE FoodID = " + foodID
                      );

                    if (result.HasError)
                    {
                        MessageBox.Show(
                          result.Message,
                          "Delete Failed",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                          "Food item deleted successfully.",
                          "Success",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information
                        );
                    }

                    break;

                case "Payments":

                    int paymentID =
                      Convert.ToInt32(
                        dgvInfo.CurrentRow.Cells["Payment No."].Value
                      );

                    bookingID =
                      Convert.ToInt32(
                        dgvInfo.CurrentRow.Cells["Booking No."].Value
                      );

                    confirm =
                      MessageBox.Show(
                        "Are you sure you want to delete this payment?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                      );

                    if (confirm == DialogResult.Yes)
                    {
                        db =
                          new DBAccessHelper();

                        deviceID = 0;

                        deviceResult =
                          db.GetQueryData(

                            "SELECT DeviceID " +

                            "FROM Booking " +

                            "WHERE BookingID=" + bookingID
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

                        result =
                          db.ExecuteNonQuery(

                            "DELETE FROM Payment " +

                            "WHERE PaymentID=" + paymentID
                          );

                        if (result.HasError)
                        {
                            MessageBox.Show(
                              result.Message,
                              "Delete Failed",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error
                            );

                            return;
                        }

                        db.ExecuteNonQuery(

                          "UPDATE Booking SET " +

                          "BookingStatus='Active' " +

                          "WHERE BookingID=" + bookingID
                        );

                        if (deviceID > 0)
                        {
                            new DataDeletionHelper()
                              .SetDeviceStatus(deviceID, "Occupied");
                        }

                        MessageBox.Show(
                          "Payment deleted successfully!",
                          "Success",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information
                        );

                        LoadPaymentsData();
                    }

                    break;

                case "Games":

                    if (dgvInfo.SelectedRows.Count == 0)
                    {
                        MessageBox.Show(
                          "Please select a game first.",
                          "No Game Selected",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning
                        );
                        return;
                    }

                    row = dgvInfo.SelectedRows[0];

                    if (!int.TryParse(row.Cells["Game No."].Value?.ToString(), out int gameId))
                    {
                        MessageBox.Show("Invalid game selected.");
                        return;
                    }

                    string gameName = row.Cells["Game Name"].Value?.ToString() ?? "";

                    confirmResult =
                      MessageBox.Show(
                        "Delete game: " + gameName + "?\n\nThis will remove all device assignments.",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                      );

                    if (confirmResult == DialogResult.No)
                        return;

                    deletionHelper = new DataDeletionHelper();

                    result = deletionHelper.DeleteDeviceGameMap(gameId);

                    if (result.HasError)
                    {
                        MessageBox.Show(result.Message, "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    result = deletionHelper.DeleteGame(gameId);

                    if (result.HasError)
                    {
                        MessageBox.Show(
                          result.Message,
                          "Delete Failed",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                          "Game deleted successfully.",
                          "Success",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information
                        );
                    }

                    break;

                default:

                    MessageBox.Show(
                      "Please select a module first.",
                      "No Module Selected",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information
                    );

                    return;
            }

            LoadCurrentModule();
        }
    }
}
