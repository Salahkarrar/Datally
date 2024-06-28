using Datally.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Datally
{
    public partial class Users_Frm : Form
    {

        public Users_Frm() => InitializeComponent();

        public OleDbConnection Con { get; } = new OleDbConnection(Properties.Resources.SVRDB);
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        public Control Ctrl { get; set; }

        private void Search_Load(object sender, EventArgs e)
        {
            T_RolesTabAd.Fill(DatallySet.T_Roles);
            T_UsersTabAd.Fill(DatallySet.T_Users);
            Edit(true, false);
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
        }

        private void Shutdown_Btn_Click(object sender, EventArgs e)
        {
            Close();
            Main main = new Main();
            main.Show();
            main.Settings_Btn_Click(sender, e);
            main.Settings_Btn_Enter(sender, e);
        }

        private void New_D_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false, true);
                DatallySet.T_Users.AddT_UsersRow(DatallySet.T_Users.NewT_UsersRow());
                UserBindSour.MoveLast();
                Name_Txt.Focus();
                New_Btn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_D_Btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Name_Txt.Text) && !string.IsNullOrEmpty(Phone_Txt.Text) && !string.IsNullOrEmpty(Pass_Txt.Text) &&
                !string.IsNullOrEmpty(Auth_Txt.Text))
            {
                Edit(true, false);

                try
                {
                    UserBindSour.EndEdit();
                    T_UsersTabAd.Update(DatallySet.T_Users);
                    T_UsersTabAd.Fill(DatallySet.T_Users);
                    UserBindSour.MoveLast();
                    MessageBoxEx.Show(Resources.Save, Resources.Information, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                    Name_Txt.Focus();
                    New_Btn.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Resources.E11 + "\r\n" + ex.Message, Resources.E1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                if (!string.IsNullOrEmpty(User_Grid.CurrentRow.Cells[0].Value.ToString()) && Edit_Btn.Text == "Edit")
                {
                    Edit(false, true);
                    New_Btn.Enabled = false;
                    Save_Btn.Enabled = false;

                    Login.Instance.Edit_Ico(Edit_Btn, "Update", Resources.ic_send_white_18dp);

                }
                else if (!string.IsNullOrEmpty(User_Grid.CurrentRow.Cells[0].Value.ToString()) && Edit_Btn.Text == "Update")
                {
                    Edit(true, false);
                    New_Btn.Enabled = true;

                    Login.Instance.Edit_Ico(Edit_Btn, "Edit", Resources.ic_edit_white_18dp);
                    UserBindSour.EndEdit();
                    T_UsersTabAd.Update(DatallySet.T_Users);
                    MessageBoxEx.Show(Resources.Update, Resources.Information, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
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

        private void Cancel_D_Btn_Click(object sender, EventArgs e)
        {
            Login.Instance.Edit_Ico(Edit_Btn, "Edit", Resources.ic_edit_white_18dp);
            Edit(true, false);
            UserBindSour.CancelEdit();
            T_UsersTabAd.Fill(DatallySet.T_Users);
            New_Btn.Enabled = true;

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
                    Cmd.CommandText = "DELETE FROM T_Users WHERE ID=@0";
                    Cmd.Parameters.AddWithValue("@0", User_Grid.CurrentRow.Cells[0].Value);
                    Cmd.ExecuteNonQuery();
                    Cmd.Parameters.Clear();
                    Con.Close();
                    T_UsersTabAd.Fill(DatallySet.T_Users);
                    UserBindSour.MoveLast();
                    MessageBoxEx.Show("Data Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Delete Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Users - 1005", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Edit(bool Value, bool Value2)
        {
            Save_Btn.Enabled = Value2;
            Name_Txt.ReadOnly = Value;
            Pass_Txt.ReadOnly = Value;
            Phone_Txt.ReadOnly = Value;
            Auth_Txt.Enabled = Value2;
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

        private void User_Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void User_Grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow dr in User_Grid.Rows)
            {
                if (dr.Cells[0].Value.ToString() == "2")
                {
                    dr.Visible = false;
                }
            }
        }

    }
}
