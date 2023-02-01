using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

 namespace HospitalAdministration
{
    public class Test : HospitalAdministration.ITest 
    {

        string testName;

        public string TestName
        {
            get { return testName; }
            set { testName = value; }
        }
        string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        string adminName;

        public string AdminName
        {
            get { return adminName; }
            set { adminName = value; }
        }
        string doctorName;

        public string DoctorName
        {
            get { return doctorName; }
            set { doctorName = value; }
        }

        int requestID;

        public int RequestID
        {
            get { return requestID; }
            set { requestID = value; }
        }

    }
}