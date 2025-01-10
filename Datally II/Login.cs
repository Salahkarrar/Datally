using Dapper;
using Datally.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Datally
{
    public partial class Login : Form
    {
        // Singleton instance of the Login form
        private static Login _instance;
        // Database connection object
        private readonly OleDbConnection _connection;
        public Login()
        {
            InitializeComponent();
            _connection = new OleDbConnection(Resources.SVRDB);
        }

        // User properties
        public string SerialNum { get; set; }
        public string SerialNum1 { get; set; }
        public string DSerial1 { get; set; }
        public string DSerial2 { get; set; }
        private string ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Authority { get; set; }
        public string RoleID { get; set; }
        public string RoleName { get; set; }
        public string Status { get; set; }
        public List<PROAuth> List { get; set; }

        // Lock object for thread safety
        private static readonly object _lock = new object();

        // Singleton instance property
        public static Login Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Login();
                        }
                    }
                }
                return _instance;
            }
        }

        // Event handler for form load
        private void Login_Load(object sender, EventArgs e)
        {
            _instance = this;
            try
            {
                OpenConnection();
                UpdateConnectionStatus(true);
            }
            catch (Exception ex)
            {
                ShowDatabaseConnectionError(ex);
                UpdateConnectionStatus(false);
            }
        }

        private void UpdateConnectionStatus(bool isConnected)
        {
            Conn_Status.ForeColor = isConnected ? Color.Lime : Color.Red;
            Conn_Status.Text = Conn_Status.Text.Replace("Status", isConnected ? "Good" : "Failed");
        }

        private void ShowDatabaseConnectionError(Exception ex)
        {
            MessageBox.Show("Can't connect to database, call system administration." + "\r\n" + ex.Message, "Error Login 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        // Event handler for login button click
        private void Login_Btn_Click(object sender, EventArgs e)
        {
            int userCount = 0;
            try
            {
                OpenConnection();
                // Query to check if the user exists with the provided password
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM T_Users WHERE PWord=@0", _connection))
                {
                    cmd.Parameters.AddWithValue("@0", PassWord.Text);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        // Read user data if found
                        while (reader.Read())
                        {
                            userCount = 1;
                            ID = reader["ID"].ToString();
                            UserName = reader["UserName"].ToString();
                            RoleID = reader["RoleID"].ToString();
                            Status = reader["C_Status"].ToString();
                        }
                    }
                    cmd.Parameters.Clear();
                }
            }
            catch (Exception ex)
            {
                // Show error message if there is a problem with the database
                MessageBox.Show("Problem in database, can't get your data." + "\r\n" + "Call system administrator" + "\r\n" + ex.Message, "Error Login - 1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Check if user is found and ID is not null
            if (userCount == 1 && ID != null)
            {
                // Check if the user's status is "Changed"
                if (Status == "Changed")
                {
                    Hide();
                    // Open the main form
                    using (Main mainForm = new Main())
                    {
                        mainForm.ShowDialog();
                    }
                }
                else
                {
                    // Open the change password form
                    using (ChangePass changePassForm = new ChangePass())
                    {
                        changePassForm.ShowDialog();
                    }
                }
                // Clear the password field
                PassWord.Clear();
            }
            else
            {
                // Show message if the password is incorrect
                MessageBoxEx.Show("Incorrect password, please try again.", "Password", 5000);
            }
        }


        // Event handler for form closing
        private void Login_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = e.CloseReason == CloseReason.UserClosing;

        // Event handler for about link click
        private void About_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (About aboutForm = new About())
            {
                aboutForm.ShowDialog();
            }
        }

        // Event handler for RLogin button click
        private void RLogin_Btn_Click(object sender, EventArgs e)
        {
            OpenConnection();
            using (OleDbCommand cmd = new OleDbCommand
            {
                Connection = _connection,
                CommandText = "SELECT * FROM T_Users WHERE PWord=@0"
            })
            {
                cmd.Parameters.AddWithValue("@0", PassWord.Text);
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    int userCount = 0;
                    while (reader.Read())
                    {
                        userCount++;
                    }
                    cmd.Parameters.Clear();
                    if (userCount == 1)
                    {
                        Hide();
                        using (MedicalReport medicalReportForm = new MedicalReport())
                        {
                            medicalReportForm.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("Incorrect password, please try again.", "Password", 5000);
                    }
                }
            }
        }

        // Event handler for exit button click
        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            _connection.Dispose(); // Dispose the connection
            MessageBoxEx.Show("GoodBye", "Exit", 700); // Show goodbye message
            Application.Exit(); // Exit the application
            Environment.Exit(0); // Exit the environment
        }

        // Method to edit button icon
        public void Edit_Ico(Button button, string text, Image image)
        {
            button.Text = text;
            button.Image = image;
            button.ImageAlign = ContentAlignment.TopLeft;
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        // Event handler for change password menu item click
        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ChangePass changePassForm = new ChangePass())
            {
                changePassForm.ShowDialog();
            }
        }

        // Method to check user permissions
        public void Check(string userName, string functionName)
        {
            ExecuteQuery(() =>
            {
                List = _connection.Query<PROAuth>(
                    "SELECT T_Function.FunctionName, T_Roles.RoleName " +
                    "FROM ((T_Function INNER JOIN T_FunctionRole ON T_Function.FunctionID = T_FunctionRole.FunctionID) " +
                    "INNER JOIN T_Roles ON T_FunctionRole.RoleID = T_Roles.RoleID) " +
                    "INNER JOIN T_Users ON T_Roles.RoleID = T_Users.RoleID " +
                    "WHERE T_Users.UserName = @UserName AND T_Function.FunctionName = @FunctionName",
                    new { UserName = userName, FunctionName = functionName }).ToList();
            }, "Error Login - 1002");
        }

        // Method to check main user permissions
        public void CheckMain(string userName)
        {
            ExecuteQuery(() =>
            {
                List = _connection.Query<PROAuth>(
                    "SELECT T_Function.FunctionName, T_Roles.RoleName " +
                    "FROM ((T_Function INNER JOIN T_FunctionRole ON T_Function.FunctionID = T_FunctionRole.FunctionID) " +
                    "INNER JOIN T_Roles ON T_FunctionRole.RoleID = T_Roles.RoleID) " +
                    "INNER JOIN T_Users ON T_Roles.RoleID = T_Users.RoleID " +
                    "WHERE T_Users.UserName = @UserName",
                    new { UserName = userName }).ToList();
            }, "Error Login - 1003");
        }

        //******************** General Methods ********************//

        private void OpenConnection()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        private void ExecuteQuery(Action queryAction, string errorMessage)
        {
            try
            {
                OpenConnection();
                queryAction();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Problem in Database, Can't Get Your Data.", ex, errorMessage);
            }
            finally
            {
                _connection.Close();
            }
        }

        private void ShowErrorMessage(string message, Exception ex, string errorCode)
        {
            MessageBox.Show($"{message}\r\n{ex.Message}", errorCode, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
