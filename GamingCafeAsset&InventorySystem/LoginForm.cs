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

namespace GamingCafeAsset_InventorySystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            txtUser.Focus();
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor =
              Color.FromArgb(240, 80, 110);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor =
              Color.FromArgb(220, 60, 90);
        }

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName =
              txtUser.Text.Trim();

            string passWord =
              txtPass.Text;

            if (string.IsNullOrWhiteSpace(userName) &&
              string.IsNullOrWhiteSpace(passWord))
            {
                MessageBox.Show(
                  "Please enter both username and password.",
                  "Login Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                );

                return;
            }

            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show(
                  "Please enter username.",
                  "Login Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                );

                return;
            }

            if (string.IsNullOrWhiteSpace(passWord))
            {
                MessageBox.Show(
                  "Please enter password.",
                  "Login Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                );

                return;
            }

            try
            {
                DBAccessHelper db =
                  new DBAccessHelper();

                string query =
                  "SELECT UserID, Username, UserTypeID, " +
                  "FirstName, LastName, IsActive " +
                  "FROM Users " +
                  "WHERE Username = '" + userName +
                  "' AND Password = '" + passWord + "'";

                ResultSet res =
                  db.GetQueryData(query);

                if (res.HasError)
                {
                    MessageBox.Show(
                      res.Message,
                      "Login Error",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error
                    );

                    return;
                }

                if (res.Data != null &&
                  res.Data.Rows.Count > 0)
                {
                    bool isActive =
                      Convert.ToBoolean(
                        res.Data.Rows[0]["IsActive"]
                      );

                    if (!isActive)
                    {
                        MessageBox.Show(
                          "Your account is inactive. Please contact the administrator.",
                          "Account Inactive",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning
                        );

                        return;
                    }

                    LoggedInUser user =
                      new LoggedInUser();

                    user.UserID =
                      Convert.ToInt32(
                        res.Data.Rows[0]["UserID"]
                      );

                    user.Username =
                      res.Data.Rows[0]["Username"]
                      .ToString();

                    user.UserTypeID =
                      Convert.ToInt32(
                        res.Data.Rows[0]["UserTypeID"]
                      );

                    user.FirstName =
                      res.Data.Rows[0]["FirstName"]
                      .ToString();

                    user.LastName =
                      res.Data.Rows[0]["LastName"]
                      .ToString();

                    if (user.UserTypeID == 1)
                    {
                        user.UserTypeName =
                          "Admin";
                    }
                    else if (user.UserTypeID == 2)
                    {
                        user.UserTypeName =
                          "Manager";
                    }
                    else
                    {
                        user.UserTypeName =
                          "Staff";
                    }

                    MessageBox.Show(
                      "Login successful!",
                      "Login",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information
                    );

                    HomeForm homeForm =
                      new HomeForm(user);

                    this.Hide();

                    homeForm.ShowDialog();

                    this.Show();
                }
                else
                {
                    MessageBox.Show(
                      "Invalid username or password.",
                      "Login Error",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error
                    );

                    txtPass.Clear();

                    txtUser.Clear();

                    txtUser.Focus();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(
                  exp.Message,
                  "Login Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                );
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            DialogResult dre = MessageBox.Show(
              "Session ended!\nSee you again at Café De Naegus ;)",
              "Exit Application",
              MessageBoxButtons.OKCancel,
              MessageBoxIcon.Information
            );

            if (dre == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
