using Datally.Properties;
using System;
using System.Windows.Forms;

namespace Datally
{
    public partial class Report : Form
    {
        string F, T, Doc;

        public Report() => InitializeComponent();

        private void Search_Load(object sender, EventArgs e)
        {
            From_Txt.Value = DateTime.Today;
            To_Txt.Value = DateTime.Today;
            DocTabAdap.Fill(DatallySet.Doctor);
        }

        private void Shutdown_Btn_Click(object sender, EventArgs e) => Close();

        private void Close_Click(object sender, EventArgs e) => Close();

        private void Print_Btn_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(Doc_Name.Text) && !string.IsNullOrEmpty(From_Txt.Text) && !string.IsNullOrEmpty(To_Txt.Text))
            {
                F = From_Txt.Text;
                T = To_Txt.Text;
                Doc = Doc_Name.Text;

                using (Datally.Print frm = new Datally.Print(F, T, Doc))

                {
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(Resources.E5, Resources.E1, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
