using Datally.Properties;
using System;
using System.Windows.Forms;

namespace Datally
{
    public partial class AddUser : Form
    {

        public AddUser() => InitializeComponent();

        public Control Ctrl { get; set; }

        private void Search_Load(object sender, EventArgs e)
        {
            RolesTabAdap.Fill(DatallySet.T_Roles);
            UsersTabAdap.Fill(DatallySet.Users);
            Edit(true, false);
        }

        private void Shutdown_Btn_Click(object sender, EventArgs e) => Close();

        private void New_D_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false, true);
                DatallySet.Users.AddUsersRow(DatallySet.Users.NewUsersRow());
                UserBindSour.MoveLast();
                Name_Txt.Focus();
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
                    UsersTabAdap.Update(DatallySet.Users);
                    MessageBoxEx.Show(Resources.Save, Resources.Information, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                    Name_Txt.Focus();
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
                    UsersTabAdap.Update(DatallySet.Users);
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
    }
}
