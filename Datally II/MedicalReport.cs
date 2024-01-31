using Datally.Properties;
using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Datally
{
    public partial class MedicalReport : Form
    {
        public MedicalReport() => InitializeComponent();

        private bool IsLogout { get; set; }

        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        //public OleDbConnection Conn { get; set; } = new OleDbConnection(ConfigurationManager.ConnectionStrings["Datally.Properties.Settings.DatallyConn"].ConnectionString);
        public OleDbConnection Conn { get; set; } = new OleDbConnection(Resources.SVRDB);
        //public OleDbConnection Conn { get; set; } = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Datally\\DataBase\\Datally.accdb;Jet OLEDB:Database Password=Datally@2020$;");
        public string Path { get; set; } = Resources.SVRMR;
        //public string Path { get; set; } = Resources.DMR;

        private void MedicalReport_Load(object sender, EventArgs e)
        {
            Medical_DataTabAd.Fill(datallyDataSet.Medical_Data);
            MedicalDataBindSour.MoveLast();
            Date_Txt.Value = DateTime.Today;
            Edit(true, false);
            New_D_Btn.Focus();
            //Begin();
        }

        private void Datally_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = e.CloseReason == CloseReason.None;

        private void Singout_Btn_Click(object sender, EventArgs e)
        {
            IsLogout = true;
            Login.Instance.Show();
            Hide();
        }

        private void Shutdown_Btn_Click(object sender, EventArgs e)
        {
            Conn.Dispose();
            dynamic dialog = MessageBox.Show(Resources.E9, Resources.E8, MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                var backupFolder = Resources.BackupFolder;

                var backupFileName = String.Format("{0}{1}~{2}.accdb",
                    backupFolder, "Datally",
                    DateTime.Now.ToString("dd-MM-yyyy hh-mm-ss"));

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

        /*  PATIENT DATA  */
        private void New_D_Btn_Click(object sender, EventArgs e)
        {
            Edit(false, true);
            Save_D_Btn.Enabled = true;
            datallyDataSet.Medical_Data.AddMedical_DataRow(datallyDataSet.Medical_Data.NewMedical_DataRow());
            MedicalDataBindSour.MoveLast();
            Name_Txt.Focus();
        }

        private void Date_Txt_Enter(object sender, EventArgs e) => Date_Txt.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");

        private void Save_D_Btn_Click(object sender, EventArgs e)
        {
            if (Name_Txt.TextLength > 0 && Age_Txt.TextLength > 0)
            {
                string FilePath = Path + "Report\\" + ID_Txt.Text + "_" + Name_Txt.Text + ".docx";
                Edit(true, false);
                Save_D_Btn.Enabled = false;
                SaveData();
                SaveData2();
                datallyDataSet.Medical_Data.AddMedical_DataRow(datallyDataSet.Medical_Data.NewMedical_DataRow());
                MedicalDataBindSour.MoveLast();
                P_Report(FilePath);
                MessageBoxEx.Show(Resources.Save, 700);
            }
            else
            {
                MessageBoxEx.Show(Resources.E5, Resources.E1, MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
            }
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ID_Txt.Text))
            {
                try
                {
                    switch (Edit_Btn.Text)
                    {
                        case "Edit":
                            {
                                Edit(false, true);
                                New_D_Btn.Enabled = false;
                                Save_D_Btn.Enabled = false;

                                Edit_Btn.Text = "Update";
                                Edit_Btn.Image = null;
                                Edit_Btn.Image = Resources.ic_send_white_18dp;
                                Edit_Btn.ImageAlign = ContentAlignment.TopLeft;
                                Edit_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                                string So = Path + "Report\\" + ID_Txt.Text + "_" + Name_Txt.Text + ".docx";
                                string De = Path + ID_Txt.Text + ".docx";
                                File.Move(So, De);
                                break;
                            }

                        case "Update":
                            {
                                Edit(true, false);
                                New_D_Btn.Enabled = true;

                                Edit_Ico();
                                try
                                {
                                    if (Conn.State == ConnectionState.Closed)
                                    {
                                        Conn.Open();
                                    }

                                    using (OleDbCommand Cmd = new OleDbCommand
                                    {
                                        Connection = Conn
                                    })
                                    {
                                        string Qurey = "UPDATE Medical_Data SET P_Name=@0, P_Age=@1 ,P_Date=@2 WHERE ID=@3";
                                        Cmd.Parameters.AddWithValue("@0", Name_Txt.Text);
                                        Cmd.Parameters.AddWithValue("@1", Age_Txt.Text);
                                        Cmd.Parameters.AddWithValue("@2", Date_Txt.Text);
                                        Cmd.Parameters.AddWithValue("@3", ID_Txt.Text);
                                        Cmd.CommandText = Qurey;
                                        Cmd.ExecuteNonQuery();
                                        Cmd.Parameters.Clear();
                                        Conn.Close();
                                    }
                                    //Begin();
                                    MessageBoxEx.Show(Resources.Save, Resources.Information, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(Resources.E11 + "\r\n" + ex.Message, Resources.E1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                string So = Path + "Report\\" + ID_Txt.Text + "_" + Name_Txt.Text + ".docx";
                                string De = Path + ID_Txt.Text + ".docx";
                                File.Move(De, So);
                                break;
                            }

                        default:
                            Edit(true, false);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Resources.E11 + "\r\n" + ex.Message, Resources.E1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Cancel_D_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Edit_Ico();
                if (!string.IsNullOrEmpty(ID_Txt.Text))
                {
                    Edit(true, false);

                    MedicalDataBindSour.CancelEdit();
                    Medical_DataTabAd.Fill(datallyDataSet.Medical_Data);
                    string So = Path + "Report\\" + ID_Txt.Text + "_" + Name_Txt.Text + ".docx";
                    string De = Path + "Report\\" + ID_Txt.Text + ".docx";
                    if (File.Exists(De))
                    {
                        File.Move(De, So);
                    }
                }
                else
                {
                    Edit(true, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is Some Problem" + "\r\n" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Age_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsNumber(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void Name_Txt_Enter(object sender, EventArgs e)
        {
            SwitchInput(GetInput("arabic"));
        }

        private void Age_Txt_Enter(object sender, EventArgs e)
        {
            SwitchInput(GetInput("english"));
        }

        /*  Services */

        private void Report_Btn_Click(object sender, EventArgs e)
        {
            string FilePath = Path + "Report\\" + ID_Txt.Text + "_" + Name_Txt.Text + ".docx";

            if (!string.IsNullOrEmpty(ID_Txt.Text) && !string.IsNullOrEmpty(Name_Txt.Text) && File.Exists(FilePath))
            {
                P_Report(FilePath);
            }
            else
            {
                dynamic dialog = MessageBox.Show("File Not Exist" + "\r\n" + "Do you Wont Create Report?", Resources.Information, MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    SaveData2();
                    P_Report(FilePath);
                }
            }
        }

        /* Function*/
        private void Edit(bool Value, bool Value2)
        {
            Save_D_Btn.Enabled = Value2;
            Name_Txt.ReadOnly = Value;
            Age_Txt.ReadOnly = Value;
            Date_Txt.Enabled = Value2;
        }

        private void Edit_Ico()
        {
            Edit_Btn.Text = "Edit";
            Edit_Btn.Image = Datally.Properties.Resources.ic_edit_white_18dp;
            Edit_Btn.ImageAlign = ContentAlignment.TopLeft;
            Edit_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        private void P_Report(string Value)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document doc = null;
            object missing = Type.Missing;

            for (int i = 0; i <= 1; i++)
            {
                if (File.Exists(Value))
                {
                    doc = app.Documents.Open(Value);
                    app.Selection.Find.ClearFormatting();
                    app.Selection.Find.Replacement.ClearFormatting();
                    app.Visible = true;
                }
                else
                {
                    MessageBoxEx.Show("File Not Exist", 1000);
                    break;
                }


                string[] tmp = new string[3];
                tmp = ReadData();

                app.Selection.Find.Execute("<Name>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[0], 2);
                app.Selection.Find.Execute("<Age>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[1], 2);
                app.Selection.Find.Execute("<Date>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[2], 2);
            }
        }

        private string[] ReadData()
        {
            string[] data = new string[3];
            data[0] = " " + Name_Txt.Text;
            data[1] = " " + Age_Txt.Text;
            data[2] = " " + Date_Txt.Text;
            return data;

        }

        public void SaveData()
        {
            try
            {
                if (Name_Txt.TextLength > 0 && Age_Txt.TextLength > 0)
                {
                    if (Conn.State == ConnectionState.Closed)
                    {
                        Conn.Open();
                    }

                    Cmd.Connection = Conn;
                    Cmd.CommandText = "insert into Medical_Data (P_Name,P_Age,P_Date) values('" + Name_Txt.Text + "','" + Age_Txt.Text + "','" + Date_Txt.Text + "')";
                    Cmd.ExecuteNonQuery();

                    Conn.Close();
                }
                else
                {
                    MessageBoxEx.Show("Please Check Your Data and Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is Some Problem" + "\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveData2()
        {
            try
            {
                if (!string.IsNullOrEmpty(Name_Txt.Text))
                {
                    string sourceFileName = Path + "Templete\\Medical Report.docx";
                    string destFileName = Path + "Report\\" + ID_Txt.Text + "_" + Name_Txt.Text + ".docx";
                    string destFileName2 = Path + "Report\\" + ID_Txt.Text + "_" + Name_Txt.Text + "_" + 2 + ".docx";
                    if (File.Exists(sourceFileName))
                    {
                        if (File.Exists(destFileName))
                        {
                            DialogResult dialog = MessageBox.Show("File Exist!!" + "\r\n" + "Do You Want To Make New File?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                            if (dialog == DialogResult.Yes)
                            {
                                File.Copy(sourceFileName, destFileName2);
                            }
                            else if (dialog == DialogResult.No)
                            {
                                P_Report(sourceFileName);
                                DialogResult.Cancel.Equals(true);
                            }
                            else if (dialog == DialogResult.Cancel)
                            {
                                DialogResult.Cancel.Equals(true);
                            }
                        }
                        else
                        {
                            File.Copy(sourceFileName, destFileName);
                        }
                    }
                    else
                    {
                        File.Copy(Path + "Backup\\Templete\\Medical Report.docx", destFileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.E11 + "\r\n" + ex.Message, Resources.E1, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Se()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                Cmd.Connection = Conn;
                Cmd.CommandText = "Select * from Medical_Data where P_Name='" + MedicalReport_Grid.CurrentCell.Value + "'";

                OleDbDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    ID_Txt.Text = Reader["ID"].ToString();
                    Name_Txt.Text = Reader["P_Name"].ToString();
                    Age_Txt.Text = Reader["P_Age"].ToString();
                    Date_Txt.Text = Reader["P_Date"].ToString();
                }
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is Some Problem" + "\r\n" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static InputLanguage GetInput(string inputName)
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.Culture.EnglishName.ToLower().StartsWith(inputName))
                {
                    return lang;
                }
            }
            return null;
        }

        private void SwitchInput(InputLanguage layout) => InputLanguage.CurrentInputLanguage = layout;

        /*About*/

        private void About_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (About A = new About())
            {
                A.ShowDialog();
            }
        }

        private void Search_Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(Search_Txt.Text))
                {
                    Fill();
                }
                else
                {
                    if (Conn.State == ConnectionState.Closed)
                    {
                        Conn.Open();
                    }

                    Cmd.Connection = Conn;
                    Cmd.CommandText = "SELECT P_Name FROM Medical_Data WHERE P_Name LIKE'%" + Search_Txt.Text + "%'";

                    using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                    {
                        DataTable Dt = new DataTable();
                        Da.Fill(Dt);
                        MedicalReport_Grid.DataSource = Dt;
                    }
                    Conn.Close();
                }
            }
        }

        public void Fill()
        {
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }

            Cmd.Connection = Conn;
            Cmd.CommandText = "SELECT P_Name FROM Medical_Data";

            using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
            {
                DataTable Dt = new DataTable();
                Da.Fill(Dt);
                MedicalReport_Grid.DataSource = Dt;
            }
            Conn.Close();
        }
    }
}
