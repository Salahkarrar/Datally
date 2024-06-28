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


        public OleDbConnection Conn { get; set; } = new OleDbConnection(Resources.SVRDB);
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        private bool IsLogout { get; set; }
        public int M { get; set; }

        private void Shutdown_Btn_Click(object sender, EventArgs e)
        {
            Conn.Dispose();
            dynamic dialog = MessageBox.Show(Resources.E9, Resources.E8, MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                var backupFolder = Resources.BackupFolder;

                var backupFileName = String.Format("{0}{1}~{2}.accdb",
                    backupFolder, "Radiologix",
                    DateTime.Now.ToString("dd-MM-yyyy  hh-mm-ss"));

                string So = Resources.SVRPath;
                string De = backupFileName;

                string backupDir = Resources.BackupFolder;
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
            else if (dialog == DialogResult.No)
            {
                DialogResult.Cancel.Equals(true);
            }
        }

        private void Minimize_Btn_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void Radiologix_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = e.CloseReason == CloseReason.None;

        private void Radiologix_Load(object sender, EventArgs e)
        {
            MinimizeBox = true;

            Login.Instance.CheckMain(Login.Instance.UserName);
            foreach (var obj in Login.Instance.List)
            {
                Login.Instance.RoleName = obj.RoleName;
                UserName_Txt.Text = $"{Login.Instance.UserName}  |  " + $"{Login.Instance.RoleName}  |";
                if (Home_Btn.Text == obj.FunctionName)
                {
                    Home_Btn.Enabled = true;
                    Home_Btn.Tag = obj.FunctionName;
                }
                else if (Reception_Btn.Text == obj.FunctionName)
                {
                    Reception_Btn.Enabled = true;
                    HReception_Btn.Enabled = true;
                    Reception_Btn.Tag = obj.FunctionName;
                }
                else if (Search_Btn.Text == obj.FunctionName)
                {
                    Search_Btn.Enabled = true;
                    HSearch_Btn.Enabled = true;
                    Search_Btn.Tag = obj.FunctionName;
                }
                else if (Report_Btn.Text == obj.FunctionName)
                {
                    Report_Btn.Enabled = true;
                    HReport_Btn.Enabled = true;
                    Report_Btn.Tag = obj.FunctionName;
                }
                else if (Radiology_Btn.Text == obj.FunctionName)
                {
                    Radiology_Btn.Enabled = true;
                    HRadiology_Btn.Enabled = true;
                    Radiology_Btn.Tag = obj.FunctionName;
                }
                else if (Settings_Btn.Text == obj.FunctionName)
                {
                    Settings_Btn.Enabled = true;
                    HSettings_Btn.Enabled = true;
                    Settings_Btn.Tag = obj.FunctionName;
                }
                else if (Radologist_Btn.Text == obj.FunctionName)
                {
                    Radologist_Btn.Enabled = true;
                    Radologist_Btn.Tag = obj.FunctionName;
                }
                else if (RefDoc_Btn.Text == obj.FunctionName)
                {
                    RefDoc_Btn.Enabled = true;
                    RefDoc_Btn.Tag = obj.FunctionName;
                }
                else if (User_Btn.Text == obj.FunctionName)
                {
                    User_Btn.Enabled = true;
                    User_Btn.Tag = obj.FunctionName;
                }
                else if (Authorities_Btn.Text == obj.FunctionName)
                {
                    Authorities_Btn.Enabled = true;
                    Authorities_Btn.Tag = obj.FunctionName;
                }
                else if (Contract_Btn.Text == obj.FunctionName)
                {
                    Contract_Btn.Enabled = true;
                    Contract_Btn.Tag = obj.FunctionName;
                }
            }

            Home_Btn.Click += Home_Btn_Click;
            Home_Btn_Click(sender, e);
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
            FormName_lab.Text = "Home";
            Side_Panel.Height = Home_Btn.Height;
            Side_Panel.Top = Home_Btn.Top;
            Main_Pan.Controls.Clear();
            Main_Pan.Controls.Add(Sub_Pan);
        }
        public void Home_Btn_Enter(object sender, EventArgs e)
        {
            Home_Btn.Focus();
            Home_Btn.BackColor = Color.FromArgb(52, 152, 219);
            Main_Lab.ForeColor = Color.FromArgb(52, 152, 219);
        }

        public void Home_Btn_Leave(object sender, EventArgs e) => Home_Btn.BackColor = Color.FromArgb(27, 38, 49);

        //Reception;
        public void Reception_Btn_Click(object sender, EventArgs e)
        {
            Side_Panel.Height = Reception_Btn.Height;
            Side_Panel.Top = Reception_Btn.Top;
            Reception_Frm myForm = new Reception_Frm
            {
                TopLevel = false
            };
            {
                Login.Instance.Check(Login.Instance.UserName, myForm.Name);
                foreach (var obj in Login.Instance.List)
                {
                    M = 1;
                    if (myForm.Name == obj.FunctionName)
                    {
                        M = 1;
                        Main_Pan.Controls.Clear();
                        Main_Pan.Controls.Add(myForm);
                        FormName_lab.Text = "Reception";
                        myForm.Show();
                        break;
                    }
                }
                if (Login.Instance.List.Count == 0)
                {
                    MessageBoxEx.Show("Please Check Your Permission.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }

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
            Search_Frm myForm = new Search_Frm
            {
                TopLevel = false
            };
            {
                Login.Instance.Check(Login.Instance.UserName, myForm.Name);
                foreach (var obj in Login.Instance.List)
                {
                    M = 1;
                    if (myForm.Name == obj.FunctionName)
                    {
                        M = 1;
                        Main_Pan.Controls.Clear();
                        Main_Pan.Controls.Add(myForm);
                        FormName_lab.Text = "Search";
                        myForm.Show();
                        break;
                    }
                }
                if (Login.Instance.List.Count == 0)
                {
                    MessageBoxEx.Show("Please Check Your Permission.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
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
            Report_Frm myForm = new Report_Frm
            {
                TopLevel = false
            };
            {
                Login.Instance.Check(Login.Instance.UserName, myForm.Name);
                foreach (var obj in Login.Instance.List)
                {
                    M = 1;
                    if (myForm.Name == obj.FunctionName)
                    {
                        M = 1;
                        Main_Pan.Controls.Clear();
                        Main_Pan.Controls.Add(myForm);
                        FormName_lab.Text = "Report";
                        myForm.Show();
                        break;
                    }
                }
                if (Login.Instance.List.Count == 0)
                {
                    MessageBoxEx.Show("Please Check Your Permission.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
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
            Templetes_Frm myForm = new Templetes_Frm
            {
                TopLevel = false
            };
            {
                Login.Instance.Check(Login.Instance.UserName, myForm.Name);
                foreach (var obj in Login.Instance.List)
                {
                    M = 1;
                    if (myForm.Name == obj.FunctionName)
                    {
                        M = 1;
                        Main_Pan.Controls.Clear();
                        Main_Pan.Controls.Add(myForm);
                        FormName_lab.Text = "Radiology Templates";
                        myForm.Show();
                        break;
                    }
                }
                if (Login.Instance.List.Count == 0)
                {
                    MessageBoxEx.Show("Please Check Your Permission.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
            }
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
            Login.Instance.Check(Login.Instance.UserName, Settings_Frm.Name);
            foreach (var obj in Login.Instance.List)
            {
                M = 1;
                if (Settings_Frm.Name == obj.FunctionName)
                {
                    M = 1;
                    Main_Pan.Controls.Clear();
                    Main_Pan.Controls.Add(Settings_Frm);
                    FormName_lab.Text = "Settings";
                    Settings_Frm.Show();
                    break;
                }
            }
            if (Login.Instance.List.Count == 0)
            {
                MessageBoxEx.Show("Please Check Your Permission.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
            }
        }
        public void Settings_Btn_Enter(object sender, EventArgs e)
        {
            Settings_Btn.Focus();
            Settings_Btn.BackColor = Color.FromArgb(52, 152, 219);
        }

        public void Settings_Btn_Leave(object sender, EventArgs e) => Settings_Btn.BackColor = Color.FromArgb(27, 38, 49);

        private void AddDoc_Txt_Click(object sender, EventArgs e)
        {
            Settings_Frm.BringToFront();
            Settings_Frm.Show();
            Radiologist_Frm myForm = new Radiologist_Frm
            {
                TopLevel = false
            };
            {
                Login.Instance.Check(Login.Instance.UserName, myForm.Name);
                foreach (var obj in Login.Instance.List)
                {
                    M = 1;
                    if (myForm.Name == obj.FunctionName)
                    {
                        M = 1;
                        Main_Pan.Controls.Clear();
                        Main_Pan.Controls.Add(myForm);
                        FormName_lab.Text = "Settings - Radiologist";
                        myForm.Show();
                        break;
                    }
                }
                if (Login.Instance.List.Count == 0)
                {
                    MessageBoxEx.Show("Please Check Your Permission.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
            }
        }
        private void AddUser_Txt_Click(object sender, EventArgs e)
        {
            Settings_Frm.BringToFront();
            Settings_Frm.Show();
            Users_Frm myForm = new Users_Frm
            {
                TopLevel = false
            };
            {
                Login.Instance.Check(Login.Instance.UserName, myForm.Name);
                foreach (var obj in Login.Instance.List)
                {
                    M = 1;
                    if (myForm.Name == obj.FunctionName)
                    {
                        M = 1;
                        Main_Pan.Controls.Clear();
                        Main_Pan.Controls.Add(myForm);
                        FormName_lab.Text = "Settings - Users";
                        myForm.Show();
                        break;
                    }
                }
                if (Login.Instance.List.Count == 0)
                {
                    MessageBoxEx.Show("Please Check Your Permission.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
            }
        }
        private void Per_Txt_Click(object sender, EventArgs e)
        {
            Settings_Frm.BringToFront();
            Settings_Frm.Show();
            Authorities_Frm myForm = new Authorities_Frm
            {
                TopLevel = false
            };
            {
                Login.Instance.Check(Login.Instance.UserName, myForm.Name);
                foreach (var obj in Login.Instance.List)
                {
                    M = 1;
                    if (myForm.Name == obj.FunctionName)
                    {
                        M = 1;
                        Main_Pan.Controls.Clear();
                        Main_Pan.Controls.Add(myForm);
                        FormName_lab.Text = "Settings - Authorities";
                        myForm.Show();
                        break;
                    }
                }
                if (Login.Instance.List.Count == 0)
                {
                    MessageBoxEx.Show("Please Check Your Permission.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
            }
        }

        //About;
        public void About_Btn_Click(object sender, EventArgs e)
        {
            Side_Panel.Height = About_Btn.Height;
            Side_Panel.Top = About_Btn.Top;
            using (About myForm = new About())
            {
                FormName_lab.Text = "About Appliction";
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

        private void Ref_Btn_Click(object sender, EventArgs e)
        {
            Settings_Frm.BringToFront();
            Settings_Frm.Show();
            RefDoc_Frm myForm = new RefDoc_Frm
            {
                TopLevel = false
            };
            {
                Login.Instance.Check(Login.Instance.UserName, myForm.Name);
                foreach (var obj in Login.Instance.List)
                {
                    M = 1;
                    if (myForm.Name == obj.FunctionName)
                    {
                        M = 1;
                        Main_Pan.Controls.Clear();
                        Main_Pan.Controls.Add(myForm);
                        FormName_lab.Text = "Settings - References Doctor";
                        myForm.Show();
                        break;
                    }
                }
                if (Login.Instance.List.Count == 0)
                {
                    MessageBoxEx.Show("Please Check Your Permission.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
            }
        }

        private void Contract_Btn_Click(object sender, EventArgs e)
        {
            Settings_Frm.BringToFront();
            Settings_Frm.Show();
            Contract_Frm myForm = new Contract_Frm
            {
                TopLevel = false
            };
            {
                Login.Instance.Check(Login.Instance.UserName, myForm.Name);
                foreach (var obj in Login.Instance.List)
                {
                    M = 1;
                    if (myForm.Name == obj.FunctionName)
                    {
                        M = 1;
                        Main_Pan.Controls.Clear();
                        Main_Pan.Controls.Add(myForm);
                        FormName_lab.Text = "Settings - Contract";
                        myForm.Show();
                        break;
                    }
                }
                if (Login.Instance.List.Count == 0)
                {
                    MessageBoxEx.Show("Please Check Your Permission.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
            }
        }

        /*End Side Panel*/
    }
}
