using System;
namespace ConsoleApp3
{
    public delegate void Calculation(int a, int b);
    public class Program
    {
        public static void Addition(int a, int b)
        {
            Console.WriteLine("Inside Addition");
            Console.WriteLine(a + b);
        }

        public static void Product(int a,int b)
        {
            Console.WriteLine("Inside Product");
            Console.WriteLine(a * b);
        }

        public static void Subtraction(int a, int b)
        {
            Console.WriteLine("Inside Subtraction");
            Console.WriteLine(a - b);
        }
        static void Main(string[] args)
        {
            Calculation obj = Program.Addition;
            //Calculation cal=new Calculation(Program.Addition); //Another way to create Delegate
            //cal.Invoke(10, 20);
            obj(20, 30);//50

            Calculation obj1 = Program.Product;
            obj1(20,30);//600

            Calculation obj2 = Program.Subtraction;
            obj2(20,30);//-10
        }
    }
}