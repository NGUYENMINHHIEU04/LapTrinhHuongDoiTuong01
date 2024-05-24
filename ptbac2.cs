using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01
{
    public  class ptbac2
    {
        private double hsa { get; set; }
        private double hsb {get; set; }
        private double hsc {  get; set; }
       // method contructor 
       // dau hieu : ten phuogn thuc trung voi ten cua class
       public ptbac2(double a , double b , double c)
       {
            // ham khoi tao contructor 
            // phuong thuc tu dong chay dau tien khi khoi tao doi tuong cho class
            hsa = a;
            hsb = b;
            hsc = c;  
            // thong thuong phuong thuc se laf noi gan gia tri cho thuoc tinh 
       }
        private string timnghiemphuongtrinh()
        {
            //tinh delta
            double delta = (hsb * hsb ) - (4 * hsa *hsc );
            if ( delta < 0 )
            {
                return " phuongtrinh vo nghiem ";

            }
            else if ( delta==0)
            {
                double X = (-hsb)/(2*hsa);
                return $" phuong trinh co nghiem kep x1 = x2 = {X}";
            }
            else
            {
                double X1 = (-hsb + Math.Sqrt(delta)) / (2*hsa);
                double X2 = (-hsb -Math.Sqrt(delta)) /(2* hsa);
                return $"phuong trinh co hai nghiem X1 ={X1} , X2 = {X2} ";
            }
        }
        public void Showresult()
        {
            string result = timnghiemphuongtrinh();
            Console. WriteLine(result);
        }
    }
}
