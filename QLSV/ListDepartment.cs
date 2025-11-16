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
            ListDepartments = new List<Department>
            {
                new Department("Khoa CNTT kinh doanh"),
                new Department("Khoa Tài chính"),
                new Department("Khoa Quản trị"),
                new Department("Khoa Kinh doanh quốc tế"),
                new Department("Khoa Ngân hàng")
            };
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
