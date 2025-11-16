using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    [Serializable]
    public class ListDepartment : ISerializable
    {
        private static ListDepartment instance;
        public List<Department> ListDepartments { get; set; }

        public static ListDepartment GetInstance()
        {
            if (instance == null)
                instance = new ListDepartment();
            return instance;
        }

        private ListDepartment()
        {
            ListDepartments = new List<Department>();

            DepartmentFactory factory = DepartmentFactory.GetInstance();

            ListDepartments.Add(factory.Create("Khoa CNTT kinh doanh"));
            ListDepartments.Add(factory.Create("Khoa Tài chính"));
            ListDepartments.Add(factory.Create("Khoa Quản trị"));
            ListDepartments.Add(factory.Create("Khoa Kinh doanh quốc tế"));
            ListDepartments.Add(factory.Create("Khoa Ngân hàng"));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ListDepartments", ListDepartments);
        }

        protected ListDepartment(SerializationInfo info, StreamingContext context)
        {
            ListDepartments = (List<Department>)info.GetValue("ListDepartments", typeof(List<Department>));
        }
    }
}
