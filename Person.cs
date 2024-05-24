using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPex03
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }    
        public string? Email { get; set; }
        public string? Phone {  get; set; }  
        public string? Address {  get; set; }    
        public int Age { get; set; }      
        public double Salary { get; set; }  
    }

    public class Product()
    {
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? Description { get; set; }
            public int Qty { get; set; }
            public double Price { get; set; }
            public string? Discount { get; set; }
    }
}
