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
        //#region Trial Section :
        //// This function does all the work
        //[DllImport("Radiologix.dll", EntryPoint = "ReadSettingsStr", CharSet = CharSet.Ansi)]
        //static extern uint InitTrial(String aKeyCode, IntPtr aHWnd);

        //// Use this function to register the application when the application is running
        //[DllImport("Radiologix.dll", EntryPoint = "DisplayRegistrationStr", CharSet = CharSet.Ansi)]
        //static extern uint DisplayRegistration(String aKeyCode, IntPtr aHWnd);

        //// The kLibraryKey is meant to prevent unauthorized use of the library.
        //// Do not share this key. Replace this key with your own from Advanced Installer 
        //// project > Licensing > Registration > Library Key
        //private const string kLibraryKey = "D36DEC3A76ADD23619D80002231E4E4C570D190E3D6AA3266325DC5F2FEB7E081487DAF27E2C";
        //// Trial ID = {33DA8412-D2B7-48CD-A041-D402E0E6F8C6}
        //// Codes = 941E47B0 296C5FC1 C9D3E533 55F57AD6 88129593 

        //private static void OnInit()
        //{
        //    try
        //    {
        //        Process process = Process.GetCurrentProcess();
        //        InitTrial(kLibraryKey, process.MainWindowHandle);
        //    }
        //    catch (DllNotFoundException ex)
        //    {
        //        // Trial dll is missing close the application immediately.
        //        MessageBox.Show(ex.ToString());
        //        Process.GetCurrentProcess().Kill();
        //    }
        //    catch (Exception ex1)
        //    {
        //        MessageBox.Show(ex1.ToString());
        //    }
        //}

        //private void RegisterApp(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Process process = Process.GetCurrentProcess();
        //        DisplayRegistration(kLibraryKey, process.MainWindowHandle);
        //    }
        //    catch (DllNotFoundException ex)
        //    {
        //        // Trial dll is missing close the application immediately.
        //        MessageBox.Show(ex.ToString());
        //    }
        //    catch (Exception ex1)
        //    {
        //        MessageBox.Show(ex1.ToString());
        //    }
        //}
        //#endregion

        public Login() => InitializeComponent();

        public OleDbConnection Con { get; } = new OleDbConnection(Resources.SVRDB);

        public string ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Authority { get; set; }
        public string RoleID { get; set; }
        public string RoleName { get; set; }
        public string Status { get; set; }
        public List<PROAuth> List { get; set; }

        private static Login _instance;

        public static Login Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Login();
                }

                return _instance;
            }
        }

        public OleDbConnection Conn { get; set; } = new OleDbConnection(Resources.SVRDB);


        private void Login_Load(object sender, EventArgs e)
        {
            //OnInit();
            _instance = this;
            try
            {

                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                Conn_Status.ForeColor = Color.Lime;
                Conn_Status.Text.Replace(oldValue: Resources.S1, Resources.S2);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Connected to Database, Call System Administration." + "\r\n" + ex.Message, "Error Login 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Conn_Status.ForeColor = Color.Red;
                Conn_Status.Text.Replace(Resources.S1, Resources.S3);
            }
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            int c = 0;
            try
            {
                OleDbCommand Cmd = new OleDbCommand("SELECT * FROM T_Users WHERE PWord=@0", Conn);

                Cmd.Parameters.AddWithValue("@0", PassWord.Text);

                OleDbDataReader Reader = Cmd.ExecuteReader();

                while (Reader.Read())
                {
                    c = 1;
                    ID = Reader[Resources.DB1].ToString();
                    UserName = Reader[Resources.DB2].ToString();
                    Password = Reader[Resources.DB3].ToString();
                    Phone = Reader[Resources.DB4].ToString();
                    RoleID = Reader[Resources.DB5].ToString();
                    Status = Reader[Resources.DB6].ToString();
                }
                Cmd.Parameters.Clear();
                Reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Get Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Login - 1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (c== 1 && ID != null && Status == "Changed")
            {
                Hide();
                using (Main D = new Main())
                {
                    D.ShowDialog();
                }
                PassWord.Clear();
            }
            else if (c == 1 && ID != null && Status != "Changed")
            {
                using (ChangePass D = new ChangePass())
                {
                    D.ShowDialog();
                }
                PassWord.Clear();
            }
            else
            {
                MessageBoxEx.Show("Incorrect Password, Please try again.", "Password", 5000);
            }



        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = e.CloseReason == CloseReason.UserClosing;

        private void About_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (About A = new About())
            {
                A.ShowDialog();
            }
        }

        private void RLogin_Btn_Click(object sender, EventArgs e)
        {
            using (OleDbCommand Cmd = new OleDbCommand
            {
                Connection = Conn,
                CommandText = "SELECT * FROM T_Users WHERE PWord=@0"
            })
            {
                Cmd.Parameters.AddWithValue("@0", PassWord.Text);
                OleDbDataReader Reader = Cmd.ExecuteReader();
                int c = 0;
                while (Reader.Read())
                {
                    c += 1;
                }
                Cmd.Parameters.Clear();
                if (c == 1)
                {
                    Hide();
                    using (MedicalReport Frm = new MedicalReport())
                    {
                        Frm.ShowDialog();
                    }
                }
                else
                {
                    MessageBoxEx.Show("Incorrect Password, Please try again.", "Password", 5000);
                }
            }
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Conn.Close();
            dynamic dialog = MessageBox.Show(Resources.E9, Resources.E8, MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                var backupFolder = Application.StartupPath + Resources.BackupFolder;

                var backupFileName = String.Format("{0}{1}~{2}.accdb",
                    backupFolder, "Radiologix",
                    DateTime.Now.ToString("dd-MM-yyy  hh-mm-ss"));

                string So = Resources.SVRPath;
                string De = backupFileName;

                string backupDir = Application.StartupPath + Resources.BackupFolder;
                var DeletionDays = 3;
                if (DeletionDays < 10)
                {
                    try
                    {
                        string[] files = Directory.GetFiles(backupDir);

                        foreach (string file in files)
                        {
                            FileInfo fi = new FileInfo(file);
                            if (fi.CreationTime < DateTime.Now.AddDays(-DeletionDays))
                            {
                                fi.Delete();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBoxEx.Show("Can't Delete The old Backup" + "\r\n" + ex.Message, "Error Login - 1002", 1000);
                    }
                }

                File.Copy(So, De);
                MessageBoxEx.Show(Resources.S4, Resources.E8, 700);
                Application.Exit();
                Environment.Exit(0);
            }
        }

        public void Edit_Ico(Button Value, string Value2, Image Value3)
        {
            Value.Text = Value2;
            Value.Image = Value3;
            Value.ImageAlign = ContentAlignment.TopLeft;
            Value.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ChangePass D = new ChangePass())
            {
                D.ShowDialog();
            }
        }

        public void Check(string Value, string Value2)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                using (OleDbCommand Cmd = new OleDbCommand
                {
                    Connection = Con,
                })
                {
                    List = Con.Query<PROAuth>("SELECT T_Function.FunctionName, T_Roles.RoleName FROM((T_Function INNER JOIN T_FunctionRole ON T_Function.FunctionID = T_FunctionRole.FunctionID) INNER JOIN T_Roles ON T_FunctionRole.RoleID = T_Roles.RoleID) INNER JOIN T_Users ON T_Roles.RoleID = T_Users.RoleID " +
                                              "WHERE(([T_Users].[UserName] = '" + Value + "' AND ([T_Function].[FunctionName]='" + Value2 + "')))", commandType: CommandType.Text).ToList();
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Get Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Login - 1003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CheckMain(string Value)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                using (OleDbCommand Cmd = new OleDbCommand
                {
                    Connection = Con,
                })
                {
                    List = Con.Query<PROAuth>("SELECT T_Function.FunctionName, T_Roles.RoleName FROM((T_Function INNER JOIN T_FunctionRole ON T_Function.FunctionID = T_FunctionRole.FunctionID) INNER JOIN T_Roles ON T_FunctionRole.RoleID = T_Roles.RoleID) INNER JOIN T_Users ON T_Roles.RoleID = T_Users.RoleID " +
                                              "WHERE(([T_Users].[UserName] = '" + Value + "'))", commandType: CommandType.Text).ToList();
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Get Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Login - 1004", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
