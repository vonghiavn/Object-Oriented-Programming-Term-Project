using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class Const
    {
        public static Student NewStudent = null;
        public static Major NewMajor = null;
        public static bool AccountType;

        public static List<string> listSex = new List<string>() { "Nam", "Nữ", "Không xác định" };
        public static List<string> listStatus = new List<string>() { "Đang học","Bảo lưu", "Đã nghỉ học"};
        public static List<string> listAccountType = new List<string>() { "Admin", "Nhân sự" };

    }
}
