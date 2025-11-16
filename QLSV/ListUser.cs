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
    public class ListUser : ISerializable
    {
        private static ListUser instance;
        public List<User> ListAccountUser { get; set; }

        public static ListUser GetInstance()
        {
            if (instance == null)
                instance = new ListUser();
            return instance;
        }

        private ListUser()
        {
            ListAccountUser = new List<User>
            {
                new User("lequan", "123", true),
                new User("abc", "1234", false)
            };
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ListAccountUser", ListAccountUser);
        }

        protected ListUser(SerializationInfo info, StreamingContext context)
        {
            ListAccountUser = (List<User>)info.GetValue("ListAccountUser", typeof(List<User>));
        }
    }
}
