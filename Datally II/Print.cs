using Datally.Properties;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Datally
{
    public partial class Print : Form
    {
        public string f, t, doc;
        public Print(string F, string T, string Doc)
        {
            f = F;
            t = T;
            doc = Doc;
            InitializeComponent();
        }

        public OleDbConnection Conn { get; set; } = new OleDbConnection(Resources.SVRDB);
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();

        private void Print_Load(object sender, EventArgs e)
        {
            Sal();
            ReportParameter[] p = new ReportParameter[]
            {
                new ReportParameter("A", f),
                new ReportParameter("B", t),
                new ReportParameter("C", doc),
                new ReportParameter("D", Login.Instance.UserName),
            };
            reportViewer1.LocalReport.SetParameters(p);
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.RefreshReport();
        }

        private void Sal()
        {
            try
            {
                {
                    if (Conn.State == ConnectionState.Closed)
                    {
                        Conn.Open();
                    }

                    Cmd.Connection = Conn;
                    Cmd.CommandText = "SELECT P_Data.ID,P_Data.P_Name,P_Data.P_Date,P_Report.Services,P_Report.Doctor,P_Data.Cash FROM P_Data INNER JOIN P_Report ON P_Data.ID = P_Report.ID " +
                                       $"WHERE P_Date BETWEEN '" + f + "' AND '" + t + "' AND P_Report.Doctor='" + doc + "'";

                    using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                    {
                        DataTable Dt = new DataTable();
                        Da.Fill(Dt);
                        DocReportBindingSource.DataSource = Dt;
                    }
                    Conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.E6 + ex, Resources.E1, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
