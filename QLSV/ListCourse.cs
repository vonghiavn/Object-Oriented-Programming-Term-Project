using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace QuanLySinhVien
{
    [Serializable]
    public class ListCourse : ISerializable
    {
        private static ListCourse instance;
        public List<Course> ListCourses { get; set; }

        public static ListCourse GetInstance()
        {
            if (instance == null)
                instance = new ListCourse();
            return instance;
        }

        private ListCourse()
        {
            ListCourses = new List<Course>();

            ListCourses.Add(new Course("CS01", "Lập trình cơ bản", new Credits(3, 500000)));
            ListCourses.Add(new Course("CS02", "Cơ sở dữ liệu", new Credits(4, 500000)));
            ListCourses.Add(new Course("MA01", "Toán cao cấp", new Credits(3, 400000)));
            ListCourses.Add(new Course("EC01", "Kinh tế vi mô", new Credits(3, 450000)));
            ListCourses.Add(new Course("MK01", "Marketing căn bản", new Credits(3, 450000)));
        }

        public Course FindByID(string id)
        {
            for (int i = 0; i < ListCourses.Count; i++)
            {
                if (ListCourses[i].CourseID == id)
                    return ListCourses[i];
            }
            return null;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Courses", ListCourses);
        }

        protected ListCourse(SerializationInfo info, StreamingContext context)
        {
            ListCourses = (List<Course>)info.GetValue("Courses", typeof(List<Course>));
        }
    }
}
