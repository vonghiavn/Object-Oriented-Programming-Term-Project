using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace QuanLySinhVien
{
    [Serializable]
    public class ListMajor : ISerializable
    {
        private static ListMajor instance;
        public List<Major> ListMajors
        {
            get
            {
                List<Major> allMajors = new List<Major>();
                foreach (Department dept in ListDepartment.GetInstance().ListDepartments)
                {
                    allMajors.AddRange(dept.Majors);
                }
                return allMajors;
            }
        }

        public static ListMajor GetInstance()
        {
            if (instance == null)
                instance = new ListMajor();
            return instance;
        }

        private ListMajor()
        {
            InitializeSampleData();
        }

        public decimal GetTotalFeeByMajor(Major major)
        {
            decimal total = 0;
            if (major == null || major.Courses == null)
                return 0;

            for (int i = 0; i < major.Courses.Count; i++)
            {
                Course course = major.Courses[i];
                if (course != null && course.CreditInfo != null)
                {
                    total += course.CreditInfo.GetTotalFee();
                }
            }

            return total;
        }

        private void InitializeSampleData()
        {
            ListDepartment listDept = ListDepartment.GetInstance();
            ListCourse listCourse = ListCourse.GetInstance();

            bool anyMajorExist = false;
            foreach (Department d in listDept.ListDepartments)
            {
                if (d.Majors.Count > 0)
                {
                    anyMajorExist = true;
                    break;
                }
            }
            if (anyMajorExist)
                return;

            void AddCourseToMajor(string courseID, Major major)
            {
                Course course = listCourse.FindByID(courseID);
                if (course != null)
                {
                    major.Courses.Add(course);
                    course.Majors.Add(major);
                }
            }

            Department cntt = listDept.ListDepartments[0];
            Department tcnh = listDept.ListDepartments[1];
            Department qtkd = listDept.ListDepartments[2];
            Department kdqt = listDept.ListDepartments[3];
            Department nganHang = listDept.ListDepartments[4];


            Major cntt01 = new Major("CNTT01", "Công nghệ thông tin Kinh doanh", cntt);
            AddCourseToMajor("CS01", cntt01);
            AddCourseToMajor("CS02", cntt01);
            AddCourseToMajor("MA01", cntt01);
            cntt.Majors.Add(cntt01);

            Major cntt02 = new Major("CNTT02", "Hệ thống thông tin", cntt);
            AddCourseToMajor("CS01", cntt02);
            AddCourseToMajor("EC01", cntt02);
            AddCourseToMajor("MK01", cntt02);
            cntt.Majors.Add(cntt02);

            Major tcnh01 = new Major("TCNH01", "Tài chính doanh nghiệp", tcnh);
            AddCourseToMajor("EC01", tcnh01);
            AddCourseToMajor("MA01", tcnh01);
            tcnh.Majors.Add(tcnh01);

            Major qtkd01 = new Major("QTKD01", "Quản trị Marketing", qtkd);
            AddCourseToMajor("MK01", qtkd01);
            AddCourseToMajor("EC01", qtkd01);
            qtkd.Majors.Add(qtkd01);

            Major qtkd02 = new Major("QTKD02", "Quản trị Nhân lực", qtkd);
            AddCourseToMajor("MK01", qtkd02);
            AddCourseToMajor("MA01", qtkd02);
            qtkd.Majors.Add(qtkd02);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
        }

        protected ListMajor(SerializationInfo info, StreamingContext context)
        {
        }
    }
}
