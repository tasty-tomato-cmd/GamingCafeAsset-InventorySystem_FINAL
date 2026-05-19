using System;
using System.Data;
using System.Windows.Forms;

namespace GamingCafeAsset_InventorySystem
{
    public partial class AddFoodItemForm : Form
    {
        // =====================================================
        // FIELDS
        // =====================================================

        private LoggedInUser currentUser;

        private bool isUpdateMode = false;

        private int foodID;
        private int bookingID;

        // =====================================================
        // CREATE MODE
        // =====================================================

        public AddFoodItemForm(LoggedInUser user)
        {
            InitializeComponent();

            currentUser = user;

            LoadActiveBookings();

            LoadFastFood();
            LoadSnacks();
            LoadDrinks();

            txtQuantity.Text = "1";

            foodItem();

            ResetFoodSelections();

            UpdateFoodSummary();
            UpdateFoodPrice();
        }

        // =====================================================
        // UPDATE MODE
        // =====================================================

        public AddFoodItemForm(
            LoggedInUser user,
            int foodID,
            int bookingID,
            string foodName,
            double price,
            int quantity)
        {
            InitializeComponent();

            isUpdateMode = true;

            this.foodID = foodID;
            this.bookingID = bookingID;

            btnSave.Text = "UPDATE FOOD ITEM";

            LoadActiveBookings();

            LoadFastFood();
            LoadSnacks();
            LoadDrinks();

            txtQuantity.Text = quantity.ToString();

            foodItem();

            ResetFoodSelections();

            SelectBooking(bookingID);

            DetectAndSelectFood(foodName);

            UpdateFoodSummary();
            UpdateFoodPrice();
        }

        // =====================================================
        // EVENTS
        // =====================================================

        private void foodItem()
        {
            cbFastFood.SelectedIndexChanged += cbFastFood_SelectedIndexChanged;
            cbSnacks.SelectedIndexChanged += cbSnacks_SelectedIndexChanged;
            cbDrinks.SelectedIndexChanged += cbDrinks_SelectedIndexChanged;

            txtQuantity.TextChanged += txtQuantity_TextChanged;

            cbCustomer.SelectedIndexChanged += cbCustomer_SelectedIndexChanged;
        }

        // =====================================================
        // LOAD ACTIVE BOOKINGS
        // =====================================================

        private void LoadActiveBookings()
        {
            DBAccessHelper db = new DBAccessHelper();

            string query =
                "SELECT BookingID, CustomerName, BookingStatus " +
                "FROM Booking " +
                "WHERE BookingStatus='Active'";

            ResultSet result = db.GetQueryData(query);

            if (!result.HasError &&
                result.Data != null)
            {
                cbCustomer.DataSource = result.Data;

                cbCustomer.DisplayMember = "CustomerName";

                cbCustomer.ValueMember = "BookingID";

                cbCustomer.SelectedIndex = -1;
            }
        }

        // =====================================================
        // LOAD CATEGORY FOODS
        // =====================================================

        private void LoadFastFood()
        {
            LoadFoodByCategory("Fast Food", cbFastFood);
        }

        private void LoadSnacks()
        {
            LoadFoodByCategory("Snacks", cbSnacks);
        }

        private void LoadDrinks()
        {
            LoadFoodByCategory("Drinks", cbDrinks);
        }

        // =====================================================
        // LOAD FOOD BY CATEGORY
        // =====================================================

        private void LoadFoodByCategory(
            string categoryName,
            ComboBox comboBox)
        {
            DBAccessHelper db = new DBAccessHelper();

            string query =
                "SELECT DISTINCT FoodItem.FoodName " +
                "FROM FoodItem " +

                "INNER JOIN FoodItemCategory " +
                "ON FoodItem.FoodID = FoodItemCategory.FoodID " +

                "INNER JOIN FoodCategory " +
                "ON FoodItemCategory.CategoryID = FoodCategory.CategoryID " +

                "WHERE FoodCategory.CategoryName='" +
                categoryName.Replace("'", "''") + "'";

            ResultSet result = db.GetQueryData(query);

            comboBox.Items.Clear();

            // EMPTY OPTION
            comboBox.Items.Add("");

            if (!result.HasError &&
                result.Data != null &&
                result.Data.Rows.Count > 0)
            {
                foreach (DataRow row in result.Data.Rows)
                {
                    comboBox.Items.Add(
                        row["FoodName"].ToString()
                    );
                }
            }

            comboBox.SelectedIndex = 0;
        }

        // =====================================================
        // RESET FOOD SELECTIONS
        // =====================================================

        private void ResetFoodSelections()
        {
            cbFastFood.SelectedIndex = 0;
            cbSnacks.SelectedIndex = 0;
            cbDrinks.SelectedIndex = 0;
        }

        // =====================================================
        // SELECT BOOKING
        // =====================================================

        private void SelectBooking(int bookingID)
        {
            cbCustomer.SelectedValue = bookingID;
        }

        // =====================================================
        // DETECT FOOD
        // =====================================================

        private void DetectAndSelectFood(string foodName)
        {
            string[] foods = foodName.Split(',');

            foreach (string item in foods)
            {
                string food = item.Trim();

                if (cbFastFood.Items.Contains(food))
                {
                    cbFastFood.SelectedItem = food;
                }

                else if (cbSnacks.Items.Contains(food))
                {
                    cbSnacks.SelectedItem = food;
                }

                else if (cbDrinks.Items.Contains(food))
                {
                    cbDrinks.SelectedItem = food;
                }
            }
        }

        // =====================================================
        // FOOD SUMMARY
        // =====================================================

        private void UpdateFoodSummary()
        {
            string foods = "";

            // FAST FOOD

            if (!string.IsNullOrWhiteSpace(cbFastFood.Text))
            {
                foods += cbFastFood.Text;
            }

            // SNACKS

            if (!string.IsNullOrWhiteSpace(cbSnacks.Text))
            {
                if (foods != "")
                {
                    foods += ", ";
                }

                foods += cbSnacks.Text;
            }

            // DRINKS

            if (!string.IsNullOrWhiteSpace(cbDrinks.Text))
            {
                if (foods != "")
                {
                    foods += ", ";
                }

                foods += cbDrinks.Text;
            }

            txtFoodName.Text = foods;
        }

        // =====================================================
        // GET FOOD PRICE
        // =====================================================

        private double GetFoodPrice(string foodName)
        {
            if (string.IsNullOrWhiteSpace(foodName))
                return 0;

            DBAccessHelper db = new DBAccessHelper();

            string query =
                "SELECT TOP 1 Price " +
                "FROM FoodItem " +
                "WHERE FoodName LIKE '%" +
                foodName.Replace("'", "''") + "%'";

            ResultSet result = db.GetQueryData(query);

            if (!result.HasError &&
                result.Data != null &&
                result.Data.Rows.Count > 0)
            {
                return Convert.ToDouble(
                    result.Data.Rows[0]["Price"]
                );
            }

            return 0;
        }

        // =====================================================
        // UPDATE FOOD PRICE
        // =====================================================

        private void UpdateFoodPrice()
        {
            double fastFoodPrice =
                GetFoodPrice(cbFastFood.Text);

            double snacksPrice =
                GetFoodPrice(cbSnacks.Text);

            double drinksPrice =
                GetFoodPrice(cbDrinks.Text);

            txtPriceFastFood.Text =
                fastFoodPrice.ToString("0.00");

            txtPriceSnacks.Text =
                snacksPrice.ToString("0.00");

            txtPriceDrinks.Text =
                drinksPrice.ToString("0.00");

            int quantity = 1;

            if (!int.TryParse(txtQuantity.Text, out quantity))
            {
                quantity = 1;
            }

            double total =
                (fastFoodPrice +
                 snacksPrice +
                 drinksPrice) * quantity;

            txtTotalPrice.Text =
                total.ToString("0.00");
        }

        // =====================================================
        // INSERT FOOD CATEGORIES
        // =====================================================

        private void InsertFoodCategories(
            int selectedFoodID)
        {
            // FAST FOOD

            if (!string.IsNullOrWhiteSpace(
                cbFastFood.Text))
            {
                InsertCategoryMap(
                    selectedFoodID,
                    "Fast Food"
                );
            }

            // SNACKS

            if (!string.IsNullOrWhiteSpace(
                cbSnacks.Text))
            {
                InsertCategoryMap(
                    selectedFoodID,
                    "Snacks"
                );
            }

            // DRINKS

            if (!string.IsNullOrWhiteSpace(
                cbDrinks.Text))
            {
                InsertCategoryMap(
                    selectedFoodID,
                    "Drinks"
                );
            }
        }

        // =====================================================
        // INSERT CATEGORY MAP
        // =====================================================

        private void InsertCategoryMap(
            int selectedFoodID,
            string categoryName)
        {
            DBAccessHelper db =
                new DBAccessHelper();

            string categoryQuery =
                "SELECT TOP 1 CategoryID " +
                "FROM FoodCategory " +
                "WHERE CategoryName='" +
                categoryName.Replace("'", "''") + "'";

            ResultSet categoryResult =
                db.GetQueryData(categoryQuery);

            if (!categoryResult.HasError &&
                categoryResult.Data != null &&
                categoryResult.Data.Rows.Count > 0)
            {
                int categoryID =
                    Convert.ToInt32(
                        categoryResult.Data.Rows[0]["CategoryID"]
                    );

                string mapQuery =
                    "INSERT INTO FoodItemCategory " +
                    "(FoodID, CategoryID) " +
                    "VALUES (" +
                    selectedFoodID + ", " +
                    categoryID + ")";

                db.ExecuteNonQuery(mapQuery);
            }
        }

        // =====================================================
        // COMBOBOX EVENTS
        // =====================================================

        private void cbFastFood_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            UpdateFoodSummary();
            UpdateFoodPrice();
        }

        private void cbSnacks_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            UpdateFoodSummary();
            UpdateFoodPrice();
        }

        private void cbDrinks_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            UpdateFoodSummary();
            UpdateFoodPrice();
        }

        // =====================================================
        // QUANTITY EVENT
        // =====================================================

        private void txtQuantity_TextChanged(
            object sender,
            EventArgs e)
        {
            UpdateFoodPrice();
        }

        // =====================================================
        // CUSTOMER EVENT
        // =====================================================

        private void cbCustomer_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cbCustomer.SelectedValue == null)
            {
                return;
            }

            if (!int.TryParse(
                cbCustomer.SelectedValue.ToString(),
                out int selectedBookingID))
            {
                return;
            }

            DBAccessHelper db =
                new DBAccessHelper();

            string query =
                "SELECT CustomerName, BookingStatus " +
                "FROM Booking " +
                "WHERE BookingID=" +
                selectedBookingID;

            ResultSet result =
                db.GetQueryData(query);
        }

        // =====================================================
        // RESET SCREEN
        // =====================================================

        private void ResetScreen()
        {
            ResetFoodSelections();

            cbCustomer.SelectedIndex = -1;

            txtFoodName.Clear();

            txtPriceFastFood.Text = "0.00";
            txtPriceSnacks.Text = "0.00";
            txtPriceDrinks.Text = "0.00";

            txtQuantity.Text = "1";

            txtTotalPrice.Text = "0.00";
        }

        // =====================================================
        // SAVE / UPDATE
        // =====================================================

        private void btnSave_Click(
    object sender,
    EventArgs e)
        {
            string foodName =
                txtFoodName.Text.Trim();

            if (string.IsNullOrWhiteSpace(foodName))
            {
                MessageBox.Show(
                    "Please select at least one food item."
                );

                return;
            }

            if (cbCustomer.SelectedValue == null)
            {
                MessageBox.Show(
                    "Please select a customer."
                );

                return;
            }

            bookingID =
                Convert.ToInt32(
                    cbCustomer.SelectedValue
                );

            double totalPrice =
                Convert.ToDouble(
                    txtTotalPrice.Text
                );

            int quantity =
                Convert.ToInt32(
                    txtQuantity.Text
                );

            DBAccessHelper db =
                new DBAccessHelper();

            // =====================================================
            // INSERT
            // =====================================================

            if (!isUpdateMode)
            {
                string insertFoodQuery =
                    "INSERT INTO FoodItem " +
                    "(FoodName, Price, Quantity, BookingID) " +
                    "VALUES ('" +
                    foodName.Replace("'", "''") + "', " +
                    totalPrice + ", " +
                    quantity + ", " +
                    bookingID + ")";

                ResultSet result =
                    db.ExecuteNonQuery(insertFoodQuery);

                if (result.HasError)
                {
                    MessageBox.Show(
                        result.Message,
                        "Error"
                    );

                    return;
                }

                // =====================================================
                // GET NEW FOOD ID
                // =====================================================

                string getFoodIdQuery =
                    "SELECT TOP 1 FoodID " +
                    "FROM FoodItem " +
                    "ORDER BY FoodID DESC";

                ResultSet foodIdResult =
                    db.GetQueryData(getFoodIdQuery);

                int newFoodID =
                    Convert.ToInt32(
                        foodIdResult.Data.Rows[0]["FoodID"]
                    );

                // =====================================================
                // INSERT CATEGORY MAPPINGS
                // =====================================================

                InsertFoodCategories(newFoodID);

                MessageBox.Show(
                    "Food item added successfully!"
                );

                ResetScreen();

                this.Close();
            }

            // =====================================================
            // UPDATE
            // =====================================================

            else
            {
                string updateFoodQuery =
                    "UPDATE FoodItem SET " +
                    "FoodName='" +
                    foodName.Replace("'", "''") + "', " +

                    "Price=" +
                    totalPrice + ", " +

                    "Quantity=" +
                    quantity + ", " +

                    "BookingID=" +
                    bookingID + " " +

                    "WHERE FoodID=" +
                    foodID;

                ResultSet result =
                    db.ExecuteNonQuery(updateFoodQuery);

                if (result.HasError)
                {
                    MessageBox.Show(
                        result.Message,
                        "Error"
                    );

                    return;
                }

                // =====================================================
                // DELETE OLD CATEGORY MAPS
                // =====================================================

                db.ExecuteNonQuery(
                    "DELETE FROM FoodItemCategory " +
                    "WHERE FoodID=" + foodID
                );

                // =====================================================
                // INSERT NEW CATEGORY MAPS
                // =====================================================

                InsertFoodCategories(foodID);

                MessageBox.Show(
                    "Food item updated successfully!"
                );

                ResetScreen();

                this.Close();
            }
        }

        // =====================================================
        // RESET BUTTON
        // =====================================================

        private void btnReset_Click(
            object sender,
            EventArgs e)
        {
            ResetScreen();
        }

        // =====================================================
        // CANCEL BUTTON
        // =====================================================

        private void btnCancel_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }
    }
}
