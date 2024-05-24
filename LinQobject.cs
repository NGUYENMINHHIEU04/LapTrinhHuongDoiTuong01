using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPex03
{
    public class LinQobject
    {
        public void GetAllPerson()
        {
            //Lish : khai bao kieu du lieu dang danh sach cho phep luu nhieu gia tri khac nhau trong mot bien[cac gia tri do co cung kieu du lieu  voi nhau ] 
            List<Person> list = new List<Person>();
            {
                new Person() { Id = 1, Name = "MANHDOG", Email = "MANHNGU123@", Phone = "99979", Address = "HN", Age = 18, Salary = 1 };
                new Person() { Id = 2, Name = "MANHDOG2", Email = "MANHNGU1263@", Phone = "99299", Address = "HN", Age = 25, Salary = 1 };
                new Person() { Id = 3, Name = "MANHDOG3", Email = "MANHNGU1234@", Phone = "98999", Address = "HN", Age = 30, Salary = 1 };
            };
            // loc ra nguoi co id 3 
            var person = from people in list
                         where people.Age > 23
                         select people;
            foreach (var item in person)
            {
                Console.WriteLine($"ID = {item.Id} , Name = {item.Name} , Email = {item.Email}");
            }
            // tinh tong tien luong cua moi nguoi 

            var allSalary = from Salaries in list
                            select Salaries.Salary;

            var sumsalary = allSalary.Sum();
            foreach (var item in allSalary)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Sumofsalary : {sumsalary}");
        }
        public void Products()
        {
            List<Product> products = new List<Product>()
            {
             new Product(){Id = 1, Name ="Iphone15", Description ="SieuVipbro",Qty =10, Price = 2.499,Discount = "hieudeptrai"},
             new Product(){Id = 2, Name ="Phóng lợn", Description ="Dành cho các cháu c2/c3",Qty =5, Price = 250,Discount = null},
             new Product(){Id = 3, Name ="Bphone", Description ="null",Qty =15, Price = 1.259,Discount = null},
             new Product(){Id = 4, Name ="Iphone15", Description ="SieuVipbro",Qty =10, Price = 2.499,Discount = null},
            };
            // su dung LinQ de su ly du lieu 
            // lay ra tat ca cac san pham co ma giam gia
            var product = from Product in products
                          where Product.Id == 2
                          select Product;
            foreach (var item in product)
            {
                Console.WriteLine($"ID = {item.Id} , Name = {item.Name} , Description = {item.Description} , Qty = {item.Qty}");

            }

            var pPrice = from Product in products
                         where Product.Id == 2
                         select Product;
            var sumPrice =Price.Sum();
            Console.WriteLine($"tong la {sumPrice}");
        }

    }
}