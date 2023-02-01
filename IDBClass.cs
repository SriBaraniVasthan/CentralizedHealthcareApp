using System;
namespace HospitalAdministration
{
    public interface IDBClass
    {
        int AddlabResults(ILab obj);
        int AddRating(ILab obj);
        int AddRequest(ITest obj);
        int AddResultsDoctor(ILab obj);
        System.Collections.Generic.List<ITest> AdminProcessToLab();
        int CheckLogin1(string LoginName, string LoginPass);
        int CheckLogin2(string LoginName, string LoginPass);
        int CheckLogin3(string LoginName, string LoginPass);
        DateTime CheckRatingDate(string DocName, string LabName);
        System.Collections.Generic.List<ILab> LabDdl();
        int SendToLab(ILab objl);
        System.Collections.Generic.List<ITest> TestDdl();
        System.Collections.Generic.List<ILab> viewDoctorGrid(string DocName);
        System.Collections.Generic.List<ITest> viewLabfromAdmin(string labname);
        System.Collections.Generic.List<ILab> Viewlabresults();
        System.Collections.Generic.List<ILab> ViewRatingList(string DocName);
        System.Collections.Generic.List<ITest> ViewRequestHistory(string DocName);
    }
}
