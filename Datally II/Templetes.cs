﻿using Datally.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace Datally
{
    public partial class Templetes_Frm : Form
    {
        public Templetes_Frm()
        {
            InitializeComponent();
        }

        public OleDbConnection Conn { get; set; } = new OleDbConnection(Resources.SVRDB);
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        public BindingSource Value { get; set; }
        public Control Ctrl;
        public string Path { get; set; } = Application.StartupPath + "\\";


        private void Shutdown_Btn_Click(object sender, EventArgs e)
        {
            Close();
            Main main = new Main();
            main.Show();
        }

        private void Templates_Load(object sender, EventArgs e)
        {
            try
            {
                Templete_Grid.DataSource = MriBindSour;
                MinimizeBox = true;
                Services();
                Services_Label.Text = "MRI";
                Login.Instance.CheckMain(Login.Instance.UserName);
                foreach (var obj in Login.Instance.List)
                {
                    if (Delete_Btn.Name == obj.FunctionName)
                    {
                        Delete_Btn.Enabled = true;
                    }
                    else if (New_Btn.Name == obj.FunctionName)
                    {
                        New_Btn.Enabled = true;
                    }
                    else if (Save_Btn.Name == obj.FunctionName)
                    {
                        Save_Btn.Enabled = true;
                    }
                    else if (Edit_Btn.Name == obj.FunctionName)
                    {
                        Edit_Btn.Enabled = true;
                    }
                    else if (Cancel_Btn.Name == obj.FunctionName)
                    {
                        Cancel_Btn.Enabled = true;
                    }
                    else if (Templete_Btn.Name == obj.FunctionName)
                    {
                        Templete_Btn.Enabled = true;
                    }
                }
                Edit(true,false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Templates - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void New_Btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Want to Add New Templete", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {

                    if (Templete_Grid.DataSource == MriBindSour)
                    {
                        Edit(false,true);
                        DatallySet.MRI.AddMRIRow(DatallySet.MRI.NewMRIRow());
                        MriBindSour.MoveLast();
                        Name_Txt.Focus();
                    }
                    else if (Templete_Grid.DataSource == CTBindSour)
                    {
                        Edit(false, true);
                        DatallySet.CT.AddCTRow(DatallySet.CT.NewCTRow());
                        CTBindSour.MoveLast();
                        Name_Txt.Focus();
                    }
                    else if (Templete_Grid.DataSource == USBindSour)
                    {
                        Edit(false, true);
                        DatallySet.US.AddUSRow(DatallySet.US.NewUSRow());
                        USBindSour.MoveLast();
                        Name_Txt.Focus();
                    }
                    else if (Templete_Grid.DataSource == XrayBindSour)
                    {
                        Edit(false, true);
                        DatallySet.X_RAY.AddX_RAYRow(DatallySet.X_RAY.NewX_RAYRow());
                        XrayBindSour.MoveLast();
                        Name_Txt.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Make New Row." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Templates - 1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialog == DialogResult.No)
            {
                DialogResult.Cancel.Equals(true);
            }
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Tittle_Txt.Text) && !string.IsNullOrEmpty(Report_Txt.Text)
                    && !string.IsNullOrEmpty(Name_Txt.Text))
                {
                    if (Edit_Btn.Text == "Edit")
                    {
                        Edit(false, false);
                        New_Btn.Enabled = false;
                        Save_Btn.Enabled = false;

                        Login.Instance.Edit_Ico(Edit_Btn, "Update", Resources.ic_send_white_18dp);
                    }
                    else if (Edit_Btn.Text == "Update")
                    {
                        Edit(true, false);
                        New_Btn.Enabled = true;

                        Login.Instance.Edit_Ico(Edit_Btn, "Edit", Resources.ic_edit_white_18dp);
                        try
                        {
                            if (Templete_Grid.DataSource == MriBindSour)
                            {
                                Edit(true,false);
                                MriBindSour.EndEdit();
                                MriTableAdapter.Update(DatallySet.MRI);
                            }
                            else if (Templete_Grid.DataSource == CTBindSour)
                            {
                                Edit(true, false);
                                CTBindSour.EndEdit();
                                CtTableAdapter.Update(DatallySet.CT);
                            }
                            else if (Templete_Grid.DataSource == XrayBindSour)
                            {
                                Edit(true,false);
                                XrayBindSour.EndEdit();
                                x_RAYTableAdapter.Update(DatallySet.X_RAY);
                            }
                            else if (Templete_Grid.DataSource == USBindSour)
                            {
                                Edit(true,false);
                                USBindSour.EndEdit();
                                USTableAdapter.Update(DatallySet.US);
                            }
                            MessageBoxEx.Show("Data Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Can't Update Your Data, Please Recheck The Entery Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Templates - 1002", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Conn.Close();
                    }
                }
                else
                {
                    Edit(true, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Update Your Data, Please Recheck The Entery Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Templates - 1002-1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true, false);
                Login.Instance.Edit_Ico(Edit_Btn, "Edit", Resources.ic_edit_white_18dp);
                MriBindSour.CancelEdit();
                CTBindSour.CancelEdit();
                XrayBindSour.CancelEdit();
                USBindSour.CancelEdit();
                MriTableAdapter.Fill(DatallySet.MRI);
                CtTableAdapter.Fill(DatallySet.CT);
                x_RAYTableAdapter.Fill(DatallySet.X_RAY);
                USTableAdapter.Fill(DatallySet.US);
                New_Btn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Cancel Your Data, Please Check Your Data." + "\r\n" + "or Call System Administrator" + "\r\n" + ex.Message, "Error Tamplates - 1003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Templete_Grid.DataSource == MriBindSour)
                {
                    Edit(true,false);
                    MriBindSour.EndEdit();
                    MriTableAdapter.Update(DatallySet.MRI);
                    Name_Txt.Focus();
                }
                else if (Templete_Grid.DataSource == CTBindSour)
                {
                    Edit(true,false);
                    CTBindSour.EndEdit();
                    CtTableAdapter.Update(DatallySet.CT);
                    Name_Txt.Focus();
                }
                else if (Templete_Grid.DataSource == XrayBindSour)
                {
                    Edit(true, false);
                    XrayBindSour.EndEdit();
                    x_RAYTableAdapter.Update(DatallySet.X_RAY);
                    Name_Txt.Focus();
                }
                else if (Templete_Grid.DataSource == USBindSour)
                {
                    Edit(true, false);
                    USBindSour.EndEdit();
                    USTableAdapter.Update(DatallySet.US);
                    Name_Txt.Focus();
                }
                MessageBoxEx.Show("Data Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Save Your Data, Please Recheck The Entery Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Tamplates - 1004", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Templete();
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            dynamic dialog = MessageBox.Show(Resources.Confirm, Resources.Delete, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(Templete_Grid.CurrentCell.Value.ToString()) && dialog == DialogResult.Yes)
            {
                try
                {
                    string destFileName = "" + Path + "Templete\\" + Services_Label.Text + "\\" + Name_Txt.Text + ".docx";
                    File.Delete(destFileName);
                    if (Templete_Grid.DataSource == MriBindSour)
                    {
                        MriBindSour.RemoveCurrent();
                        MriTableAdapter.Update(DatallySet.MRI);
                        Templete_Grid.Refresh();
                        MessageBoxEx.Show(Resources.Delete, Resources.Information, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                    }
                    else if (Templete_Grid.DataSource == CTBindSour)
                    {
                        CTBindSour.RemoveCurrent();
                        CtTableAdapter.Update(DatallySet.CT);
                        Templete_Grid.Refresh();
                        MessageBoxEx.Show(Resources.Delete, Resources.Information, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                    }
                    else if (Templete_Grid.DataSource == XrayBindSour)
                    {
                        XrayBindSour.RemoveCurrent();
                        x_RAYTableAdapter.Update(DatallySet.X_RAY);
                        Templete_Grid.Refresh();
                        MessageBoxEx.Show(Resources.Delete, Resources.Information, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                    }
                    else if (Templete_Grid.DataSource == USBindSour)
                    {
                        USBindSour.RemoveCurrent();
                        USTableAdapter.Update(DatallySet.US);
                        Templete_Grid.Refresh();
                        MessageBoxEx.Show(Resources.Delete, Resources.Information, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Delete Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Tamplates - 1005", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult.Cancel.Equals(true);
            }
        }

        private void Templete_Click(object sender, EventArgs e) => Templete();

        private void Category_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = Category_Grid.Rows[e.RowIndex];

                BindingSource M = MriBindSour;
                BindingSource C = CTBindSour;
                BindingSource X = XrayBindSour;
                BindingSource U = USBindSour;

                Services_Label.Text = row.Cells[e.ColumnIndex].Value.ToString();
                if (!string.IsNullOrEmpty(row.Cells[e.ColumnIndex].Value.ToString()))
                {
                    if (row.Cells[e.ColumnIndex].Value.ToString() == "MRI")
                    {
                        Value = M;
                        MriTableAdapter.Fill(DatallySet.MRI);
                        goto V;
                    }
                    else if (row.Cells[e.ColumnIndex].Value.ToString() == "CT")
                    {
                        Value = C;
                        CtTableAdapter.Fill(DatallySet.CT);
                        goto V;
                    }
                    else if (row.Cells[e.ColumnIndex].Value.ToString() == "X_RAY")
                    {
                        Value = X;
                        x_RAYTableAdapter.Fill(DatallySet.X_RAY);
                        goto V;
                    }
                    else if (row.Cells[e.ColumnIndex].Value.ToString() == "US")
                    {
                        Value = U;
                        USTableAdapter.Fill(DatallySet.US);
                        goto V;
                    }
                V:
                    Templete_Grid.DataSource = Value;
                    Clear_Text();
                    Name_Txt.DataBindings.Add("Text", Value, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
                    Tittle_Txt.DataBindings.Add("Text", Value, "Tittle", false, DataSourceUpdateMode.OnPropertyChanged);
                    Report_Txt.DataBindings.Add("Text", Value, "Report", false, DataSourceUpdateMode.OnPropertyChanged);
                }
                else
                {
                    Name_Txt.Clear();
                    Tittle_Txt.Clear();
                    Report_Txt.Clear();
                    Templete_Grid.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Templates - 1006", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Templete_Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => Templete();

        //F
        private void Edit(bool value, bool value2)
        {
            Name_Txt.ReadOnly = value;
            Tittle_Txt.ReadOnly = value;
            Report_Txt.ReadOnly = value;
            Save_Btn.Enabled = value2;
        }

        private string[] ReadData()
        {
            string[] data = new string[6];
            data[0] = Tittle_Txt.Text;
            data[1] = Report_Txt.Text;
            return data;
        }

        public void Templete()
        {
            try
            {
                if (!string.IsNullOrEmpty(Services_Label.Text) && !string.IsNullOrEmpty(Name_Txt.Text))
                {
                    Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                    Microsoft.Office.Interop.Word.Document doc;

                    object missing = Type.Missing;
                    string FilePath = "" + Path + "Templete\\" + Services_Label.Text + "\\" + Name_Txt.Text + ".docx";
                    for (int i = 0; i <= 1; i++)
                    {
                        if (File.Exists(FilePath))
                        {
                            doc = app.Documents.Open(FilePath);
                            app.Visible = true;
                        }
                        else
                        {
                            string soruceFileName = "" + Path + "Templete\\Templete.docx";
                            string destFileName = "" + Path + "Templete\\" + Services_Label.Text + "\\" + Name_Txt.Text + ".docx";
                            File.Copy(soruceFileName, destFileName);
                            doc = app.Documents.Open(destFileName);
                            Microsoft.Office.Interop.Word.Table table = doc.Tables[2];
                            table.Range.Text = Report_Txt.Text;
                            app.Visible = true;
                        }

                        string[] tmp = new string[2];
                        tmp = ReadData();

                        app.Selection.Find.Execute("<Tittle>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[0], 2);
                        doc.Save();
                    }
                }
                else
                {
                    MessageBoxEx.Show(Resources.Make, Resources.E1, 700);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Save Your Template in Microsof Word File." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Templates - 1007", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear_Text()
        {
            Name_Txt.DataBindings.Clear();
            Tittle_Txt.DataBindings.Clear();
            Report_Txt.DataBindings.Clear();
        }

        private void Delete_Btn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.Shift)
                {
                    if (e.KeyCode == Keys.Delete)
                    {
                        Delete_Btn_Click(sender, e);
                    }
                }
            }
        }

        private void Category_Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                if (e.KeyCode == Keys.N)
                {
                    New_Btn_Click(sender, e);
                }
                else if (e.KeyCode == Keys.S)
                {
                    Save_Btn_Click(sender, e);
                }
                else if (e.KeyCode == Keys.T)
                {
                    Templete_Click(sender, e);
                }
                else if (e.KeyCode == Keys.Insert)
                {
                    Edit_Btn_Click(sender, e);
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    Cancel_Btn_Click(sender, e);
                }
            }
        }

        private void Templete_Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N)
            {
                New_Btn_Click(sender, e);
            }
            else if (e.KeyCode == Keys.T)
            {
                Templete_Click(sender, e);
            }
            else if (e.KeyCode == Keys.E)
            {
                Edit_Btn_Click(sender, e);
            }
            if (e.Shift)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    Delete_Btn_Click(sender, e);
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Cancel_Btn_Click(sender, e);
            }
        }

        private void Tittle_Txt_KeyDown(object sender, KeyEventArgs e)
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
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SelectNextControl(Ctrl, true, true, true, true);
                }
                else
                    return;
            }
            if (e.Control == true)
            {
                if (e.KeyCode == Keys.S)
                {
                    Save_Btn_Click(sender, e);
                }
                else if (e.KeyCode == Keys.Insert)
                {
                    Edit_Btn_Click(sender, e);
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Cancel_Btn_Click(sender, e);
            }
        }

        public void Services()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                Cmd.Connection = Conn;
                Cmd.CommandText = "Select S_Name from Services";

                using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                {
                    DataTable Dt = new DataTable();
                    Da.Fill(Dt);
                    Category_Grid.DataSource = Dt;
                }
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Templates - 1008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
