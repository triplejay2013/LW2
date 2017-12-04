using System;

namespace Factorials
{
    class Example
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your factorial: ");
            
            int num = int.Parse(Console.ReadLine());
            int fact = num;
            
            for (int i = (num - 1);  i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("\nFactorial of "+num+"! : "+fact);
            Console.ReadLine();
 
        }
    }
}