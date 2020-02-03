//N5284
//Program 4
//April 30, 2019
//CIS 199-75
//Program creates and displays multiple packages to be shiped, using a GroundPackage class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array of 5 ground packages
            GroundPackage[] packages = new GroundPackage[5];

            // Add packages to Array
            packages[0] = new GroundPackage(40208, 50403, 12.5, 5.0, 3.0, 2.5);
            packages[1] = new GroundPackage(12034, 32423,  3.4, 3.4, 3.4, 3.2);
            packages[2] = new GroundPackage(04323, 83029, 14.5, 8.3, 5.4, 6.7);
            packages[3] = new GroundPackage(23093, 80423, 12.6, 4.5, 3.3, 2.6);
            packages[4] = new GroundPackage(32093, 43048, 10.9, 7.2, 4.6, 2.3);

            DisplayPackages(packages);

            // Change some data values in packages
            packages[0].Length =  2.5;
            packages[0].Width  =  4.5;
            packages[1].Height =  6.2;
            packages[1].Weight =  4.5;
            packages[2].Length = 12.3;
            packages[2].Width  =  5.2;
            packages[3].Height =  3.1;
            packages[3].Weight =  4.3;
            packages[3].Length = 15.0;
            packages[4].Width  =  4.5;
            packages[4].Height =  4.3;
            packages[4].Weight =  3.9;

            DisplayPackages(packages);
        }

        // Precondition:  None
        // Postcondition: Display packages to console
        public static void DisplayPackages(GroundPackage[] packages)
        {
            foreach(GroundPackage package in packages)
            {
                Console.WriteLine($"{package.ToString()}");
                Console.WriteLine($"{package.CalcCost():C}");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
