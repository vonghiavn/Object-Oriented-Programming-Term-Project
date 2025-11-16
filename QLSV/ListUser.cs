using QuanLySinhVien;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System;

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
        ListAccountUser = new List<User>();

        UserFactory factory = UserFactory.GetInstance();

        ListAccountUser.Add(factory.CreateAdmin("lequan", "123"));
        ListAccountUser.Add(factory.CreateStaff("abc", "1234"));
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
