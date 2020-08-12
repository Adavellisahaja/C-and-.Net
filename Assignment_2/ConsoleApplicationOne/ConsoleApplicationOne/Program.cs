/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using LibraryOne;
using LibraryTwoArray;


namespace Assignment2
{
    public class PartASolution
    {
        public static void Main(string[] args)
        {
            try
            {
                // Test Case - 1
                // Initializing constructor without parameters
                Time2 t1 = new Time2();
                Console.WriteLine("t1: all arguments defaulted");
                Console.WriteLine(" {0}", t1.ToUniversalString());
                Console.WriteLine(" {0}\n", t1.ToString());

                // Test Case - 2
                // Initializing constructor with one single parameter - hour
                Time2 t2 = new Time2(2);
                Console.WriteLine("Constructed with:\n");
                Console.WriteLine("t2: hour specified; minute and second defaulted");
                Console.WriteLine(" {0}", t2.ToUniversalString());
                Console.WriteLine(" {0}\n", t2.ToString());

                // Test Case - 3
                // Initializing constructor with two parameters - hour, minute
                Time2 t3 = new Time2(21, 34);
                Console.WriteLine("t3: hour and minute specified; second defaulted");
                Console.WriteLine(" {0}", t3.ToUniversalString());
                Console.WriteLine(" {0}\n", t3.ToString());

                // Test Case - 4
                // Initializing constructor with all parameters - hour, minute, second
                Time2 t4 = new Time2(12, 25, 42);
                Console.WriteLine("t4: hour, minute and second specified");
                Console.WriteLine(" {0}", t4.ToUniversalString());
                Console.WriteLine(" {0}\n", t4.ToString());


                // Test Case - 5
                // Initializing constructor with previous object
                Time2 t5 = new Time2(t4);
                Console.WriteLine("t5: Time2 object t4 specified");
                Console.WriteLine(" {0}", t5.ToUniversalString());
                Console.WriteLine(" {0}", t5.ToString());


                // Test Case - 6 (Negative Test Case)
                // Adding invalid values for hour, minute, second
                Time2 t6 = new Time2();
                Console.WriteLine("Running test case #6 - Adding invalid values for hour, minute, second");
                try
                {
                    t6.addtime(25, 120, 120);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                // Resetting the time object t1 to valid values
                t6.SetTime(4, 5, 6);


                // Test Case - 7 (Negative Test Case)
                // Invalid values
                Time2 t7;

                try
                {
                    t7 = new Time2(27, 45, 99);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("\nException while initializing t7:");
                    Console.WriteLine(ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}