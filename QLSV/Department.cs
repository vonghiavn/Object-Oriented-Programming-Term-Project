using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    [Serializable]
    public class Department : ISerializable, IDisposable
    {
        public string Name { get; set; }
        public List<Major> Majors { get; set; }

        private bool disposed = false;
        public Department(string name)
        {
            Name = name;
            Majors = new List<Major>();
        }

        public Department()
        {
            Majors = new List<Major>();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Xóa tất cả Major trong Department này
                if (Majors != null && Majors.Count > 0)
                {
                    // Duyệt ngược để tránh lỗi index khi xóa
                    for (int i = Majors.Count - 1; i >= 0; i--)
                    {
                        Major major = Majors[i];

                        if (major != null)
                        {
                            // Ngắt liên kết ngược từ Major đến Course
                            if (major.Courses != null)
                            {
                                // Duyệt qua tất cả Course của Major
                                foreach (Course course in major.Courses)
                                {
                                    if (course != null && course.Majors != null)
                                    {
                                        // Xóa Major khỏi danh sách Majors của Course
                                        course.Majors.Remove(major);
                                    }
                                }
                            }

                            // Xóa reference đến Department
                            major.Department = null;
                        }
                    }

                    // Clear toàn bộ danh sách Major
                    Majors.Clear();
                }
            }

            disposed = true;
        }
        ~Department()
        {
            Dispose(false);
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Majors", Majors);
        }

        protected Department(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("Name");
            Majors = (List<Major>)info.GetValue("Majors", typeof(List<Major>));
        }
    }
}
