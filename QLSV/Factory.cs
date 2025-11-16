using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace QuanLySinhVien
{
    public interface IEntityFactory<T>
    {
        T Create(params object[] parameters);
    }

    public class StudentFactory : IEntityFactory<Student>
    {
        private static StudentFactory instance;

        public static StudentFactory GetInstance()
        {
            if (instance == null)
                instance = new StudentFactory();
            return instance;
        }

        private StudentFactory() { }

        public Student Create(params object[] parameters)
        {
            if (parameters.Length < 13)
                throw new ArgumentException("Không đủ tham số để tạo Student");

            try
            {
                return new Student(
                    name: (string)parameters[0],
                    birthDay: (DateTime)parameters[1],
                    sex: (string)parameters[2],
                    studentID: (string)parameters[3],
                    department: (Department)parameters[4],
                    position: (string)parameters[5],
                    status: (string)parameters[6],
                    address: (string)parameters[7],
                    email: (string)parameters[8],
                    phoneNumber: (string)parameters[9],
                    enrollDate: (DateTime)parameters[10],
                    enrollID: (string)parameters[11],
                    major: (Major)parameters[12]
                );
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tạo Student: {ex.Message}");
            }
        }
    }

    public class DepartmentFactory : IEntityFactory<Department>
    {
        private static DepartmentFactory instance;

        public static DepartmentFactory GetInstance()
        {
            if (instance == null)
                instance = new DepartmentFactory();
            return instance;
        }

        private DepartmentFactory() { }

        public Department Create(params object[] parameters)
        {
            if (parameters.Length < 1)
                throw new ArgumentException("Cần tên khoa để tạo Department");

            string name = parameters[0] as string;
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Tên khoa không hợp lệ");

            return new Department(name);
        }

        public Department CreateWithMajors(string name, List<Major> majors)
        {
            Department dept = new Department(name);
            if (majors != null)
            {
                foreach (Major major in majors)
                {
                    dept.Majors.Add(major);
                    major.Department = dept;
                }
            }
            return dept;
        }
    }

    public class MajorFactory : IEntityFactory<Major>
    {
        private static MajorFactory instance;

        public static MajorFactory GetInstance()
        {
            if (instance == null)
                instance = new MajorFactory();
            return instance;
        }

        private MajorFactory() { }

        public Major Create(params object[] parameters)
        {
            if (parameters.Length < 3)
                throw new ArgumentException("Cần ít nhất 3 tham số: MajorID, MajorName, Department");

            try
            {
                return new Major(
                    majorID: (string)parameters[0],
                    majorName: (string)parameters[1],
                    department: (Department)parameters[2]
                );
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tạo Major: {ex.Message}");
            }
        }

        public Major CreateWithCourses(string majorID, string majorName, Department department, List<Course> courses)
        {
            Major major = new Major(majorID, majorName, department);

            if (courses != null)
            {
                foreach (Course course in courses)
                {
                    major.Courses.Add(course);
                    if (!course.Majors.Contains(major))
                        course.Majors.Add(major);
                }
            }

            return major;
        }
    }

    public class CourseFactory : IEntityFactory<Course>
    {
        private static CourseFactory instance;

        public static CourseFactory GetInstance()
        {
            if (instance == null)
                instance = new CourseFactory();
            return instance;
        }

        private CourseFactory() { }

        public Course Create(params object[] parameters)
        {
            if (parameters.Length < 3)
                throw new ArgumentException("Cần ít nhất 3 tham số: CourseID, Name, Credits");

            try
            {
                return new Course(
                    id: (string)parameters[0],
                    name: (string)parameters[1],
                    credit: (Credits)parameters[2]
                );
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tạo Course: {ex.Message}");
            }
        }

        public Course CreateWithFee(string courseID, string name, int creditValue, decimal feePerCredit)
        {
            Credits credit = new Credits(creditValue, feePerCredit);
            return new Course(courseID, name, credit);
        }
    }

    public class CreditsFactory : IEntityFactory<Credits>
    {
        private static CreditsFactory instance;

        public static CreditsFactory GetInstance()
        {
            if (instance == null)
                instance = new CreditsFactory();
            return instance;
        }

        private CreditsFactory() { }

        public Credits Create(params object[] parameters)
        {
            if (parameters.Length < 2)
                throw new ArgumentException("Cần 2 tham số: Value và FeePerCredit");

            try
            {
                int value = Convert.ToInt32(parameters[0]);
                decimal feePerCredit = Convert.ToDecimal(parameters[1]);

                if (value <= 0)
                    throw new ArgumentException("Số tín chỉ phải lớn hơn 0");
                if (feePerCredit < 0)
                    throw new ArgumentException("Học phí không được âm");

                return new Credits(value, feePerCredit);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tạo Credits: {ex.Message}");
            }
        }
    }

    public class UserFactory : IEntityFactory<User>
    {
        private static UserFactory instance;

        public static UserFactory GetInstance()
        {
            if (instance == null)
                instance = new UserFactory();
            return instance;
        }

        private UserFactory() { }

        public User Create(params object[] parameters)
        {
            if (parameters.Length < 3)
                throw new ArgumentException("Cần 3 tham số: UserName, Password, AccountType");

            try
            {
                string userName = (string)parameters[0];
                string password = (string)parameters[1];
                bool accountType = (bool)parameters[2];

                if (string.IsNullOrWhiteSpace(userName))
                    throw new ArgumentException("Tên đăng nhập không được để trống");
                if (string.IsNullOrWhiteSpace(password))
                    throw new ArgumentException("Mật khẩu không được để trống");

                return new User(userName, password, accountType);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tạo User: {ex.Message}");
            }
        }

        public User CreateAdmin(string userName, string password)
        {
            return Create(userName, password, true);
        }

        public User CreateStaff(string userName, string password)
        {
            return Create(userName, password, false);
        }
    }
}