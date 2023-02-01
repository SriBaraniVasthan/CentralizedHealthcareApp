using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HospitalAdministration
{
    public interface ITest
    {
        string AdminName { get; set; }
        string DoctorName { get; set; }
        int RequestID { get; set; }
        string Status { get; set; }
        string TestName { get; set; }
    }
}
