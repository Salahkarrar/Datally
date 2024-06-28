using Datally.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Datally
{
    public partial class Contract_Frm : Form
    {
        public Contract_Frm()
        {
            InitializeComponent();
        }

        public OleDbConnection Con { get; } = new OleDbConnection(Properties.Resources.SVRDB);
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        public Control Ctrl;
        public object ID { get; set; }

        protected internal void Contract_Load(object sender, EventArgs e)
        {
            try
            {
                Dock = DockStyle.Fill;
                Enabled = true;
                Edit(true, false);
                T_ContractTabAd.Fill(DatallySet.T_Contract);
                T_ContractBindSour.MoveLast();
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
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Contract - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void New_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false, true);
                DatallySet.T_Contract.AddT_ContractRow(DatallySet.T_Contract.NewT_ContractRow());
                T_ContractBindSour.MoveLast();
                Name_Txt.Focus();
                New_Btn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Make New Row." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Contract - 1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Name_Txt.Text) && !string.IsNullOrEmpty(Discount_Txt.Text) && !string.IsNullOrEmpty(Amount_Txt.Text) && Amount_Txt.TextLength >= 4 &&
                    !string.IsNullOrEmpty(Net_Txt.Text))
                {
                    Edit(true, false);
                    T_ContractTabAd.Insert(Name_Txt.Text, Convert.ToInt32(Amount_Txt.Text), Convert.ToInt16(Discount_Txt.Text), Convert.ToInt32(Net_Txt.Text));
                    MessageBoxEx.Show("Data Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                    T_ContractTabAd.Fill(DatallySet.T_Contract);
                    T_ContractBindSour.MoveLast();
                    New_Btn.Enabled = true;
                }
                else
                {
                    MessageBoxEx.Show("Please Check Your Data and Try Again" + "\r\n" + "Choose Strong Password", "Hand Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Name,Password and Phone Can't Duplicated, Please Recheck The Entery Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Contract - 1002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Edit_Btn.Text == "Edit")
                {
                    Edit(false, true);
                    New_Btn.Enabled = false;
                    Save_Btn.Enabled = false;
                    Login.Instance.Edit_Ico(Edit_Btn, "Update", Resources.ic_send_white_18dp);
                }
                else if (Edit_Btn.Text == "Update")
                {
                    Edit(true, false);
                    New_Btn.Enabled = true;
                    Login.Instance.Edit_Ico(Edit_Btn, "Edit", Resources.ic_edit_white_18dp);
                    T_ContractBindSour.EndEdit();
                    T_ContractTabAd.Update(DatallySet.T_Contract);
                    MessageBoxEx.Show("Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
                else
                {
                    Edit(true, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Update Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Contract - 1003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Login.Instance.Edit_Ico(Edit_Btn, "Edit", Resources.ic_edit_white_18dp);
                Edit(true, false);
                New_Btn.Enabled = true;
                T_ContractBindSour.CancelEdit();
                T_ContractTabAd.Fill(DatallySet.T_Contract);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Cancel Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Contract - 1004", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Cmd.CommandText = "DELETE FROM T_Contract WHERE ID=@0";
                    Cmd.Parameters.AddWithValue("@0", User_Grid.CurrentRow.Cells[0].Value);
                    Cmd.ExecuteNonQuery();
                    Cmd.Parameters.Clear();
                    Con.Close();
                    T_ContractTabAd.Fill(DatallySet.T_Contract);
                    T_ContractBindSour.MoveLast();
                    MessageBoxEx.Show("Data Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Delete Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Contract - 1005", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsNumber(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        // Function //

        private void Edit(bool Value, bool Value2)
        {
            Save_Btn.Enabled = Value2;
            Name_Txt.ReadOnly = Value;
            Amount_Txt.ReadOnly = Value;
            Discount_Txt.ReadOnly = Value;
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            Close();
            Main main = new Main();
            main.Show();
            main.Settings_Btn_Click(sender, e);
            main.Settings_Btn_Enter(sender, e);
        }

        private void ProID_Txt_KeyDown(object sender, KeyEventArgs e)
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
        }

        private void Discount_Txt_Leave(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(Amount_Txt.Text);
                double y = Convert.ToDouble(Discount_Txt.Text);
                double sum = x - (x * y) / 100;
                Net_Txt.Text = sum.ToString();
            }
            catch
            {
                MessageBox.Show("Please Recheck Your Entery Data." + "\r\n" + "User Error" + "\r\n", "Error Contract - 1006", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
