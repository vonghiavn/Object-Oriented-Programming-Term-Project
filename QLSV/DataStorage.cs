using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace QuanLySinhVien
{
    public static class DataStorage
    {
        private const string DepartmentFile = @"D:\departments.dat";
        private const string CourseFile = @"D:\courses.dat";
        private const string StudentFile = @"D:\students.dat";
        private const string UserFile = @"D:\users.dat";

        public static void SaveData()
        {
            SaveObject(ListDepartment.GetInstance(), DepartmentFile);
            SaveObject(ListCourse.GetInstance(), CourseFile);
            SaveObject(ListStudent.GetInstance(), StudentFile);
            SaveObject(ListUser.GetInstance(), UserFile);
        }

        public static void LoadData()
        {
            ListDepartment dep = LoadObject<ListDepartment>(DepartmentFile);
            if (dep != null)
                ListDepartment.GetInstance().ListDepartments = dep.ListDepartments;

            ListCourse course = LoadObject<ListCourse>(CourseFile);
            if (course != null)
                ListCourse.GetInstance().ListCourses = course.ListCourses;

            ListStudent stu = LoadObject<ListStudent>(StudentFile);
            if (stu != null)
                ListStudent.GetInstance().ListStudents = stu.ListStudents;

            ListUser usr = LoadObject<ListUser>(UserFile);
            if (usr != null)
                ListUser.GetInstance().ListAccountUser = usr.ListAccountUser;

            ReconnectAssociations();
        }

        private static void SaveObject(object obj, string filePath)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
#pragma warning disable SYSLIB0011
                    bf.Serialize(fs, obj);
#pragma warning restore SYSLIB0011
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Lỗi khi lưu file {filePath}: {ex.Message}");
            }
        }

        private static T LoadObject<T>(string filePath) where T : class
        {
            try
            {
                if (!File.Exists(filePath))
                    return null;

                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
#pragma warning disable SYSLIB0011
                    return (T)bf.Deserialize(fs);
#pragma warning restore SYSLIB0011
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    $"⚠️ Lỗi khi đọc file {filePath}:\n{ex.Message}");
                return null;
            }
        }

        private static void ReconnectAssociations()
        {
            List<Department> departments = ListDepartment.GetInstance().ListDepartments;
            List<Course> courses = ListCourse.GetInstance().ListCourses;

            // Gắn lại các liên kết từ Course đến Major
            foreach (Course c in courses)
            {
                for (int i = c.Majors.Count - 1; i >= 0; i--)
                {
                    Major oldMajor = c.Majors[i];

                    // tìm đúng major mới được load từ Department
                    Major realMajor = FindMajorByID(oldMajor.MajorID);

                    if (realMajor != null)
                        c.Majors[i] = realMajor;
                }
            }

            // Gắn lại liên kết từ Major đến Department (vì Major đã được serialize)
            foreach (Department d in departments)
            {
                foreach (Major m in d.Majors)
                {
                    m.Department = d;

                    // Gắn lại các Course
                    for (int i = 0; i < m.Courses.Count; i++)
                    {
                        string id = m.Courses[i].CourseID;
                        Course realCourse = FindCourseByID(id);

                        if (realCourse != null)
                            m.Courses[i] = realCourse;

                        if (!realCourse.Majors.Contains(m))
                            realCourse.Majors.Add(m);
                    }
                }
            }
        }

        private static Major FindMajorByID(string id)
        {
            foreach (Department d in ListDepartment.GetInstance().ListDepartments)
                foreach (Major m in d.Majors)
                    if (m.MajorID == id)
                        return m;

            return null;
        }

        private static Course FindCourseByID(string id)
        {
            foreach (Course c in ListCourse.GetInstance().ListCourses)
                if (c.CourseID == id)
                    return c;

            return null;
        }
    }
}
