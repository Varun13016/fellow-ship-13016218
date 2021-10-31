using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Sub obj = new Sub();
            int result = obj.substract(10, 5);
            Console.WriteLine("sub" + result);

            int resultofsum = obj.addition(20, 30);
            Console.WriteLine("sum" + resultofsum);

            int resultofmult = obj.multiply(20, 30);
            Console.WriteLine("multiply" + resultofmult);

            int resultofdiv = obj.division(10, 3);
            Console.WriteLine("division" + resultofdiv);
        }
    }
}
