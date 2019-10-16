using System;
using System.Collections.Generic;
using System.Text;

namespace Iteration
{
    public class IterationExercises
    {

        #region Divisible
        /// <summary>
        /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
        /// Display the result on the console.
        /// </summary>
        public static void DivisibleBy3()
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i%3 == 0)
                    count++;
            }

            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100", count);
        }
        #endregion

        #region keyword from the user

        /// <summary>
        /// Write a program and continuously ask the user to enter a number. The loop terminates when the user 
        /// enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
        /// </summary>
        public static void AskTheUser()
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number (or 'ok' to exit) ");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                    break;
                sum += Convert.ToInt32(input);
            }

            Console.WriteLine("Sum of all numbers is: " + sum);
        }

        #endregion


    }
}
