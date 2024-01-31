using Datally.Properties;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Datally
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        //public OleDbConnection Conn { get; set; } = new OleDbConnection(ConfigurationManager.ConnectionStrings["Datally.Properties.Settings.DatallyConn"].ConnectionString);
        //public OleDbConnection Conn { get; set; } = new OleDbConnection(Resources.SVRDB);
        public OleDbConnection Conn { get; set; } = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Datally\\DataBase\\Datally.accdb;Jet OLEDB:Database Password=Datally@2020$;");
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        //public string Path { get; set; } = Resources.SVR;
        public string Path { get; set; } = Resources.D;
        private bool IsLogout { get; set; }

        private void Shutdown_Btn_Click(object sender, EventArgs e)
        {
            Conn.Dispose();
            dynamic dialog = MessageBox.Show(Resources.E9, Resources.E8, MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                var backupFolder = Resources.BackupFolder;

                var backupFileName = String.Format("{0}{1}~{2}.accdb",
                    backupFolder, "Datally",
                    DateTime.Now.ToString("dd-MM-yyyy  hh-mm-ss"));

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
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                DialogResult.Cancel.Equals(true);
            }
        }

        private void Minimize_Btn_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void Datally_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = e.CloseReason == CloseReason.None;

        private void Datally_Load(object sender, EventArgs e)
        {
            UserName_Txt.Text = $"{Login.Instance.UserName}";
            MinimizeBox = true;
            //Home_Btn_Enter(sender, e);


            if (Convert.ToInt32(Login.Instance.RoleID) == 1)
            {
                Home_Btn.Enabled = true;
                Reception_Btn.Enabled = true;
                Search_Btn.Enabled = true;
                Report_Btn.Enabled = true;
                Settings_Btn.Enabled = true;
                Radiology_Btn.Enabled = true;

                HReception_Btn.Enabled = true;
                HSearch_Btn.Enabled = true;
                HReport_Btn.Enabled = true;
                HSettings_Btn.Enabled = true;
                HRadiology_Btn.Enabled = true;
            }
            else if (Convert.ToInt32(Login.Instance.RoleID) == 2)
            {
                Home_Btn.Enabled = true;
                Reception_Btn.Enabled = true;
                Search_Btn.Enabled = true;
                Report_Btn.Enabled = true;
                Radiology_Btn.Enabled = true;

                HReception_Btn.Enabled = true;
                HSearch_Btn.Enabled = true;
                HReport_Btn.Enabled = true;
                HSettings_Btn.Enabled = false;
                HRadiology_Btn.Enabled = true;
            }
            Singout_Btn.Click += Singout_Btn_Click;
            Home_Btn.Click += Home_Btn_Click;
            Home_Btn_Enter(sender, e);
        }

        private void Singout_Btn_Click(object sender, EventArgs e)
        {
            IsLogout = true;
            Login.Instance.Show();
            Hide();
        }

        /*Side Panel*/

        //Home;
        public void Home_Btn_Click(object sender, EventArgs e)
        {
            Side_Panel.Height = Home_Btn.Height;
            Side_Panel.Top = Home_Btn.Top;
            Main_Pan.Controls.Clear();
            Main_Pan.Controls.Add(Sub_Pan);
        }
        public void Home_Btn_Enter(object sender, EventArgs e)
        {
            Home_Btn.Focus();
            Home_Btn.BackColor = Color.FromArgb(52, 152, 219);
        }

        public void Home_Btn_Leave(object sender, EventArgs e) => Home_Btn.BackColor = Color.FromArgb(27, 38, 49);

        //Reception;
        public void Reception_Btn_Click(object sender, EventArgs e)
        {
            Side_Panel.Height = Reception_Btn.Height;
            Side_Panel.Top = Reception_Btn.Top;
            Reception myForm = new Reception
            {
                TopLevel = false
            };
            {
                Main_Pan.Controls.Clear();
                Main_Pan.Controls.Add(myForm);
                myForm.Show();
            }
        }
        public void Reception_Btn_Enter(object sender, EventArgs e)
        {
            Reception_Btn.Focus();
            Reception_Btn.BackColor = Color.FromArgb(52, 152, 219);
        }

        public void Reception_Btn_Leave(object sender, EventArgs e) => Reception_Btn.BackColor = Color.FromArgb(27, 38, 49);

        //Search;
        public void Search_Btn_Click(object sender, EventArgs e)
        {
            Side_Panel.Height = Search_Btn.Height;
            Side_Panel.Top = Search_Btn.Top;
            Search myForm = new Search
            {
                TopLevel = false
            };
            {
                Main_Pan.Controls.Clear();
                Main_Pan.Controls.Add(myForm);
                myForm.Show();
            }
        }
        public void Search_Btn_Enter(object sender, EventArgs e)
        {
            Search_Btn.Focus();
            Search_Btn.BackColor = Color.FromArgb(52, 152, 219);
        }

        public void Search_Btn_Leave(object sender, EventArgs e) => Search_Btn.BackColor = Color.FromArgb(27, 38, 49);

        //Report;
        public void Report_Btn_Click(object sender, EventArgs e)
        {
            Side_Panel.Height = Report_Btn.Height;
            Side_Panel.Top = Report_Btn.Top;
            Report myForm = new Report
            {
                TopLevel = false
            };
            {
                Main_Pan.Controls.Clear();
                Main_Pan.Controls.Add(myForm);
                myForm.Show();
            }
        }
        public void Report_Btn_Enter(object sender, EventArgs e)
        {
            Report_Btn.Focus();
            Report_Btn.BackColor = Color.FromArgb(52, 152, 219);
        }

        public void Report_Btn_Leave(object sender, EventArgs e) => Report_Btn.BackColor = Color.FromArgb(27, 38, 49);

        //Radiology;
        public void Radiology_Btn_Click(object sender, EventArgs e)
        {
            Side_Panel.Height = Radiology_Btn.Height;
            Side_Panel.Top = Radiology_Btn.Top;
            Templetes myForm = new Templetes
            {
                TopLevel = false
            };
            Main_Pan.Controls.Clear();
            Main_Pan.Controls.Add(myForm);
            myForm.Show();
        }
        public void Radiology_Btn_Enter(object sender, EventArgs e)
        {
            Radiology_Btn.Focus();
            Radiology_Btn.BackColor = Color.FromArgb(52, 152, 219);
        }

        public void Radiology_Btn_Leave(object sender, EventArgs e) => Radiology_Btn.BackColor = Color.FromArgb(27, 38, 49);

        //Settings;
        public void Settings_Btn_Click(object sender, EventArgs e)
        {
            Side_Panel.Height = Settings_Btn.Height;
            Side_Panel.Top = Settings_Btn.Top;
            Main_Pan.Controls.Clear();
            Main_Pan.Controls.Add(panel1);
            panel1.Show();
        }
        public void Settings_Btn_Enter(object sender, EventArgs e)
        {
            Settings_Btn.Focus();
            Settings_Btn.BackColor = Color.FromArgb(52, 152, 219);
        }

        public void Settings_Btn_Leave(object sender, EventArgs e) => Settings_Btn.BackColor = Color.FromArgb(27, 38, 49);

        private void AddDoc_Txt_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            panel1.Show();
            AddDoc myForm = new AddDoc
            {
                TopLevel = false
            };
            {
                Main_Pan.Controls.Clear();
                Main_Pan.Controls.Add(myForm);
                myForm.Show();
            }
        }
        private void AddUser_Txt_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            panel1.Show();
            AddUser myForm = new AddUser
            {
                TopLevel = false
            };
            Main_Pan.Controls.Clear();
            Main_Pan.Controls.Add(myForm);
            myForm.Show();
        }
        private void Per_Txt_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            panel1.Show();
            AddPermission myForm = new AddPermission
            {
                TopLevel = false
            };
            Main_Pan.Controls.Clear();
            Main_Pan.Controls.Add(myForm);
            myForm.Show();
        }

        //About;
        public void About_Btn_Click(object sender, EventArgs e)
        {
            Side_Panel.Height = About_Btn.Height;
            Side_Panel.Top = About_Btn.Top;
            using (About myForm = new About())
            {
                myForm.ShowDialog();
            }
        }
        public void About_Btn_Enter(object sender, EventArgs e)
        {
            About_Btn.Focus();
            About_Btn.BackColor = Color.FromArgb(52, 152, 219);
        }

        public void About_Btn_Leave(object sender, EventArgs e) => About_Btn.BackColor = Color.FromArgb(27, 38, 49);

        private void About_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (About A = new About())
            {
                A.ShowDialog();
            }
        }

        /*End Side Panel*/
    }
}
