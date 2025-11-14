using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace QuanLySinhVien
{
    [Serializable]
    public class Major : ISerializable
    {
        public string MajorID { get; set; }
        public string MajorName { get; set; }
        public Department Department { get; set; }
        public List<Course> Courses { get; set; }
        public int TotalCourse
        {
            get { return Courses != null ? Courses.Count : 0; }
        }
        public int TotalCredits
        {
            get { return GetTotalCredits(); }
        }

        public Major()
        {
            Courses = new List<Course>();
        }

        // ✅ Thêm constructor có 4 tham số để form Add ngành dùng
        public Major(string majorID, string majorName, Department department)
        {
            MajorID = majorID;
            MajorName = majorName;
            Department = department;
            Courses = new List<Course>();
            // totalCredits không dùng trực tiếp, vì được tính động
        }

        // Tính tổng tín chỉ ngành
        public int GetTotalCredits()
        {
            int total = 0;
            foreach (Course c in Courses)
            {
                if (c.CreditInfo != null)
                    total += c.CreditInfo.Value;
            }
            return total;
        }

        // Tính tổng học phí ngành
        public decimal GetTotalFee()
        {
            decimal total = 0;
            foreach (Course c in Courses)
            {
                total += c.GetCourseFee();
            }
            return total;
        }

        // Serialization
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("MajorID", MajorID);
            info.AddValue("MajorName", MajorName);
            info.AddValue("Department", Department);
            info.AddValue("Courses", Courses);
        }

        protected Major(SerializationInfo info, StreamingContext context)
        {
            MajorID = info.GetString("MajorID");
            MajorName = info.GetString("MajorName");
            Department = (Department)info.GetValue("Department", typeof(Department));
            Courses = (List<Course>)info.GetValue("Courses", typeof(List<Course>));
        }
    }
}
