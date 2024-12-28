using Dapper;
using Datally.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace Datally
{
    public partial class Registration : Form
    {

        public Registration() => InitializeComponent();
        public OleDbConnection Conn { get; } = new OleDbConnection(Resources.SVRDB);
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        public Control Ctrl { get; set; }
        public string DeviceID { get; set; }
        public string DeviceName { get; set; }
        public string DeviceBios { get; set; }
        public string UserName { get; set; }
        public bool RegStatus { get; set; }
        public DateTime Exp { get; set; }
        public int AppRun { get; set; }
        public List<Regist> List { get; set; }

        private void Registration_Load(object sender, EventArgs e)
        {
            GetSer();
            AddDevice();
            //InsertRegKey(); IF The License End;
            Check();

        }

        private void Confirm_Btn_Click(object sender, EventArgs e)
        {
            NewRegistration();
            Check();
        }

        private void Shutdown_Btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void GetSer()
        {
            try
            {
                DeviceName = Environment.MachineName.ToString(); ;
                UserName = Environment.UserName.ToString();

                ManagementObjectSearcher MOS = new ManagementObjectSearcher("Select * FROM Win32_BaseBoard");
                foreach (ManagementObject getserial in MOS.Get().Cast<ManagementObject>())
                {
                    DeviceID = getserial["SerialNumber"].ToString();
                }
                ManagementObjectSearcher MOS1 = new ManagementObjectSearcher("Select * FROM WIN32_BIOS");
                foreach (ManagementObject management in MOS1.Get().Cast<ManagementObject>())
                {
                    DeviceBios = management["SerialNumber"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Identify your Device." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Registration - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Check()
        {
            try
            {
                object EX, End = null;
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                OleDbCommand Cmd = new OleDbCommand("SELECT * FROM T_Devices WHERE DeviceID=@0", Conn);
                Cmd.Parameters.AddWithValue("@0", DeviceID);

                OleDbDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    RegStatus = (bool)Reader["RegStatus"];
                    EX = Reader["Exp"];
                    End = Reader["LicenceEnd"];
                }
                Cmd.Parameters.Clear();
                Reader.Close();
                if (RegStatus == true && DateTime.Now < Convert.ToDateTime(End))
                {
                    Hide();
                    using (Login D = new Login())
                    {
                        D.ShowDialog();
                    }
                }
                else if (RegStatus == true && DateTime.Now > Convert.ToDateTime(End))
                {
                    MessageBox.Show("Heads up! Your Radiologix license is Expire." + "\r\n" + "Activate it to keep using all features.", "license", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Get Your Registration Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Registration - 1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void NewRegistration()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                {
                    List = Conn.Query<Regist>("SELECT * FROM T_Registration", commandType: CommandType.Text).ToList();
                    Conn.Close();
                }

                foreach (var obj in List.ToList())
                {
                    if (Registration_Txt.Text == obj.RegistrationKey && DateTime.Now < obj.Exp && obj.RegStatus == false)
                    {
                        RegistDevice(obj.LicenceEnd, obj.Exp);
                        UpdateReg(obj.RegistrationKey);
                        MessageBoxEx.Show("Thank You For Registration The Application.", Resources.Information, MessageBoxButtons.OK, MessageBoxIcon.Information, 1200);
                    }
                    else if (Registration_Txt.Text == obj.RegistrationKey && DateTime.Now > obj.Exp)
                    {
                        MessageBox.Show("The Registration Key is Invalid" + "\r\n" + "Please Enter Valid Key", "Registration Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Registration_Txt.Clear();
                    }
                    else if (Registration_Txt.Text == obj.RegistrationKey && DateTime.Now < obj.Exp && obj.RegStatus == true)
                    {
                        MessageBox.Show("The Registration Key is Used By : '"+obj.UserName+"'" + "\r\n" + "Please Enter Valid Key", "Registration Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Registration_Txt.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Get Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Registration - 1002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void AddDevice()
        {
            string DeID = null;

            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                OleDbCommand Cmd = new OleDbCommand("SELECT * FROM T_Devices WHERE DeviceID=@0", Conn);
                Cmd.Parameters.AddWithValue("@0", DeviceID);

                OleDbDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    DeID = Reader["DeviceID"].ToString();
                }
                Cmd.Parameters.Clear();
                Reader.Close();

                if (DeID == null)
                {
                    if (Conn.State == ConnectionState.Closed)
                    {
                        Conn.Open();
                    }

                    Cmd.Connection = Conn;
                    Cmd.CommandText = "INSERT INTO T_Devices (DeviceID,UserName) VALUES ('" + DeviceID + "','" + UserName + "')";
                    Cmd.ExecuteNonQuery();
                    Cmd.Parameters.Clear();
                    Conn.Close();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Add Your Device." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Registration - 1003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void RegistDevice(object Value, object Value1)
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                Cmd.Connection = Conn;
                Cmd.CommandText = "UPDATE T_Devices SET RegStatus=true,Exp='" + Convert.ToDateTime(Value1) + "', LicenceEnd='" + Convert.ToDateTime(Value) + "' WHERE DeviceID=@0";
                Cmd.Parameters.AddWithValue("@0", DeviceID);
                Cmd.ExecuteNonQuery();
                Cmd.Parameters.Clear();
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Confirm Device Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Registration - 1004", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void UpdateReg(object Value)
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                Cmd.Connection = Conn;
                Cmd.CommandText = "UPDATE T_Registration SET UserName='" + UserName + "',RegStatus=true WHERE RegistrationKey='" + Value.ToString() + "'";
                Cmd.ExecuteNonQuery();
                Cmd.Parameters.Clear();
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Confirm Registration Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Registration - 1005", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

#pragma warning disable IDE0051 // Remove unused private members
        void InsertRegKey()
#pragma warning restore IDE0051 // Remove unused private members
        {
            string RegKey = "";
            string RegCh = null;
            DateTime ExpDate = Convert.ToDateTime("");
            DateTime LiEnd = Convert.ToDateTime("");


            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                OleDbCommand Cmd = new OleDbCommand("SELECT * FROM T_Registration WHERE RegistrationKey=@0", Conn);
                Cmd.Parameters.AddWithValue("@0", RegKey);

                OleDbDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    RegCh = Reader["RegistrationKey"].ToString();
                }
                Cmd.Parameters.Clear();
                Reader.Close();

                if (RegCh == null)
                {
                    if (Conn.State == ConnectionState.Closed)
                    {
                        Conn.Open();
                    }

                    Cmd.Connection = Conn;
                    Cmd.CommandText = "INSERT INTO T_Registration (RegistrationKey,Exp,LicenceEnd) VALUES ('" + RegKey + "','" + ExpDate + "','" + LiEnd + "')";
                    Cmd.ExecuteNonQuery();
                    Cmd.Parameters.Clear();
                    Conn.Close();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Inster New Registration Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Registration - 1006", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
