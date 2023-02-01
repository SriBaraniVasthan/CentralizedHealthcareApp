using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HospitalAdministration
{
   public interface ILab
    {
        string AdminName { get; set; }
        string Comments { get; set; }
        string DoctorName { get; set; }
        int Flag { get; set; }
        string LabName { get; set; }
        int Rating { get; set; }
        DateTime RatingDate { get; set; }
        int RequestID { get; set; }
        string Status { get; set; }
        string TestName { get; set; }
        string TestResults { get; set; }
    }
}
