using Part2_Recursive;
using System;
using System.Text;
using static Part2_Recursive.Bai23Menu;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        //--------Bai21 Salary------
        Console.WriteLine("\nBai 21");
        double initSalary = 1000;
        int year = 5;

        double recursiveSalary = Bai21Salary.CalSalaryRecursive(initSalary, year);
        Console.WriteLine($"Luong sau {year} nam dung de quy: {recursiveSalary}");

        double loopSalary = Bai21Salary.CalSalaryLoop(initSalary, year);
        Console.WriteLine($"Luong sau {year} nam khong dung de quy: {loopSalary}");

        //--------Bai22 Saving money------------
        Console.WriteLine("\nBai 22");
        double principal = 1000; //So tien goc
        int interestRate = 5; //Lai suat hang thang

        int monthsNeededRecursive = Bai22SavingMoney.CalCalculateMonthsRecursive(principal, interestRate);
        Console.WriteLine($"(De quy) So thang can de tien goc + lai suat tang gap doi la: {monthsNeededRecursive} thang");

        int monthsNeededLoop = Bai22SavingMoney.CalculateMonthsLoop(principal, interestRate);
        Console.WriteLine($"(Vong lap) So thang can de tien goc + lai suat tang gap doi la: {monthsNeededLoop} thang");

        //-------Bai23 Print Menu -----
        Console.WriteLine("\nBai23");
        List<Menu> menus = new List<Menu>
        {
            new Menu(1, "Thể thao", 0),
            new Menu(2, "Xã hội", 0),
            new Menu(3, "Thể thao trong nước", 1),
            new Menu(4, "Giao thông", 2),
            new Menu(5, "Môi trường", 2),
            new Menu(6, "Thể thao quốc tế", 1),
            new Menu(7, "Môi trường đô thị", 5),
            new Menu(8, "Giao thông ùn tắc", 4)
        };

        PrintMenu(menus);

        //-------Bai24 Queue -----
        Console.WriteLine("\nBai24");
        // Sử dụng Queue với kiểu dữ liệu string 
        Bai24Queue<string> queue = new Bai24Queue<string>(5);

        // Đẩy các phần tử vào hàng đợi
        queue.Push("First");
        queue.Push("Second");
        queue.Push("Third");

        // Lấy ra và in ra từng phần tử từ hàng đợi
        Console.WriteLine(queue.Get());
        Console.WriteLine(queue.Get());
        Console.WriteLine(queue.Get());

        //Kiem tra Queue co rong ko
        Console.WriteLine("Queue is empty: " + queue.IsEmpty());

        //Kiem tra Queue co day ko
        Console.WriteLine("Queue is full: " + queue.IsFull());

        //-------Bai25 Stack -----
        Console.WriteLine("\nBai25");
        Bai25Stack<string> stack = new Bai25Stack<string>(5);

        stack.Push("First");
        stack.Push("Second");
        stack.Push("Third");

        Console.WriteLine(stack.Get());
        Console.WriteLine(stack.Get());
        Console.WriteLine(stack.Get());

        Console.WriteLine("Stack is empty: " + stack.IsEmpty());

        Console.WriteLine("Stack is full: " + stack.IsFull());


    }
}