using Datally.Properties;
using System;
using System.Windows.Forms;

namespace Datally
{
    public partial class AddDoc : Form
    {
        public AddDoc() => InitializeComponent();

        private void AddDoc_Load(object sender, EventArgs e)
        {
            Edit(true, false);
            DocTableAdapter.Fill(DatallySet.Doctor);
        }

        private void Shutdown_Btn_Click(object sender, EventArgs e) => Close();

        private void New_D_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false, true);
                DatallySet.Doctor.AddDoctorRow(DatallySet.Doctor.NewDoctorRow());
                DocBindSour.MoveLast();
                Name_Txt.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.E11 + "\r\n" + ex.Message, Resources.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_D_Btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Name_Txt.Text) && !string.IsNullOrEmpty(Phone_Txt.Text))
            {
                Edit(true, false);

                try
                {
                    DocBindSour.EndEdit();
                    DocTableAdapter.Update(DatallySet.Doctor);
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
                    DocTableAdapter.Update(DatallySet.Doctor);
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
            DocBindSour.CancelEdit();
        }

        private void Edit(bool Value, bool Value2)
        {
            Save_Btn.Enabled = Value2;
            Name_Txt.ReadOnly = Value;
            Phone_Txt.ReadOnly = Value;
        }
    }
}
