using System;

namespace Datally
{
    public class DocReport
    {
        public int ID { get; set; }
        public string P_Name { get; set; }
        public string Services { get; set; }
        public DateTime P_Date { get; set; }
        public string Cash { get; set; }
    }

    public class PROAuth
    {
        public string FunctionName { get; set; }
        public string RoleName { get; set; }
        public string FormName { get; set; }
        public int FunctionID { get; set; }
        public int RoleID { get; set; }
    }
}
