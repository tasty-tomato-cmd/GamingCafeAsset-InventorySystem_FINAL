using System;
using System.Windows.Forms;

namespace GamingCafeAsset_InventorySystem
{
    public partial class AddGamesForm : Form
    {
        private LoggedInUser currentUser;
        private bool isUpdateMode = false;
        private int gameID;

        public AddGamesForm(LoggedInUser user)
        {
            InitializeComponent();

            currentUser = user;

            LoadDevicesIntoComboBox();
            LoadGames();
        }

        public AddGamesForm(
          int gameID,
          int deviceID,
          string gameName,
          string platform,
          string genre)
        {
            InitializeComponent();

            isUpdateMode = true;
            this.gameID = gameID;

            LoadDevicesIntoComboBox();

            txtGameName.Text = gameName;
            txtGenre.Text = genre;

            if (platform == "PC") rbGamesPC.Checked = true;
            else if (platform == "Console") rbGamesConsole.Checked = true;
            else if (platform == "VIP") rbVip.Checked = true;

            btnGamesCreate.Text = "Update Game";

            SetDeviceByID(deviceID);

            LoadGames();
        }

        private void LoadGames()
        {
            DBAccessHelper db = new DBAccessHelper();

            string query =
              "SELECT " +
              "Games.GameID AS [Game No.], " +
              "Games.GameName AS [Game Name], " +
              "Games.GamePlatform AS [Platform], " +
              "Games.Genre AS [Genre], " +
              "ISNULL(Device.DeviceName, 'None') AS [Device] " +
              "FROM Games " +
              "LEFT JOIN DeviceGames ON Games.GameID = DeviceGames.GameID " +
              "LEFT JOIN Device ON DeviceGames.DeviceID = Device.DeviceID";

            ResultSet result = db.GetQueryData(query);

            if (!result.HasError && result.Data != null)
            {
                dgvLiveUpdate.DataSource = result.Data;
                DisableSorting();
            }
        }

        private void DisableSorting()
        {
            foreach (DataGridViewColumn col in dgvLiveUpdate.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void LoadDevicesIntoComboBox()
        {
            DBAccessHelper db = new DBAccessHelper();

            string query = "SELECT DeviceID, DeviceName FROM Device";

            ResultSet result = db.GetQueryData(query);

            cbDevice.Items.Clear();
            cbDevice.Items.Add("None");

            if (!result.HasError && result.Data != null)
            {
                foreach (System.Data.DataRow row in result.Data.Rows)
                {
                    cbDevice.Items.Add(row["DeviceName"].ToString());
                }
            }

            cbDevice.SelectedIndex = 0;
        }

        private void SetDeviceByID(int deviceID)
        {
            if (deviceID <= 0)
            {
                cbDevice.SelectedIndex = 0;
                return;
            }

            DBAccessHelper db = new DBAccessHelper();

            string query =
              "SELECT DeviceName FROM Device WHERE DeviceID = " + deviceID;

            ResultSet result = db.GetQueryData(query);

            if (!result.HasError &&
              result.Data != null &&
              result.Data.Rows.Count > 0)
            {
                cbDevice.SelectedItem =
                  result.Data.Rows[0]["DeviceName"].ToString();
            }
            else
            {
                cbDevice.SelectedIndex = 0;
            }
        }

        private void btnGamesCreate_Click(object sender, EventArgs e)
        {
            string gameName = txtGameName.Text.Trim();
            string genre = txtGenre.Text.Trim();

            if (string.IsNullOrWhiteSpace(gameName))
            {
                MessageBox.Show("Game name is required!");
                return;
            }

            if (string.IsNullOrWhiteSpace(genre))
            {
                MessageBox.Show("Genre is required!");
                return;
            }

            string platform = "";

            if (rbGamesPC.Checked) platform = "PC";
            else if (rbGamesConsole.Checked) platform = "Console";
            else if (rbVip.Checked) platform = "VIP";
            else
            {
                MessageBox.Show("Please select a platform!");
                return;
            }

            DBAccessHelper db = new DBAccessHelper();

            int? deviceID = null;

            if (cbDevice.SelectedItem != null &&
              cbDevice.SelectedItem.ToString() != "None")
            {
                string selectedDevice = cbDevice.SelectedItem.ToString();

                string deviceQuery =
                  "SELECT DeviceID FROM Device " +
                  "WHERE DeviceName = '" + selectedDevice.Replace("'", "''") + "'";

                ResultSet deviceResult = db.GetQueryData(deviceQuery);

                if (!deviceResult.HasError &&
                  deviceResult.Data != null &&
                  deviceResult.Data.Rows.Count > 0)
                {
                    deviceID = Convert.ToInt32(deviceResult.Data.Rows[0]["DeviceID"]);
                }
                else
                {
                    MessageBox.Show("Invalid device selected!");
                    return;
                }
            }

            if (!isUpdateMode)
            {
                string query =
                  "INSERT INTO Games (GameName, GamePlatform, Genre) VALUES ('" +
                  gameName.Replace("'", "''") + "', '" +
                  platform + "', '" +
                  genre.Replace("'", "''") + "')";

                ResultSet result = db.ExecuteNonQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message, "Error");
                    return;
                }

                int newGameID =
                  Convert.ToInt32(db.GetQueryData("SELECT MAX(GameID) FROM Games")
                    .Data.Rows[0][0]);

                if (deviceID.HasValue)
                {
                    string mapQuery =
                      "INSERT INTO DeviceGames (DeviceID, GameID) VALUES (" +
                      deviceID.Value + ", " + newGameID + ")";

                    db.ExecuteNonQuery(mapQuery);
                }

                MessageBox.Show("Game added successfully!");
                ResetScreen();
                LoadGames();
            }

            else
            {
                string query =
                  "UPDATE Games SET " +
                  "GameName = '" + gameName.Replace("'", "''") + "', " +
                  "GamePlatform = '" + platform + "', " +
                  "Genre = '" + genre.Replace("'", "''") + "' " +
                  "WHERE GameID = " + gameID;

                ResultSet result = db.ExecuteNonQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message, "Error");
                    return;
                }

                db.ExecuteNonQuery(
                  "DELETE FROM DeviceGames WHERE GameID = " + gameID
                );

                if (deviceID.HasValue)
                {
                    string insertMap =
                      "INSERT INTO DeviceGames (DeviceID, GameID) VALUES (" +
                      deviceID.Value + ", " + gameID + ")";

                    db.ExecuteNonQuery(insertMap);
                }

                MessageBox.Show("Game updated successfully!");
                ResetScreen();
                LoadGames();
            }
        }

        private void btnGamesCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetScreen()
        {
            txtGameName.Clear();
            txtGenre.Clear();

            cbDevice.SelectedIndex = 0;

            rbGamesPC.Checked = false;
            rbGamesConsole.Checked = false;
            rbVip.Checked = false;
        }

        private void btnGamesReset_Click(object sender, EventArgs e)
        {
            ResetScreen();
        }
    }
}
