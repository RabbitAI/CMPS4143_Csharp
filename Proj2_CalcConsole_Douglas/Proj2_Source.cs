/*  
 *          Name: Christian Douglas
 *          Program: Proj2_CalcConsole_Douglas
 *          Date: 2 September, 2020
 *          Purpose: The program takes 3 numbers that the
 *          user enters and finds the sum, average, maximum,
 *          and minimum values and prints them to the 
 *          console.
 */
using System;
using System.Runtime.CompilerServices;

namespace Proj2_CalcConsole_Douglas
{
    class Proj2_Source
    {
        /*
         *   Method Name: Sum
         *   Parameters: num1, num2, num3
         *   Purpose: Takes the values of 3 variables and
         *   adds and returns the sum of the values.
         */
        int Sum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        /*
         *   Method Name: Avg
         *   Parameters: num1, num2, num3
         *   Purpose: Takes the values of 3 variables, 
         *   calls Sum to add the values and divides the
         *   sum by 3 and returns the average.
         */
        int Avg(int num1, int num2, int num3)
        {
            return Sum(num1, num2, num3) / 3;
        }

        /*
         *   Method Name: Maxi
         *   Parameter: num1, num2, num3
         *   Purpose: Finds the largest number out of the 3 variables.
         *   The method compares the variable to the two other 
         *   variables and multiplies the boolean value that is
         *   converted to an int to itself and is added to the other
         *   products.
         */
        int Maxi(int num1, int num2, int num3)
        {
            return Sum(
                (num1 * Convert.ToInt32(num1 >= num2 && num1 >= num3)),
                 (num2 * Convert.ToInt32(num2 > num1 && num2 > num3)),
                 (num3 * Convert.ToInt32(num3 > num1 && num3 > num2)));
        }

        /*
         *   Method Name: Mini
         *   Parameter: num1, num2, num3
         *   Purpose: Finds the smallest number out of the 3 variables.
         *   The method compares the variable to the two other 
         *   variables and multiplies the boolean value that is
         *   converted to an int to itself and is added to the other
         *   products.
         */
        int Mini(int num1, int num2, int num3)
        {
            return Sum(
                (num1 * Convert.ToInt32(num1 <= num2 && num1 <= num3)),
                (num2 * Convert.ToInt32(num2 < num1 && num2 < num3)),
                (num3 * Convert.ToInt32(num3 < num1 && num3 < num2)));
        }
        static void Main(string[] args)
        {
            //Program object
            Proj2_Source p1 = new Proj2_Source();
            //int array with a size of 3
            int[] num = new int[3];
            //Resp is the response for the switch statement at the bottom
            char Resp = 'x';

            for (int n = 0; n < 1;)
            {
                
                //Reads user input into each memory location
                //converts each value from a string to an int
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Enter a number for Number: ");
                    //checks for and exception
                    try
                    {
                        num[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    //if one is thrown num[i] value is assigned 0
                    catch
                    {
                        num[i] = 0;
                    }
                }

                //Prints the values of each variable, the sum, average,
                //the maximum number, and the minimum value
                Console.WriteLine("The sum of " + num[0] +
                    ", " + num[1] + ", and " + num[2] +
                    " is " + p1.Sum(num[0], num[1], num[2]));
                Console.WriteLine("The average of " + num[0] +
                    ", " + num[1] + " and " + num[2] + " is: "
                    + p1.Avg(num[0], num[1], num[2]));
                Console.WriteLine("The maximum number of " + num[0] +
                    ", " + num[1] + ", and " + num[2] + " is: "
                    + p1.Maxi(num[0], num[1], num[2]));
                Console.WriteLine("The minimum of " + num[0] + ", " +
                    num[1] + ", and " + num[2] + " is: "
                    + p1.Mini(num[0], num[1], num[2]));

                //A prompt and a switch statement is use to continue the loop
                //if the user wishes to continue doing calculations
                Console.WriteLine("Do you wish to do another Calculation? Y or N");
               //Checks for an exception
                try
                {
                    Resp = Convert.ToChar(Console.ReadLine());
                }
                //if one is thrown Resp is given the value ' '
                catch
                {
                    Resp = ' ';
                }

                switch(Resp)
                {
                    case 'Y':case 'y':
                            n--;
                        break;
                    case 'N':case 'n':
                        n = 1;
                        break;
                    default:
                        Console.WriteLine("Incorrect response. " +
                            " GoodBye.");
                        n = 1;
                        break;
                }

            }
        }
    }
}
