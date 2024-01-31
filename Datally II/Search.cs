using Datally.Properties;
using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace Datally
{
    public partial class Search : Form
    {
        public Search() => InitializeComponent();

        private void Search_Load(object sender, EventArgs e) => Fill();

        //public OleDbConnection Conn { get; set; } = new OleDbConnection(ConfigurationManager.ConnectionStrings["Datally.Properties.Settings.DatallyConn"].ConnectionString);
        public OleDbConnection Conn { get; set; } = new OleDbConnection(Resources.SVRDB);
        //public OleDbConnection Conn { get; set; } = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Datally\\DataBase\\Datally.accdb;Jet OLEDB:Database Password=Datally@2020$;");
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        public string Path { get; set; } = Resources.SVR;
        //public string Path { get; set; } = Resources.D;

        private void Shutdown_Btn_Click(object sender, EventArgs e) => Close();

        public void Fill()
        {
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }

            Cmd.Connection = Conn;
            Cmd.CommandText = "SELECT P_Data.ID, P_Data.P_Name, P_Data.Age, P_Data.Sex, P_Data.Card, P_Data.P_Date, P_Data.Ref, P_Report.Services, P_Report.Doctor " +
                              $"FROM P_Data INNER JOIN P_Report ON P_Data.[ID] = P_Report.[ID]";

            using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
            {
                DataTable Dt = new DataTable();
                Da.Fill(Dt);
                Search_Grid.DataSource = Dt;
                Search_Grid.Columns[0].Width = 60;
                Search_Grid.Columns[1].Width = 250;
                Search_Grid.Columns[2].Width = 60;
                Search_Grid.Columns[3].Width = 60;
                Search_Grid.Columns[4].Width = 60;
                Search_Grid.Columns[5].Width = 110;
                Search_Grid.Columns[6].Width = 160;
                Search_Grid.Columns[7].Width = 300;
                Search_Grid.Columns[8].Width = 180;
            }
            Conn.Close();
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
                        Search_Grid.DataSource = Dt;
                    }
                    Conn.Close();
                }
            }
        }

        private void Search_Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = Search_Grid.Rows[e.RowIndex];
            if (!string.IsNullOrEmpty(row.Cells[0].Value.ToString()))
            {
                string FilePath = Path + "P_Report\\" + row.Cells[0].Value + "_" + row.Cells[1].Value + "_" + row.Cells[7].Value + ".docx";
                P_Report(FilePath);
            }
            else
            {
                MessageBoxEx.Show(Resources.Make,Resources.Information, 700);
            }
        }

        private void P_Report(string Value)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document Doc = null;
            object Missing = Type.Missing;

            if (File.Exists(Value))
            {
                Doc = app.Documents.Open(Value);
                app.Selection.Find.ClearFormatting();
                app.Selection.Find.Replacement.ClearFormatting();
                app.Visible = true;
            }
            else
            {
                MessageBoxEx.Show(Resources.NotExist, Resources.Information, 1000);
            }
        }

    }
}
