using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt2
{
    public class Animal
    {
        public String Name { get; set; }    
        public String Color { get; set; } 
        public double Weight {  get; set; }

        public Animal(string name , string color, double weight )
        {
            Name = name;
            Color = color;
            Weight = weight;
        }
        
        public virtual string Getgender ()
        {
            return "Male";
        }
    }
}
