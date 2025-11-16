using QuanLySinhVien;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System;

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

        CourseFactory factory = CourseFactory.GetInstance();

        ListCourses.Add(factory.CreateWithFee("CS01", "Lập trình cơ bản", 3, 500000));
        ListCourses.Add(factory.CreateWithFee("CS02", "Cơ sở dữ liệu", 4, 500000));
        ListCourses.Add(factory.CreateWithFee("MA01", "Toán cao cấp", 3, 400000));
        ListCourses.Add(factory.CreateWithFee("EC01", "Kinh tế vi mô", 3, 450000));
        ListCourses.Add(factory.CreateWithFee("MK01", "Marketing căn bản", 3, 450000));
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