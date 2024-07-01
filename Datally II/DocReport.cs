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

    public class Regist
    {

        public string RegistrationKey { get; set; } 
        public bool RegStatus { get; set; }
        public DateTime Exp { get; set; }
        public string UserName { get; set; }
        public DateTime LicenceEnd { get; set; } 
    }
}
