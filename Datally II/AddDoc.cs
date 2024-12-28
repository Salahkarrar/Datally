using Datally.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Datally
{

    public partial class Radiologist_Frm : Form
    {
        public Radiologist_Frm() => InitializeComponent();

        public OleDbConnection Con { get; } = new OleDbConnection(Properties.Resources.SVRDB);
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        public Control Ctrl { get; set; }

        private void AddDoc_Load(object sender, EventArgs e)
        {
            try
            {
                DocTabAd.Fill(DatallySet.Doctor);

                // The PErmision of the Botton

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
                }
                Edit(true, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Radiologist - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Shutdown_Btn_Click(object sender, EventArgs e)
        {
            // Close the form and back to settings 
            Close();
            Main main = new Main();
            main.Show();
            main.Settings_Btn_Click(sender, e);
            main.Settings_Btn_Enter(sender, e);
        }

        private void New_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false, true);
                DatallySet.Doctor.AddDoctorRow(DatallySet.Doctor.NewDoctorRow());
                DocBindSour.MoveLast();
                Name_Txt.Focus();
                New_Btn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Make New Row." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Radiologis - 1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Name_Txt.Text) && !string.IsNullOrEmpty(Phone_Txt.Text))
            {
                Edit(true, false);

                try
                {
                    DocBindSour.EndEdit();
                    DocTabAd.Update(DatallySet.Doctor);
                    MessageBoxEx.Show(Resources.Save, Resources.Information, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                    Name_Txt.Focus();
                    New_Btn.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't Save Your Data, Please Recheck The Entery Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Radiologist - 1002", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBoxEx.Show("Please Check Your Data and Try Again", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
            }
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(ID_Txt.Text) && Edit_Btn.Text == "Edit")
                {
                    Edit(false, true);
                    New_Btn.Enabled = false;
                    Save_Btn.Enabled = false;

                    Login.Instance.Edit_Ico(Edit_Btn, "Update", Resources.ic_send_white_18dp);
                }
                else if (!string.IsNullOrEmpty(ID_Txt.Text) && Edit_Btn.Text == "Update")
                {
                    Edit(true, false);
                    New_Btn.Enabled = true;

                    Login.Instance.Edit_Ico(Edit_Btn, "Edit", Resources.ic_edit_white_18dp);
                    DocBindSour.EndEdit();
                    DocTabAd.Update(DatallySet.Doctor);
                    MessageBoxEx.Show("Data Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
                else
                {
                    Edit(true, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Update Your Data, Plese Check Your Data." + "\r\n" + "or Call System Administrator" + "\r\n" + ex.Message, "Error Radiologist - 1003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel_D_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Login.Instance.Edit_Ico(Edit_Btn, "Edit", Resources.ic_edit_white_18dp);
                New_Btn.Enabled = true;
                Edit(true, false);
                DocBindSour.CancelEdit();
                DocTabAd.Fill(DatallySet.Doctor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Cancel Your Data, Please Check Your Data." + "\r\n" + "or Call System Administrator" + "\r\n" + ex.Message, "Error Radiologist - 1004", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            dynamic dialog = MessageBox.Show("Are You Sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }

                    Cmd.Connection = Con;
                    Cmd.CommandText = "DELETE FROM Doctor WHERE ID=@0";
                    Cmd.Parameters.AddWithValue("@0", Doc_Grid.CurrentRow.Cells[0].Value);
                    Cmd.ExecuteNonQuery();
                    Cmd.Parameters.Clear();
                    Con.Close();
                    DocTabAd.Fill(DatallySet.Doctor);
                    DocBindSour.MoveLast();
                    MessageBoxEx.Show("Data Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Delete Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Radiologist - 1005", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Edit(bool Value, bool Value2)
        {
            Save_Btn.Enabled = Value2;
            Name_Txt.ReadOnly = Value;
            Phone_Txt.ReadOnly = Value;
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

    }
}
