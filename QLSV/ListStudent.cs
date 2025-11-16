using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace QuanLySinhVien
{
    [Serializable]
    public class ListStudent : ISerializable
    {
        private static ListStudent instance;
        public List<Student> ListStudents { get; set; }

        public static ListStudent GetInstance()
        {
            if (instance == null)
                instance = new ListStudent();
            return instance;
        }

        private ListStudent()
        {
            ListStudents = new List<Student>();

            StudentFactory factory = StudentFactory.GetInstance();

            List<Department> departments = ListDepartment.GetInstance().ListDepartments;
            List<Major> majors = ListMajor.GetInstance().ListMajors;

            Department cntt = null;
            Department tcnh = null;
            Department qtkd = null;

            foreach (Department d in departments)
            {
                if (d.Name == "Khoa CNTT kinh doanh")
                    cntt = d;
                else if (d.Name == "Khoa Tài chính")
                    tcnh = d;
                else if (d.Name == "Khoa Quản trị")
                    qtkd = d;
            }

            Major FindMajor(string majorID)
            {
                foreach (Major m in majors)
                {
                    if (m.MajorID == majorID)
                        return m;
                }
                return null;
            }

            Student s1 = factory.Create(
                "Lê Quân", new DateTime(2006, 5, 21), "Nam",
                "31241021233", cntt, "Sinh viên", "Đang học",
                "TP.HCM", "lequan@gmail.com", "0962606889",
                new DateTime(2024, 9, 5), "K50", FindMajor("CNTT01"));

            Student s2 = factory.Create(
                "Đức Trung", new DateTime(2006, 10, 24), "Nam",
                "31241021234", tcnh, "Sinh viên", "Đang học",
                "TP.HCM", "ductrung@gmail.com", "0987654321",
                new DateTime(2023, 9, 5), "K50", FindMajor("TCNH01"));

            Student s3 = factory.Create(
                "Tuấn Hải", new DateTime(2006, 9, 25), "Nam",
                "31241021235", qtkd, "Sinh viên", "Đang học",
                "TP.HCM", "tuanhai@gmail.com", "0923614369",
                new DateTime(2023, 9, 5), "K50", FindMajor("QTKD01"));

            Student s4 = factory.Create(
                "Võ Nghĩa", new DateTime(2006, 9, 25), "Nam",
                "31241021236", qtkd, "Sinh viên", "Đang học",
                "TP.HCM", "vonghia@gmail.com", "0923614231",
                new DateTime(2023, 9, 5), "K50", FindMajor("QTKD01"));

            ListStudents.Add(s1);
            ListStudents.Add(s2);
            ListStudents.Add(s3);
            ListStudents.Add(s4);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ListStudents", ListStudents);
        }

        protected ListStudent(SerializationInfo info, StreamingContext context)
        {
            ListStudents = (List<Student>)info.GetValue("ListStudents", typeof(List<Student>));
        }
    }
}
