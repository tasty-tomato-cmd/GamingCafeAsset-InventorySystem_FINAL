using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GamingCafeAsset_InventorySystem
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();

            // =====================================================
            // PASSWORD HINT LABEL
            // =====================================================

            lblPasswordHint.Text = "Minimum 8 characters with uppercase, lowercase, number, and special character.";

            lblPasswordHint.ForeColor = Color.WhiteSmoke;
        }

        // =====================================================
        // CANCEL BUTTON
        // =====================================================

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // =====================================================
        // RESET BUTTON
        // =====================================================

        private void btnReset_Click(object sender, EventArgs e)
        {
            // =====================================================
            // TEXTBOXES
            // =====================================================

            txtUser.Clear();

            txtPass.Clear();

            txtFirstName.Clear();

            txtLastName.Clear();

            txtEmail.Clear();

            txtPhoneNum.Clear();

            txtAddress.Clear();

            // =====================================================
            // COMBOBOX
            // =====================================================

            cbRoles.SelectedIndex = -1;

            // =====================================================
            // RADIO BUTTONS
            // =====================================================

            rbtnActive.Checked = false;

            rbtnInactive.Checked = false;

            // =====================================================
            // DATE TIME PICKER
            // =====================================================

            dtpDob.Value = DateTime.Now;

            // =====================================================
            // PASSWORD RESET
            // =====================================================

            txtPass.PasswordChar = '●';

            btnShowpass.BringToFront();

            lblPasswordHint.Text = "Minimum 8 characters with uppercase, lowercase, number, and special character.";

            lblPasswordHint.ForeColor = Color.WhiteSmoke;

            // =====================================================
            // CURSOR FOCUS
            // =====================================================

            txtUser.Focus();
        }

        // =====================================================
        // PASSWORD VISIBILITY
        // =====================================================

        private void btnHidepass_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '\0')
            {
                btnShowpass.BringToFront();

                txtPass.PasswordChar = '●';
            }
        }

        private void btnShowpass_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '●')
            {
                btnHidepass.BringToFront();

                txtPass.PasswordChar = '\0';
            }
        }

        // =====================================================
        // PASSWORD VALIDATION
        // =====================================================

        private bool IsValidPassword(string password)
        {
            if (password.Length < 8)
                return false;

            bool hasUpper = password.Any(char.IsUpper);

            bool hasLower = password.Any(char.IsLower);

            bool hasDigit = password.Any(char.IsDigit);

            bool hasSpecial = false;

            foreach (char ch in password)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    hasSpecial = true;

                    break;
                }
            }

            return hasUpper && hasLower && hasDigit && hasSpecial;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (IsValidPassword(txtPass.Text))
            {
                lblPasswordHint.Text = "Strong password ✔";

                lblPasswordHint.ForeColor = Color.LightGreen;
            }
            else
            {
                lblPasswordHint.Text = "Minimum 8 characters with uppercase, lowercase, number, and special character.";

                lblPasswordHint.ForeColor = Color.IndianRed;
            }
        }

        // =====================================================
        // CREATE USER BUTTON
        // =====================================================

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // =====================================================
            // INPUT VALUES
            // =====================================================

            string username = txtUser.Text.Trim();

            string password = txtPass.Text.Trim();

            string firstName = txtFirstName.Text.Trim();

            string lastName = txtLastName.Text.Trim();

            string email = txtEmail.Text.Trim();

            string phone = txtPhoneNum.Text.Trim();

            string address = txtAddress.Text.Trim();

            string role = cbRoles.Text;

            DateTime dob = dtpDob.Value;

            // =====================================================
            // EMPTY FIELD CHECK
            // =====================================================

            if (
              username == "" ||
              password == "" ||
              firstName == "" ||
              lastName == "" ||
              email == "" ||
              phone == "" ||
              address == "" ||
              role == ""
            )
            {
                MessageBox.Show(
                  "Please fill all fields.",
                  "Missing Information",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
                );

                return;
            }

            // =====================================================
            // PASSWORD VALIDATION
            // =====================================================

            if (!IsValidPassword(password))
            {
                MessageBox.Show(
                  "Password is not strong enough.",
                  "Invalid Password",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
                );

                return;
            }

            // =====================================================
            // USER ROLE ID
            // =====================================================

            int userTypeID = 0;

            switch (role)
            {
                case "Admin":

                    userTypeID = 1;

                    break;

                case "Manager":

                    userTypeID = 2;

                    break;

                case "Staff":

                    userTypeID = 3;

                    break;
            }

            // =====================================================
            // DATABASE OBJECT
            // =====================================================

            DBAccessHelper db = new DBAccessHelper();

            // =====================================================
            // DUPLICATE USERNAME CHECK
            // =====================================================

            ResultSet checkUser = db.GetQueryData("SELECT * FROM Users " + "WHERE Username = '" + username + "'");

            if (checkUser.Data != null && checkUser.Data.Rows.Count > 0)
            {
                MessageBox.Show(
                  "Username already exists.",
                  "Duplicate Username",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
                );

                return;
            }

            // =====================================================
            // DUPLICATE EMAIL CHECK
            // =====================================================

            ResultSet checkEmail = db.GetQueryData("SELECT * FROM Users " + "WHERE Email = '" + email + "'");

            if (checkEmail.Data != null && checkEmail.Data.Rows.Count > 0)
            {
                MessageBox.Show(
                  "Email already exists.",
                  "Duplicate Email",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
                );

                return;
            }

            // =====================================================
            // STATUS CHECK
            // =====================================================

            if (!rbtnActive.Checked && !rbtnInactive.Checked)
            {
                MessageBox.Show(
                  "Please select account status.",
                  "Missing Status",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
                );

                return;
            }

            int isActive = rbtnActive.Checked ? 1 : 0;

            // =====================================================
            // PHONE NUMBER VALIDATION
            // =====================================================

            if (!phone.All(char.IsDigit) || phone.Length != 11)
            {
                MessageBox.Show(
                  "Phone number must be exactly 11 digits.",
                  "Invalid Phone Number",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
                );

                return;
            }

            // =====================================================
            // INSERT QUERY
            // =====================================================

            string query =

              "INSERT INTO Users " +

              "(Username, Password, FirstName, LastName, UserTypeID, Email, PhoneNumber, Address, CreatedAt, IsActive, DateOfBirth) " +

              "VALUES (" +

              "'" + username + "', " +
              "'" + password + "', " +
              "'" + firstName + "', " +
              "'" + lastName + "', " +
              userTypeID + ", " +
              "'" + email + "', " +
              "'" + phone + "', " +
              "'" + address + "', " +
              "GETDATE(), " +
              isActive + ", " +
              "'" + dob.ToString("yyyy-MM-dd") + "'" +

              ")";

            // =====================================================
            // EXECUTE QUERY
            // =====================================================

            ResultSet result = db.ExecuteNonQuery(query);

            // =====================================================
            // ERROR CHECK
            // =====================================================

            if (result.HasError)
            {
                MessageBox.Show(
                  result.Message,
                  "Database Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                );

                return;
            }

            // =====================================================
            // SUCCESS MESSAGE
            // =====================================================

            MessageBox.Show(
              "User added successfully.",
              "Success",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information
            );

            this.Close();
        }

        private void cbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRoles.Text == "Admin")
            {
                MessageBox.Show(
                  "Admin role cannot be assigned to new users.",
                  "Invalid Role",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
                );

                btnCreate.Enabled = false;

                return;
            }
            else
            {
                btnCreate.Enabled = true;
            }
        }
    }
}
