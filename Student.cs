using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01
{
    //khai bao class
    public class Student
    {
        public string Fullname { get; set; }    
        // get , set la cho phep gan va lay gia tri
        // public :  la pham vi hoat dong (moi noi)
        private string lovely { get; set; }
        // private : pham vi hoat dong noi bo trong class
        protected decimal money { get; set; }
        // protected : chi duoc phep hoat dong noi bo trong class va nhung class ke thua no

        // khai bao cac phuong thuc
        public decimal Getmoney()
        {
            money = 200;
            return money;
        }

        private string Getnamelovely()
        {
            lovely = "se06204";
            return lovely;
        }

        public string Getname()
        {
         return Getnamelovely();
        }
    }
}
