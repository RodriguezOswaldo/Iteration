using System;
using System.Collections.Generic;
using System.Text;

namespace Iteration
{
    class RandomNumbers
    {
        public static void newRandom()
        {
            //To see the random number represented by a string
            //https:///www.ascii-code.com/
            var random = new Random();
            int number = random.Next(1, 20);
            int i;
            for ( i = 0; i != number; i++)
                Console.WriteLine(i);
            if(number == i)
                Console.WriteLine("this is the number " + i);
            
            else
            {
                Console.WriteLine("no the number");
            }
        }

        public static void RandomCharacter()
        {
            //generate random password
            Console.WriteLine("\n");
            var random = new Random();
            for (var i = 0; i < 10; i ++ )
                Console.Write((char)random.Next(97, 122));
            Console.WriteLine("\n");
        }

        public static void storingRandomNo()
        {
            var random = new Random();
            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
                buffer[i] = (char) ('a' + random.Next(0, 26));

            var password =  new string(buffer);

            Console.WriteLine(password);

        }
    }
}
