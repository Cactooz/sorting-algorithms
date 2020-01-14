using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            Swap(ref num1, ref num2);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
