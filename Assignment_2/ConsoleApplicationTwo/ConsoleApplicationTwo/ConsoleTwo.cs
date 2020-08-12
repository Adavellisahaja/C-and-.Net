using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryOne;
using LibraryThree;
namespace ConsoleApplication2
{
    class ConsoleTwo
    {
        static void Main(string[] args)
        {
            var items = new List<Time2>();
            for (; ; )
            {
                try
                {
                    Console.WriteLine("Which type of object you wish to enter ?:\n");
                    Console.WriteLine("1 – time2\n2 – time2ss\n3 – Stop entering data\n");
                    int num = Int32.Parse(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("Enter Hours:\n");
                            int h = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Mintes:\n");
                            int m = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Seconds:\n");
                            int s = Int32.Parse(Console.ReadLine());
                            items.Add(new Time2(h, m, s));
                            break;
                        case 2:
                            Console.WriteLine("Enter Hours:\n");
                            int h1 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Mintes:\n");
                            int m1 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Seconds:\n");
                            int s1 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter milliSeconds:\n");
                            int ms1 = Int32.Parse(Console.ReadLine());
                            items.Add(new Time2ss(h1, m1, s1, ms1));
                            break;
                        case 3:
                            Console.WriteLine("What report do you want:\n1 – All objects\n2 – All objects with AM times\n3 – All objects with PM times\n4 - QUIT");
                            int num1 = Int32.Parse(Console.ReadLine());
                            switch (num1)
                            {
                                case 1:

                                    var itemlist = items.OrderBy(x => x.Hour);
                                    Console.WriteLine("The items are");
                                    foreach (var il in itemlist)
                                    {
                                        Console.WriteLine(il);
                                    }
                                    break;
                                case 2:

                                    var itemlist1 = items.OrderBy(x => x.Hour);
                                    Console.WriteLine("The items are");
                                    foreach (var il in itemlist1)
                                    {

                                        string str = il.ToString();
                                        if (str.Contains("AM"))
                                        {
                                            Console.WriteLine(il);
                                        }
                                    }
                                    break;
                                case 3:

                                    var itemlist2 = items.OrderBy(x => x.Hour);
                                    Console.WriteLine("The items are");
                                    foreach (var il in itemlist2)
                                    {

                                        string str = il.ToString();
                                        if (str.Contains("PM"))
                                        {
                                            Console.WriteLine(il);
                                        }
                                    }
                                    break;
                                case 4:
                                    System.Environment.Exit(1);
                                    break;
                                default:
                                    Console.WriteLine("check input");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("check input");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }
    }
}