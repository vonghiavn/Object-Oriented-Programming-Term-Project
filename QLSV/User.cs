using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    [Serializable]
    public class User : ISerializable
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public bool AccountType { get; set; }

        public User(string userName, string passWord, bool accountType)
        {
            UserName = userName;
            PassWord = passWord;
            AccountType = accountType;
        }

        public User() { }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("UserName", UserName);
            info.AddValue("PassWord", PassWord);
            info.AddValue("AccountType", AccountType);
        }

        protected User(SerializationInfo info, StreamingContext context)
        {
            UserName = info.GetString("UserName");
            PassWord = info.GetString("PassWord");
            AccountType = info.GetBoolean("AccountType");
        }
    }
}
