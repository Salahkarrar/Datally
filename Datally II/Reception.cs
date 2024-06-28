using Datally.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Datally
{
    public partial class Reception_Frm : Form
    {
        public Reception_Frm() => InitializeComponent();

        public bool IsLogout { get; set; }
        public OleDbConnection Conn { get; set; } = new OleDbConnection(Resources.SVRDB);

        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        public Control Ctrl { get; set; }
        public string Path { get; set; } = Application.StartupPath + "\\";

        private void Singout_Btn_Click(object sender, EventArgs e)
        {
            IsLogout = true;
            Login.Instance.Show();
            Hide();
        }

        private void Reception_Load(object sender, EventArgs e)
        {
            T_ContractTabAd.Fill(datallyDataSet.T_Contract);
            RefDocTabAd.Fill(datallyDataSet.RefDoctor);
            P_DataTabAd.Fill(datallyDataSet.P_Data);
            Date_Txt.Value = DateTime.Today;
            MinimizeBox = true;
            Date_Txt.CalendarMonthBackground = Color.FromArgb(27, 38, 49);
            Edit(true, false);
            Login.Instance.CheckMain(Login.Instance.UserName);
            foreach (var obj in Login.Instance.List)
            {
                if (New_Btn.Name == obj.FunctionName)
                {
                    New_Btn.Enabled = true;
                }
                else if (S_New_Btn.Name == obj.FunctionName)
                {
                    S_New_Btn.Enabled = true;
                }
                else if (Save_Btn.Name == obj.FunctionName)
                {
                    Save_Btn.Enabled = true;
                }
                else if (S_Save_Btn.Name == obj.FunctionName)
                {
                    S_Save_Btn.Enabled = true;
                }
                else if (Edit_Btn.Name == obj.FunctionName)
                {
                    Edit_Btn.Enabled = true;
                }
                else if (Cancel_Btn.Name == obj.FunctionName)
                {
                    Cancel_Btn.Enabled = true;
                }
                else if (Report_Btn.Name == obj.FunctionName)
                {
                    Report_Btn.Enabled = true;
                }
                else if (S_Report_Btn.Name == obj.FunctionName)
                {
                    S_Report_Btn.Enabled = true;
                }
                else if (New_Report_Btn.Name == obj.FunctionName)
                {
                    New_Report_Btn.Enabled = true;
                }
            }
        }

        private void Shutdown_Btn_Click(object sender, EventArgs e)
        {
            Close();
            Main main = new Main();
            main.Show();
        }

        /*  PATIENT DATA  */
        private void New_Btn_Click(object sender, EventArgs e)
        {
            Edit(false, true);
            TempleteBindSour.AddNew();
            TempleteTabAd.Fill(datallyDataSet.Templete);
            DocBindSour.AddNew();
            DocTabAd.Fill(datallyDataSet.Doctor);
            S_Serveice_Group.Hide();
            Patiant_Group2.Hide();
            datallyDataSet.P_Data.AddP_DataRow(datallyDataSet.P_Data.NewP_DataRow());
            P_DataBindSour.MoveLast();
            Name_Txt.Focus();
            New_Btn.Enabled = false;
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            if (Name_Txt.TextLength > 0 && Age_Txt.TextLength > 0 && !string.IsNullOrEmpty(Sex_Txt.Text)
                && !string.IsNullOrEmpty(Card_Txt.Text) && !string.IsNullOrEmpty(Date_Txt.Text))
            {
                Edit(true, false);
                SaveData();
                New_Report_Click(sender, e);
                New_Btn.Enabled = true;
            }
            else
            {
                MessageBoxEx.Show(Resources.E5, Resources.E1, MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
            }
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(ID_Txt.Text))
                {
                    if (Edit_Btn.Text == "Edit" && !string.IsNullOrEmpty(Services_TxT.Text))
                    {
                        Edit(false, true);
                        New_Btn.Enabled = false;
                        Save_Btn.Enabled = false;
                        Services_Combo.Enabled = false;

                        Login.Instance.Edit_Ico(Edit_Btn, "Update", Resources.ic_send_white_18dp);

                        string So = Path + "P_Report\\" + ID_Txt.Text + "_" + Name_Txt.Text + "_" + Services_TxT.Text + ".docx";
                        string De = Path + "P_Report\\" + ID_Txt.Text + ".docx";
                        File.Move(So, De);
                    }
                    else if (Edit_Btn.Text == "Update")
                    {
                        Edit(true, false);
                        New_Btn.Enabled = true;
                        Services_Combo.Enabled = false;

                        Login.Instance.Edit_Ico(Edit_Btn, "Edit", Resources.ic_edit_white_18dp);
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
                                string Qurey = "UPDATE P_Data SET P_Name ='" + Name_Txt.Text + "',Age='" + Age_Txt.Text + "',Sex='" + Sex_Txt.Text + "',Card='" + Card_Txt.Text + "',Ref='" + Ref_Txt.Text + "' WHERE ID= " + ID_Txt.Text + "";
                                Cmd.CommandText = Qurey;
                                Cmd.ExecuteNonQuery();
                            }
                            MessageBoxEx.Show(Resources.Update, Resources.Information, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(Resources.E11 + "\r\n" + ex.Message, Resources.E1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Conn.Close();

                        string So = Path + "P_Report\\" + ID_Txt.Text + "_" + Name_Txt.Text + "_" + Services_TxT.Text + ".docx";
                        string De = Path + "P_Report\\" + ID_Txt.Text + ".docx";
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
                MessageBox.Show(Resources.E11 + "\r\n" + ex.Message, Resources.E1, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                S_Serveice_Group.Hide();
                Patiant_Group2.Hide();
                Login.Instance.Edit_Ico(Edit_Btn, "Edit", Resources.ic_edit_white_18dp);
                Edit(true, false);
                P_DataBindSour.CancelEdit();
                P_DataTabAd.Fill(datallyDataSet.P_Data);
                string So = Path + "P_Report\\" + ID_Txt.Text + "_" + Name_Txt.Text + "_" + Services_Combo.Text + ".docx";
                string De = Path + "P_Report\\" + ID_Txt.Text + ".docx";
                if (File.Exists(De))
                {
                    File.Move(De, So);
                }
                else
                {
                    Edit(true, false);
                }
                New_Btn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.E11 + "\r\n" + ex.Message, Resources.E1, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void New_Report_Click(object sender, EventArgs e)
        {
            Patiant_Group2.Show();
            Patiant_Group2.BringToFront();
            TempleteBindSour.AddNew();
            TempleteTabAd.Fill(datallyDataSet.Templete);
            DocBindSour.AddNew();
            DocTabAd.Fill(datallyDataSet.Doctor);
            Services_Combo.Enabled = true;
            Doctor_Txt.Enabled = true;
            S_Save_Btn.Enabled = true;
        }

        private void S_Save_Btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Services_Combo.Text) && !string.IsNullOrEmpty(Doctor_Txt.Text))
            {
                Services_Combo.Enabled = false;
                Doctor_Txt.Enabled = false;
                S_Save_Btn.Enabled = false;
                SaveData2();
                Report_Btn_Click(sender, e);
            }
            else
            {
                MessageBoxEx.Show(Resources.E2, 1000);
            }
        }

        private void Report_Btn_Click(object sender, EventArgs e)
        {
            string FilePath = Path + "P_Report\\" + ID_Txt.Text + "_" + Name_Txt.Text + "_" + Services_Combo.Text + ".docx";
            P_Report(FilePath);
        }

        private void S_Report_Btn_Click(object sender, EventArgs e)
        {
            string FilePath = Path + "P_Report\\" + ID_Txt.Text + "_" + Name_Txt.Text + "_" + Services_TxT.Text + ".docx";
            P_Report(FilePath);
        }

        private void S_New_Btn_Click(object sender, EventArgs e) => New_Report_Click(sender, e);

        private void Services_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = Services_DataGrid.Rows[e.RowIndex];
                Services_TxT.Text = row.Cells[e.ColumnIndex].Value.ToString();

                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                Cmd.Connection = Conn;
                Cmd.CommandText = "SELECT * FROM P_Report WHERE ID=" + ID_Txt.Text + " AND Services='" + Services_TxT.Text + "'";
                OleDbDataReader Reader = Cmd.ExecuteReader();

                while (Reader.Read())
                {
                    Doctor_Combo.Text = Reader["Doctor"].ToString();
                }
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.E11 + "\r\n" + ex.Message, Resources.E1, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PData_Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Se();
        }



        private void PData_Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Delete && MessageBox.Show("Do You Want to Delete This Patient Data", Resources.Question, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string FilePath = Path + "P_Report\\" + ID_Txt.Text + "_" + Name_Txt.Text + "_" + Services_TxT.Text + ".docx";
                    File.Delete(FilePath);
                    P_DataBindSour.RemoveCurrent();
                    P_DataTabAd.Update(datallyDataSet.P_Data);
                    PData_Grid.Refresh();
                    Edit(true, false);
                    Patiant_Group2.Show();
                    Patiant_Group2.BringToFront();
                    MessageBoxEx.Show(Resources.Delete, Resources.Information, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Resources.E1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult.Cancel.Equals(true);
            }
        }

        private void Services_DataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => S_Report_Btn_Click(sender, e);

        private void Close_Click(object sender, EventArgs e) => Patiant_Group2.Hide();

        /* Function*/
        private void Edit(bool Value, bool Value2)
        {
            Save_Btn.Enabled = Value2;
            Name_Txt.ReadOnly = Value;
            Age_Txt.ReadOnly = Value;
            Cash_Txt.ReadOnly = Value;
            Date_Txt.Enabled = Value2;
            Sex_Txt.Enabled = Value2;
            Card_Txt.Enabled = Value2;
            Ref_Txt.Enabled = Value2;
        }

        private void P_Report(string Value)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document Doc = null;
            object missing = Type.Missing;

            for (int i = 0; i <= 1; i++)
            {
                if (File.Exists(Value))
                {
                    Doc = app.Documents.Open(Value);
                    app.Selection.Find.ClearFormatting();
                    app.Selection.Find.Replacement.ClearFormatting();
                    app.Visible = true;
                }
                else
                {
                    MessageBoxEx.Show(Resources.NotExist, 1000);
                    break;
                }

                _ = new string[6];
                string[] tmp = ReadData();

                app.Selection.Find.Execute("<ID>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[0], 2);
                app.Selection.Find.Execute("<Name>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[1], 2);
                app.Selection.Find.Execute("<Age>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[2], 2);
                app.Selection.Find.Execute("<Date>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[3], 2);
                app.Selection.Find.Execute("<Ref>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[4], 2);
                app.Selection.Find.Execute("<Doctor>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[5], 2);
                app.Selection.Find.Execute("<Tittle>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[6], 2);
            }
        }

        private string[] ReadData()
        {
            string[] data = new string[9];
            data[0] = " " + ID_Txt.Text;
            data[1] = " " + Name_Txt.Text;
            data[2] = " " + Age_Txt.Text + "Yrs";
            data[3] = " " + Date_Txt.Text;
            data[4] = " " + Ref_Txt.Text;
            data[5] = " " + Doctor_Txt.Text;
            data[6] = Services_Combo.Text;
            data[7] = " " + Doctor_Combo.Text;
            data[8] = Services_TxT.Text;
            return data;
        }

        public void SaveData()
        {
            try
            {
                if (!string.IsNullOrEmpty(Name_Txt.Text) && !string.IsNullOrEmpty(Age_Txt.Text) && !string.IsNullOrEmpty(Sex_Txt.Text)
                    && !string.IsNullOrEmpty(Card_Txt.Text) && !string.IsNullOrEmpty(Date_Txt.Text))
                //Insert Data to Database;
                {
                    if (Conn.State == ConnectionState.Closed)
                    {
                        Conn.Open();
                    }

                    Cmd.Connection = Conn;
                    Cmd.CommandText = "INSERT INTO P_Data (P_Name,Sex,Age,Card,P_Date,Ref) VALUES (@0,@1,@2,@3,@4,@5)";
                    Cmd.Parameters.AddWithValue("@0", Name_Txt.Text);
                    Cmd.Parameters.AddWithValue("@1", Sex_Txt.Text);
                    Cmd.Parameters.AddWithValue("@2", Age_Txt.Text);
                    Cmd.Parameters.AddWithValue("@3", Card_Txt.Text);
                    Cmd.Parameters.AddWithValue("@4", Date_Txt.Text);
                    Cmd.Parameters.AddWithValue("@5", Ref_Txt.Text);
                    Cmd.ExecuteNonQuery();
                    Cmd.Parameters.Clear();
                    MessageBoxEx.Show(Resources.Save, Resources.Information, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                    Conn.Close();

                    Patiant_Group2.Visible = true;
                    Services_Combo.Focus();
                }
                else
                {
                    MessageBoxEx.Show(Resources.E5, Resources.E1, MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.E11 + "\r\n" + ex.Message, Resources.E1, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveData2()
        {
            try
            {
                if (!string.IsNullOrEmpty(Services_Combo.Text))
                {
                    string sourceFileNameUS = Path + "Templete\\US\\" + Services_Combo.Text + ".docx";
                    string sourceFileNameCT = Path + "Templete\\CT\\" + Services_Combo.Text + ".docx";
                    string sourceFileNameMRI = Path + "Templete\\MRI\\" + Services_Combo.Text + ".docx";
                    string sourceFileNameX_RAY = Path + "Templete\\X_RAY\\" + Services_Combo.Text + ".docx";
                    string destFileName = Path + "P_Report\\" + ID_Txt.Text + "_" + Name_Txt.Text + "_" + Services_Combo.Text + ".docx";
                    if (File.Exists(sourceFileNameUS))
                    {
                        if (File.Exists(destFileName))
                        {
                            MessageBoxEx.Show(Resources.FileExist, Resources.E1, 700);
                        }
                        else
                        {
                            Insert_R();
                            File.Copy(sourceFileNameUS, destFileName);
                        }
                    }
                    else if (File.Exists(sourceFileNameCT))
                    {
                        if (File.Exists(destFileName))
                        {
                            MessageBoxEx.Show(Resources.FileExist, Resources.E1, 700);
                        }
                        else
                        {
                            Insert_R();
                            File.Copy(sourceFileNameCT, destFileName);
                        }
                    }
                    else if (File.Exists(sourceFileNameMRI))
                    {
                        if (File.Exists(destFileName))
                        {
                            MessageBoxEx.Show(Resources.FileExist, Resources.E1, 700);
                        }
                        else
                        {
                            Insert_R();
                            File.Copy(sourceFileNameMRI, destFileName);
                        }
                    }
                    else if (File.Exists(sourceFileNameX_RAY))
                    {
                        if (File.Exists(destFileName))
                        {
                            MessageBoxEx.Show(Resources.FileExist, Resources.E1, 700);
                        }
                        else
                        {
                            Insert_R();
                            File.Copy(sourceFileNameX_RAY, destFileName);
                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("No Templete", Resources.Information, MessageBoxButtons.OK, MessageBoxIcon.Information, 500);
                        File.Copy(Path + "Templete\\Templete.docx", destFileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.E11 + "\r\n" + ex.Message, Resources.E1, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Insert_R()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                Cmd.Connection = Conn;
                string Qurey = "INSERT INTO P_Report (ID,Name,Services,Doctor) VALUES (@0,@1,@2,@3);";
                Cmd.CommandText = Qurey;
                Cmd.Parameters.AddWithValue("@0", ID_Txt.Text);
                Cmd.Parameters.AddWithValue("@1", Name_Txt.Text);
                Cmd.Parameters.AddWithValue("@2", Services_Combo.Text);
                Cmd.Parameters.AddWithValue("@3", Doctor_Txt.Text);

                Cmd.ExecuteNonQuery();
                Cmd.Parameters.Clear();
                Conn.Close();
                MessageBoxEx.Show(Resources.Save, 700);
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
                Services_TxT.Clear();
                Doctor_Combo.Text = null;

                S_Serveice_Group.Show();
                S_Serveice_Group.BringToFront();
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                Cmd.Connection = Conn;
                Cmd.CommandText = "SELECT Services FROM P_Report WHERE ID= " + ID_Txt.Text + "";

                OleDbDataAdapter Da = new OleDbDataAdapter(Cmd);

                DataTable Dt = new DataTable();
                Da.Fill(Dt);
                Services_DataGrid.DataSource = Dt;

                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.E11 + "\r\n" + ex.Message, Resources.E1, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Card_Txt_Leave(object sender, EventArgs e)
        {
            Contract(Card_Txt.Text);
            Cash_Txt.ReadOnly = true;
        }

        public void Enter_KeyDown(object sender, KeyEventArgs e)
        {
            Ctrl = (Control)sender;
            if (Ctrl is TextBox)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SelectNextControl(Ctrl, true, true, true, true);
                }
                else
                    return;
            }
            else if (Ctrl is ComboBox)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SelectNextControl(Ctrl, true, true, true, true);
                }
                else
                    return;
            }
            else if (Ctrl is DateTimePicker)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SelectNextControl(Ctrl, true, true, true, true);
                }
                else
                    return;
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SelectNextControl(Ctrl, true, true, true, true);
                }
                else
                    return;
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
                    Cmd.CommandText = "SELECT P_Data.ID, P_Data.P_Name, P_Data.Age, P_Data.Sex, P_Data.Card, P_Data.P_Date, P_Data.Ref, P_Report.Services, P_Report.Doctor " +
                                      $"FROM P_Data INNER JOIN P_Report ON P_Data.[ID] = P_Report.[ID] " +
                                      "WHERE P_Data.ID LIKE '%" + Search_Txt.Text + "%' OR P_Name LIKE'%" + Search_Txt.Text + "%' OR Card LIKE'%" + Search_Txt.Text + "%' OR Services LIKE'%" + Search_Txt.Text + "%' OR P_Report.Doctor LIKE'%" + Search_Txt.Text + "%' OR Sex LIKE'%" + Search_Txt.Text + "%'";

                    using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                    {
                        DataTable Dt = new DataTable();
                        Da.Fill(Dt);
                        P_DataBindSour.DataSource = Dt;
                        P_DataTabAd.Fill(datallyDataSet.P_Data);
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
            Cmd.CommandText = "SELECT P_Data.ID, P_Data.P_Name, P_Data.Age, P_Data.Sex, P_Data.Card, P_Data.Cash, P_Data.P_Date, P_Data.Ref, P_Report.Services, P_Report.Doctor " +
                              $"FROM P_Data INNER JOIN P_Report ON P_Data.[ID] = P_Report.[ID]";

            using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
            {
                DataTable Dt = new DataTable();
                Da.Fill(Dt);
                P_DataBindSour.DataSource = Dt;
                P_DataTabAd.Fill(datallyDataSet.P_Data);
            }
            Conn.Close();
        }

        private void Search_Txt_KeyPress(object sender, KeyPressEventArgs e)
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
                Cmd.CommandText = "SELECT P_Data.ID, P_Data.P_Name, P_Data.Age, P_Data.Sex, P_Data.Card, P_Data.Cash, P_Data.P_Date, P_Data.Ref, P_Report.Services, P_Report.Doctor " +
                                  $"FROM P_Data INNER JOIN P_Report ON P_Data.[ID] = P_Report.[ID] " +
                                  "WHERE P_Data.ID LIKE '%" + Search_Txt.Text + "%' OR P_Name LIKE'%" + Search_Txt.Text + "%' OR Card LIKE'%" + Search_Txt.Text + "%' OR Services LIKE'%" + Search_Txt.Text + "%' OR P_Report.Doctor LIKE'%" + Search_Txt.Text + "%' OR Sex LIKE'%" + Search_Txt.Text + "%'";

                using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                {
                    DataTable Dt = new DataTable();
                    Da.Fill(Dt);
                    P_DataBindSour.DataSource = Dt;
                    P_DataTabAd.Fill(datallyDataSet.P_Data);
                }
                Conn.Close();
            }
        }



        void Contract(string Value)
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
                Cmd.Connection = Conn;
                Cmd.CommandText = "SELECT NetPrice FROM T_Contract WHERE Name='" + Value + "'";
                Cmd.Parameters.AddWithValue("@0", Value);

                OleDbDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Cash_Txt.Text = Reader[0].ToString();
                }
                Cmd.Parameters.Clear();
                Reader.Close();
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Reception - 1008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
