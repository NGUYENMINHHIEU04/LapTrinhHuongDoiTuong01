namespace OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ham chay chinh cua chuong trinh 
            // khoi tao 1 doi tuong thuoc vao class
            Student studentIT = new Student();    //khoi tao doi tuong SVCNTT
            Student studentGD = new Student();
            Student studentBiz = new Student();

            // de truy cap vao thuoc tinh cua doi tuong trong class thi ta dung cac doi tuong cua chinh class do

            studentIT.Fullname = "Nguyen Minh Hieu";  // gan gia tri 
            Console.WriteLine(studentIT.Fullname); // lay gia tri

            // studentGD.lovely = "SE06204"; 
            // lovely la private nen khong the truy cap ben ngoai class student duoc

            //studentBiz.money = "100$";
            //money la protected nen khong the truy cap ben ngoai class student duoc
            decimal myMoney = studentIT.Getmoney();
            Console.WriteLine($"my money is {myMoney}");

            //string mylove = studentIT.Getnamelovely(); loi  -  Getnamelovely dang la private


            string mylove = studentIT.Getname();
            Console.WriteLine($"my love is {mylove}");

            ptbac2 ptbh = new ptbac2(2, 3, -5);
            ptbh.Showresult();
        }
    }
}