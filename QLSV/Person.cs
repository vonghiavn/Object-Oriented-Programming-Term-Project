using System;
using System.Runtime.Serialization;

namespace QuanLySinhVien
{
    [Serializable]
    public abstract class Person : ISerializable
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        protected Person() { }

        protected Person(string name, DateTime birthDay, string sex, string address, string email, string phoneNumber)
        {
            Name = name;
            BirthDay = birthDay;
            Sex = sex;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("BirthDay", BirthDay);
            info.AddValue("Sex", Sex);
            info.AddValue("Address", Address);
            info.AddValue("Email", Email);
            info.AddValue("PhoneNumber", PhoneNumber);
        }

        protected Person(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("Name");
            BirthDay = info.GetDateTime("BirthDay");
            Sex = info.GetString("Sex");
            Address = info.GetString("Address");
            Email = info.GetString("Email");
            PhoneNumber = info.GetString("PhoneNumber");
        }
    }
}
