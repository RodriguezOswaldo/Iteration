using System;
using System.Collections.Generic;
using System.Text;

namespace Iteration
{
    class SimpleLoops
    {
        #region Loops
        public static void Loops()
        {
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
        }
#endregion
    }
}
