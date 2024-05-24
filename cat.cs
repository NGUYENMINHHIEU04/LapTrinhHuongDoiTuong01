using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt2
{
    public class cat : Animal
    {
        public int Age { get; set; }

        public cat (int age, string name, string color, double weight) : base (name , color ,weight)
        {
            Age = age;  
            // base su sung constructor cua class cha
        }

        public override string Getgender()
        {
            // override : de ghi de phuong thuc
            // tinh da hinh trong lap trinh huong doi tuong
            return "Female";
        }
        public void Showgender()
        {
            string gender =base.Getgender ();   
            Console.WriteLine (gender);
        }
    }
}
