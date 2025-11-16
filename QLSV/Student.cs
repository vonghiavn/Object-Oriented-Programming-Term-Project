using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace QuanLySinhVien
{
    [Serializable]
    public class Student : Person
    {
        public string StudentID { get; set; }
        public Department Department { get; set; }
        public string Position { get; set; }
        public string Status { get; set; }
        public DateTime EnrollDate { get; set; }
        public string EnrollID { get; set; }
        public Major Major { get; set; }
        public List<string> PaidCourseIDs { get; set; }
        public decimal PaidTuition { get; set; }

        public Student()
        {
            PaidCourseIDs = new List<string>();
            PaidTuition = 0;
        }

        public Student(
            string name, DateTime birthDay, string sex,
            string studentID, Department department, string position, string status,
            string address, string email, string phoneNumber,
            DateTime enrollDate, string enrollID, Major major)
            : base(name, birthDay, sex, address, email, phoneNumber)
        {
            StudentID = studentID;
            Department = department;
            Position = position;
            Status = status;
            EnrollDate = enrollDate;
            EnrollID = enrollID;
            Major = major;
            PaidCourseIDs = new List<string>();
            PaidTuition = 0;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            info.AddValue("StudentID", StudentID);
            info.AddValue("Department", Department);
            info.AddValue("Position", Position);
            info.AddValue("Status", Status);
            info.AddValue("EnrollDate", EnrollDate);
            info.AddValue("EnrollID", EnrollID);
            info.AddValue("Major", Major);
            info.AddValue("PaidTuition", PaidTuition);
            info.AddValue("PaidCourseIDs", PaidCourseIDs ?? new List<string>());
        }

        protected Student(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            StudentID = info.GetString("StudentID");
            Department = (Department)info.GetValue("Department", typeof(Department));
            Position = info.GetString("Position");
            Status = info.GetString("Status");
            EnrollDate = info.GetDateTime("EnrollDate");
            EnrollID = info.GetString("EnrollID");
            Major = (Major)info.GetValue("Major", typeof(Major));

            try
            {
                PaidTuition = info.GetDecimal("PaidTuition");
            }
            catch
            {
                PaidTuition = 0;
            }

            try
            {
                Object temp = info.GetValue("PaidCourseIDs", typeof(List<string>));
                PaidCourseIDs = temp as List<string> ?? new List<string>();
            }
            catch
            {
                PaidCourseIDs = new List<string>();
            }

            if (PaidCourseIDs == null)
            {
                PaidCourseIDs = new List<string>();
            }
        }
    }
}