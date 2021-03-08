using System;
using System.Collections.Generic;
using System.Text;

namespace Naimul
{
    
    class operators
    {
        public static void Main(string[] args)
        {
            int a = 100;
            int b = 50;

            int sum = a + b;
            Console.WriteLine("sum is : " + sum);
            int sub = a - b;
            Console.WriteLine("subtraton is : " + sub);
            int mul = a * b;
            Console.WriteLine("multification is : " + mul);
            int div = a / b;
            Console.WriteLine("divided is : " + div);
            int mod = a % b;
            Console.WriteLine("modulas is : " + mod);
            int incriment = a++;
            Console.WriteLine("incriment is : " + incriment);
            int dicriment = b--;
            Console.WriteLine("dicriment is : " + dicriment);
            a += 10;
            Console.WriteLine("sum is : " + a);
            b -= 5;
            Console.WriteLine("sub is : " + b);
            b *= 10;
            Console.WriteLine("mul is : " + b);
            a /= 5;
            Console.WriteLine("div is : " + a);
            a %= 7;
            Console.WriteLine("persent is : " + a);

            Console.ReadKey();
        }
    }
}
