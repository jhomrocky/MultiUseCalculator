using System;

namespace MultiUseCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multi-Use Calculator Intro");


            Console.WriteLine("Please enter a number and press enter to select a category:");
            Console.WriteLine("1. Simple Math");
            Console.WriteLine("2. Perimeters");
            Console.WriteLine("3. Areas");
            Console.WriteLine("4. Volumes");
            Console.WriteLine("5. Distance Between 2 Points on a Plane");
            Console.WriteLine("6. Slope");
            Console.WriteLine("7. Pythagorean Theorem");
            Console.WriteLine("8. Central Tendencies (Mean, Median, etc)");
            Console.WriteLine("9. Simple Interest");
            Console.WriteLine("10. Exit");

            Retry:
            int menuChoice = int.Parse(Console.ReadLine());

            if (menuChoice == 1)
            {

            }
            else if (menuChoice == 2)
            {

            }
            else if (menuChoice == 3)
            {

            }
            else if (menuChoice == 4)
            {

            }
            else if (menuChoice == 5)
            {

            }
            else if (menuChoice == 6)
            {

            }
            else if (menuChoice == 7)
            {

            }
            else if (menuChoice == 8)
            {

            }
            else if (menuChoice == 9)
            {

            }
            else if (menuChoice == 10)
            {
                Console.WriteLine("Take care!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again:");
                goto Retry;
            }
        }
    }
}
