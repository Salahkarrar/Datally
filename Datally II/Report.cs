﻿using System;
using System.Windows.Forms;

namespace Datally
{
    public partial class Report_Frm : Form
    {
        string F, T, Doc;

        public Report_Frm() => InitializeComponent();

        private void Report_Load(object sender, EventArgs e)
        {
            try
            {
                From_Txt.Value = DateTime.Today;
                To_Txt.Value = DateTime.Today;
                DocTabAdap.Fill(DatallySet.Doctor);
                Login.Instance.CheckMain(Login.Instance.UserName);
                foreach (var obj in Login.Instance.List)
                {
                    if (Print_Btn.Name == obj.FunctionName)
                    {
                        Print_Btn.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Report - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Shutdown_Btn_Click(object sender, EventArgs e)
        {
            Close();
            Main main = new Main();
            main.Show();
        }

        private void Print_Btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Doc_Name.Text) && !string.IsNullOrEmpty(From_Txt.Text) && !string.IsNullOrEmpty(To_Txt.Text))
            {
                F = From_Txt.Text;
                T = To_Txt.Text;
                Doc = Doc_Name.Text;

                using (Print frm = new Print(F, T, Doc))

                {
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please check Your Data.", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
