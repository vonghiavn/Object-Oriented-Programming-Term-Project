using System;

namespace QuanLySinhVien
{
    [Serializable]
    public class Credits
    {
        public int Value { get; set; }      
        public decimal FeePerCredit { get; set; } 

        public Credits() { }

        public Credits(int value, decimal feePerCredit)
        {
            Value = value;
            FeePerCredit = feePerCredit;
        }

        public decimal GetTotalFee()
        {
            return Value * FeePerCredit;
        }
    }
}
