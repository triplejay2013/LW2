using System;

namespace Primes
{
    class Example
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it is a prime: ");
            
            int number = int.Parse(Console.ReadLine());
            bool check = isPrime(number);
            
	    if(check){
	      Console.WriteLine(number + " is prime!");
            }
            else{
	      Console.WriteLine(number + " is NOT prime!");
            }
 
        }
	public static bool isPrime(int number) {  
         if (number == 2){
	      return false;
	      }  
	    if (number == 2){ 
	      return true;
	      }
	    
	    if (number % 2 == 0){
	      return false;
	    }
	    
	    for (int i = 3; i * i <= number; i += 2){
	      if (number % i == 0){ 
		  return false;
		}
            }
            return true;
        }
    }
}