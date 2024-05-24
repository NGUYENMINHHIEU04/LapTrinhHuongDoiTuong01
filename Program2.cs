namespace Bt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cat cat = new cat(2, "manh", "bolackpink", 8);
            Console.WriteLine($"Name cat : {cat.Name} ");
            cat.Showgender();

            dogs dog = new dogs ( "manhdog",12.5);
            Console.WriteLine(dogs.Name);

            //Console.WriteLine($"Name dog : {dog.Name} "); loi vi thuoc tinh cua name dang la static nen khong duoc phep dung doi tuong cua class truy cap vao no
            // muon truy cap thuoc tinh hay phuong thuc la static thi dung truc tiep class hay ten cua class de truy cap
            double wdog= dog.Getweight();
            Console.WriteLine(dogs.Weight);


            dog.Color = default; // gan gia tri mac dinh cho thuoc tinh 
            // color la chuoi string gia tri mac dinh default se la null
            Console.WriteLine (dog.Color);  // null
            dog.Age = default;
            Console.WriteLine(dog.Age); //0
            dog.CheckingGender = default;
            Console.WriteLine(dog.CheckingGender);  // false
        }
    }
}
