using System;

namespace CSharp_Calculation
{
    public class Program
    {
        static void Main(string[] args)
        {
int num1 = 2, num2 = 1;
        Operation<int> op = new Add<int>();
            Console.WriteLine(op.Operate(num1, num2));
            op = new Sub<int>();
            Console.WriteLine(op.Operate(num1, num2));
        }
    }
}
