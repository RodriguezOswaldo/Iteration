using System;
using System.Collections.Generic;
using System.Text;

namespace Iteration
{
    public class ForLoop
    {
        public static void moreLoops()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Using For Loops");

            var name = "John Smith";
            for (var i = 0; i < name.Length; i++)
            { 
                Console.WriteLine(name[i]);
            }
            Console.WriteLine("Using ForEach Loops");

            //this one those the exact same thing
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
            //Iterate over every number
            Console.WriteLine("Using ForEach Loops");

            var numbers = new int[] {1, 2, 3, 4, 5, 6};
            foreach (var number in numbers)
            {
                Console.WriteLine(number + 9);
            }
            Console.WriteLine("Using While Loops");
            var ii = 0;
            while (ii < 10)
            {
                if(ii% 2 ==0)
                    Console.WriteLine(ii);
                ii++;
            }

            while (true)
            {
                Console.WriteLine("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }

                break;


            }
        }
    }
}
