using System;
using System.Collections.Generic;

namespace QuanLySinhVien
{
    [Serializable]
    public class Course
    {
        public string CourseID { get; set; }
        public string Name { get; set; }
        public Credits CreditInfo { get; set; }      // chứa cả số tín chỉ và giá/tín
        public List<Major> Majors { get; set; }      // các ngành có môn này

        public int CourseCredits
        {
            get
            {
                if (CreditInfo != null)
                    return CreditInfo.Value;
                return 0;
            }
        }

        public decimal FeePerCredit
        {
            get
            {
                if (CreditInfo != null)
                    return CreditInfo.FeePerCredit;
                return 0;
            }
        }

        public decimal TotalFee
        {
            get
            {
                if (CreditInfo != null)
                    return CreditInfo.GetTotalFee();
                return 0;
            }
        }

        public Course(string id, string name, Credits credit)
        {
            CourseID = id;
            Name = name;
            CreditInfo = credit;
            Majors = new List<Major>();
        }

        public Course(string name, string id, int courseCredits, decimal feePerCredit)
        {
            CourseID = id;
            Name = name;
            CreditInfo = new Credits(courseCredits, feePerCredit);
            Majors = new List<Major>();
        }


        // Tính học phí của riêng môn học này
        public decimal GetCourseFee()
        {
            if (CreditInfo == null)
                return 0;
            return CreditInfo.GetTotalFee();
        }
    }
}
