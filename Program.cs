using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentUc2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the value");
            // Display the number of command line arguments.
            Console.WriteLine("Enter the value of : a1");
            int a1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of : b1");
            int b1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of : c1");
            int c1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of : a2");
            int a2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of : b2");
            int b2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of : c2");
            int c2 = Convert.ToInt32(Console.ReadLine());
            {
                    if ((a1 / a2 == b1 / b2) && (a1 / a2 == c1 / c2) && (b1 / b2 == c1 / c2))
                        Console.WriteLine("the given straight lines are equal");
                    else
                        Console.WriteLine("the given straight lines are not equal");
                }
            }
        }
    }
