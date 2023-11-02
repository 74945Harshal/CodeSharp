using System;

namespace ConsoleApp1
{
   delegate void MyMath(int a, int b);
    class Multicast
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition is "+ (a + b));
        }
        public static void Product(int a, int b)
        {
            Console.WriteLine("Product is "+(a * b));
        }
    }

    internal class Multicast_Delegate
    {
        static void Main(string[] args)
        {
            MyMath m1=null;
            MyMath ad = Multicast.Add;
            MyMath pd= Multicast.Product;

            //set up multicast
            m1 += ad; 
            m1 += pd;

            //call multicast
            m1(5, 6);

            //remove method from Invokation list
            m1 -= ad;

            //call multicast
            m1(10, 20);
        }
    }
}