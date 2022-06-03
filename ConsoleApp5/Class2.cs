using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    
        public class KrishnamurthyNumber
        {
            // method to Check Krishnamurthy number 
            public static bool IsKrishnamurthy(int number)
            {
                //Declare Variables 
                int sum = 0, lastDigit = 0;
                int tempNum = number;
                // traverse through all digits of number 
                while (tempNum != 0)
                {
                    lastDigit = tempNum % 10;
                    sum += Convert.ToInt32(Factorial(lastDigit));
                    tempNum /= 10;
                }

                // compare sum and number 
                if (sum == number)
                    return true;
                return false;
            }
            //Method to calculate factorial of an integer 
            public static long Factorial(int number)
            {
                long fact = 1;
                for (int i = 1; i <= number; i++)
                {
                    fact *= i;
                }
                return fact;
            }
            //Main method 
            public static void Main()
            {
                //Take input from end-user 
                Console.WriteLine("Enter an integer number:");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Krishnamurthy Numbers Between 1 and " + number );
                for (int i = 1; i <= number; i++)
                {
                    bool result = IsKrishnamurthy(i);
                    if (result)
                        Console.WriteLine(i);
                }

                Console.ReadLine();
            }
        }
        
    
}
