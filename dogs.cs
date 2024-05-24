using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt2
{
    internal class dogs
    {
        public static string? Name { get; set; }
        public static double Weight { get; set; }
        public string?Color { get; set; }   
        public int Age { get; set; }    

        public bool CheckingGender {  get; set; }   
        //? cho phep thuoc tinh co the khong co gia tri (null)
        public dogs (string name , double weight )
        {
            Name= name;
            Weight= weight;
        }
        public double Getweight()
        {
            return Weight;
        }

    }
}
