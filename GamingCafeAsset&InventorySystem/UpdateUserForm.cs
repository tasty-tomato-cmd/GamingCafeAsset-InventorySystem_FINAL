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
    public partial class UpdateUserForm : Form
    {
        // =====================================================
        // FIELDS
        // =====================================================

        private int userID;

        private bool isEditingAdmin = false;

        // =====================================================
        // CONSTRUCTOR
        // =====================================================

        public UpdateUserForm(
          int id,
          string username,
          string firstName,
          string lastName,
          string email,
          string phone,
          string address,
          string role,
          int isActive,
          DateTime dob
        )
        {
            InitializeComponent();

            // =====================================================
            // USER ID
            // =====================================================

            userID = id;

            // =====================================================
            // LOAD EXISTING DATA
            // =====================================================

            txtUser.Text = username;

            txtPass.Text = "";

            txtFirstName.Text = firstName;

            txtLastName.Text = lastName;

            txtEmail.Text = email;

            txtPhoneNum.Text = phone;

            txtAddress.Text = address;

            cbRoles.Text = role;

            dtpDob.Value = dob;

            // =====================================================
            // STATUS
            // =====================================================

            if (role == "Admin")
            {
                isEditingAdmin = true;
            }


            if (isActive == 1)
            {
                rbtnActive.Checked = true;
            }
            else
            {
                rbtnInactive.Checked = true;
            }

            // =====================================================
            // BUTTON TEXT
            // =====================================================

            btnCreate.Text = "UPDATE ACCOUNT";

            // =====================================================
            // PASSWORD HINT LABEL
            // =====================================================

            lblPasswordHint.Text = "Leave blank to keep current password.";

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
            txtUser.Clear();

            txtPass.Clear();

            txtFirstName.Clear();

            txtLastName.Clear();

            txtEmail.Clear();

            txtPhoneNum.Clear();

            txtAddress.Clear();

            cbRoles.SelectedIndex = -1;

            rbtnActive.Checked = false;

            rbtnInactive.Checked = false;

            dtpDob.Value = DateTime.Now;

            txtPass.PasswordChar = '●';

            btnShowpass.BringToFront();

            lblPasswordHint.Text = "Leave blank to keep current password.";

            lblPasswordHint.ForeColor = Color.WhiteSmoke;

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
            // =====================================================
            // EMPTY PASSWORD
            // =====================================================

            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                lblPasswordHint.Text =
                  "Leave blank to keep current password.";

                lblPasswordHint.ForeColor = Color.WhiteSmoke;

                return;
            }

            // =====================================================
            // VALID PASSWORD
            // =====================================================
            else if (IsValidPassword(txtPass.Text))
            {
                lblPasswordHint.Text = "Strong password ✔";

                lblPasswordHint.ForeColor = Color.LightGreen;
            }

            // =====================================================
            // INVALID PASSWORD
            // =====================================================
            else
            {
                lblPasswordHint.Text =
                  "Minimum 8 characters with uppercase, lowercase, number, and special character.";

                lblPasswordHint.ForeColor = Color.IndianRed;
            }
        }

        // =====================================================
        // UPDATE USER BUTTON
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

            if (!string.IsNullOrWhiteSpace(password) && !IsValidPassword(password))
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

            ResultSet checkUser = db.GetQueryData(

              "SELECT * FROM Users " +
              "WHERE Username = '" + username + "' " +
              "AND UserID != " + userID
            );

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

            ResultSet checkEmail = db.GetQueryData(

              "SELECT * FROM Users " +
              "WHERE Email = '" + email + "' " +
              "AND UserID != " + userID
            );

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
            // UPDATE QUERY
            // =====================================================

            string query = "";

            if (string.IsNullOrWhiteSpace(password))
            {
                query =

                  "UPDATE Users SET " +

                  "Username = '" + username + "', " +
                  "FirstName = '" + firstName + "', " +
                  "LastName = '" + lastName + "', " +
                  "UserTypeID = " + userTypeID + ", " +
                  "Email = '" + email + "', " +
                  "PhoneNumber = '" + phone + "', " +
                  "Address = '" + address + "', " +
                  "IsActive = " + isActive + ", " +
                  "DateOfBirth = '" + dob.ToString("yyyy-MM-dd") + "' " +

                  "WHERE UserID = " + userID;
            }
            else
            {
                query =

                  "UPDATE Users SET " +

                  "Username = '" + username + "', " +
                  "Password = '" + password + "', " +
                  "FirstName = '" + firstName + "', " +
                  "LastName = '" + lastName + "', " +
                  "UserTypeID = " + userTypeID + ", " +
                  "Email = '" + email + "', " +
                  "PhoneNumber = '" + phone + "', " +
                  "Address = '" + address + "', " +
                  "IsActive = " + isActive + ", " +
                  "DateOfBirth = '" + dob.ToString("yyyy-MM-dd") + "' " +

                  "WHERE UserID = " + userID;
            }

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
              "User updated successfully.",
              "Success",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information
            );

            this.Close();
        }

        private void cbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // =====================================================
            // EDITING EXISTING ADMIN USER
            // =====================================================
            if (isEditingAdmin)
            {
                if (cbRoles.Text != "Admin")
                {
                    MessageBox.Show(
                        "Admin role cannot be changed.",
                        "Restriction",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    cbRoles.Text = "Admin";
                }

                btnCreate.Enabled = true;
                rbtnInactive.Enabled = false;
                return;
            }

            // =====================================================
            // USER TRYING TO SELECT ADMIN
            // =====================================================
            if (cbRoles.Text == "Admin")
            {
                MessageBox.Show(
                    "Admin role cannot be assigned to users.",
                    "Role Restriction",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                btnCreate.Enabled = false;
            }
            else
            {
                btnCreate.Enabled = true;
            }
        }
    }
}
