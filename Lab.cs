using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalAdministration
{
    public class Lab : HospitalAdministration.ILab 
    {
        string labName;

        public string LabName
        {
            get { return labName; }
            set { labName = value; }
        }
        string testName;

        public string TestName
        {
            get { return testName; }
            set { testName = value; }
        }

        string adminName;

        public string AdminName
        {
            get { return adminName; }
            set { adminName = value; }
        }

        string testResults;

        public string TestResults
        {
            get { return testResults; }
            set { testResults = value; }
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

        int rating;

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        string comments;

        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }
        string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        DateTime ratingDate;

        public DateTime RatingDate
        {
            get { return ratingDate; }
            set { ratingDate = value; }
        }
        int flag;

        public int Flag
        {
            get { return flag; }
            set { flag = value; }
        }
    }
}