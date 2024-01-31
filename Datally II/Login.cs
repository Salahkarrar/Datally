using Datally.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace Datally
{
    public partial class Login : Form
    {
        public Login() => InitializeComponent();

        public string ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Authority { get; set; }
        public string RoleID { get; set; }
        public string Path { get; set; } = Resources.SVR;
        //public string Path { get; set; } = Resources.D;

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

        //public OleDbConnection Conn { get; set; } = new OleDbConnection(ConfigurationManager.ConnectionStrings["Datally.Properties.Settings.DatallyConn"].ConnectionString);
        public OleDbConnection Conn { get; set; } = new OleDbConnection(Resources.SVRDB);
        //public OleDbConnection Conn { get; set; } = new OleDbConnection(Resources.D);


        private void Login_Load(object sender, EventArgs e)
        {
           // OnInit();
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
                MessageBox.Show(Resources.E6 + "\r\n" + ex.Message, Resources.E1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Conn_Status.ForeColor = Color.Red;
                Conn_Status.Text.Replace(Resources.S1, Resources.S3);
            }
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {

            OleDbCommand Cmd = new OleDbCommand("SELECT * FROM Users WHERE Password=@0", Conn);

            Cmd.Parameters.AddWithValue("@0", PassWord.Text);

            OleDbDataReader Reader = Cmd.ExecuteReader();
            int c = 0;
            while (Reader.Read())
            {
                c += 1;
                ID = Reader[Resources.DB1].ToString();
                UserName = Reader[Resources.DB2].ToString();
                Password = Reader[Resources.DB3].ToString();
                Phone = Reader[Resources.DB4].ToString();
                RoleID = Reader[Resources.DB5].ToString();
            }
            Cmd.Parameters.Clear();
            Reader.Close();
            if (c == 1)
            {
                Hide();
                using (Main D = new Main())
                {
                    D.ShowDialog();
                }
            }
            else
            {
                MessageBoxEx.Show(Resources.E7, 5000);
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
                CommandText = "SELECT * FROM Users WHERE PassWord=@0"
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
                    MessageBoxEx.Show(Resources.E7, 5000);
                }
            }
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Conn.Close();
            dynamic dialog = MessageBox.Show(Resources.E9, Resources.E8, MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                var backupFolder = Resources.BackupFolder;

                var backupFileName = String.Format("{0}{1}~{2}.accdb",
                    backupFolder, "Datally",
                    DateTime.Now.ToString("dd-MM-yyy  hh-mm-ss"));

                string So = Resources.SVRPath;
                string De = backupFileName;

                string backupDir = Resources.PathBackup;
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
                        Console.WriteLine(ex.ToString());
                    }
                }

                File.Copy(So, De);
                MessageBoxEx.Show(Resources.S4, Resources.E8, 700);
                Application.Exit();
            }
        }

        public void Edit_Ico(Button Value, string Value2, Image Value3)
        {
            Value.Text = Value2;
            Value.Image = Value3;
            Value.ImageAlign = ContentAlignment.TopLeft;
            Value.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

    }
}
