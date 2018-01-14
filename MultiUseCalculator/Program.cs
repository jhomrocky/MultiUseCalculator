using System;

namespace MultiUseCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multi-Use Calculator Intro");

            //Main menu
            Console.WriteLine("Please enter a number and press enter to select a category:");

            MainRetry:
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

            
            int menuChoice = int.Parse(Console.ReadLine());

            if (menuChoice == 1) //simple math equations
            {
                Console.WriteLine("Simple math equations:");

                SimpleRetry:

                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Divide");
                Console.WriteLine("4. Multiply");
                Console.WriteLine("");
                Console.WriteLine("5. Back to Main Menu");
                Console.WriteLine("6. Exit");

                int simpleSubChoice = int.Parse(Console.ReadLine());

                if (simpleSubChoice == 1)
                {
                    //add function here
                }
                else if (simpleSubChoice == 2)
                {
                    //subtract function here
                }
                else if (simpleSubChoice == 3)
                {
                    //division function here
                }
                else if (simpleSubChoice == 4)
                {
                    //multiply function here
                }
                else if (simpleSubChoice == 5)
                {
                    //sends back to main menu
                    goto MainRetry;
                }
                else if (simpleSubChoice == 6)
                {
                    Console.WriteLine("Take care!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again:");
                    goto SimpleRetry;
                }

            }
            else if (menuChoice == 2)
            {
                Console.WriteLine("Perimeter Equations:");

                PerimeterRetry:

                Console.WriteLine("1. Square");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Triangle");
                Console.WriteLine("4. Circle (Circumference)");
                Console.WriteLine("5. Anything else with sides");
                Console.WriteLine("");
                Console.WriteLine("6. Main Menu");
                Console.WriteLine("7. Exit");

                int perimeterSubChoice = int.Parse(Console.ReadLine());

                if (perimeterSubChoice == 1)
                {
                    //square perim function here
                }
                else if (perimeterSubChoice == 2)
                {
                    //rectangle perim function here
                }
                else if (perimeterSubChoice == 3)
                {
                    //triangle perim function here
                }
                else if (perimeterSubChoice == 4)
                {
                    //circumference function here
                }
                else if (perimeterSubChoice == 5)
                {
                    Console.WriteLine("Add up all the sides! It's as simple as that.");
                }
                else if (perimeterSubChoice == 6)
                {
                    //sends user to main menu
                    goto MainRetry;
                }
                else if (perimeterSubChoice == 7)
                {
                    Console.WriteLine("Take care!");
                    Environment.Exit(0);
                }
                else
                {
                    //sends user back to choice list for this sub menu
                    Console.WriteLine("Invalid choice, please try again:");
                    goto PerimeterRetry;
                }

            }
            else if (menuChoice == 3)
            {
                Console.WriteLine("Area equations:");

                AreaRetry:
                Console.WriteLine("1. Square");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Parallelogram");
                Console.WriteLine("4. Triangle");
                Console.WriteLine("5. Circle");
                Console.WriteLine("6. Sphere");
                Console.WriteLine("7. Trapezoid");
                Console.WriteLine("8. Cube (surface area)");
                Console.WriteLine("9. Cylinder (surface area)");
                Console.WriteLine("");
                Console.WriteLine("10. Main Menu");
                Console.WriteLine("11. Exit");

                int areaSubChoice = int.Parse(Console.ReadLine());
                if (areaSubChoice == 1)
                {
                    //square area func here
                }
                else if (areaSubChoice == 2)
                {
                    //rectangle area func here
                }
                else if (areaSubChoice == 3)
                {
                    //parallelogram area func here
                }
                else if (areaSubChoice == 4)
                {
                    //triangle area func here
                }
                else if (areaSubChoice == 5)
                {
                    //circle area func here
                }
                else if (areaSubChoice == 6)
                {
                    //sphere area func here
                }
                else if (areaSubChoice == 7)
                {
                    //trapezoid area func here
                }
                else if (areaSubChoice == 8)
                {
                    //cube surface area func here
                }
                else if (areaSubChoice == 9)
                {
                    //cylinder surface area func here
                }
                else if (areaSubChoice == 10)
                {
                    goto MainRetry;
                }
                else if (areaSubChoice == 11)
                {
                    Console.WriteLine("Take care!");
                    Environment.Exit(0);
                }
                else
                {
                //sends user back to choice list for this sub menu
                Console.WriteLine("Invalid choice, please try again:");
                goto AreaRetry;
                }
                
            }
            else if (menuChoice == 4)
            {
                Console.WriteLine("Volume equations:");

                VolumeRetry:

                Console.WriteLine("1. Cube");
                Console.WriteLine("2. Rectangular Container");
                Console.WriteLine("3. Pyramid");
                Console.WriteLine("4. Cylinder");
                Console.WriteLine("5. Cone");
                Console.WriteLine("6. Sphere");
                Console.WriteLine("");
                Console.WriteLine("7. Main Menu");
                Console.WriteLine("8. Exit");

                int volumeSubChoice = int.Parse(Console.ReadLine());

                if (volumeSubChoice == 1)
                {
                    //cube func here
                }
                else if (volumeSubChoice == 2)
                {
                    //rectangular cont func here
                }
                else if (volumeSubChoice == 3)
                {
                    //pyramid func here
                }
                else if (volumeSubChoice == 4)
                {
                    //cylinder func here
                }
                else if (volumeSubChoice == 5)
                {
                    //cone func here
                }
                else if (volumeSubChoice == 6)
                {
                    //sphere func here
                }
                else if (volumeSubChoice == 7)
                {
                    //sends user to main menu
                    goto MainRetry;
                }
                else if (volumeSubChoice == 8)
                {
                    Console.WriteLine("Take care!");
                    Environment.Exit(0);
                }
                else
                {
                    //sends user back to choice list for this sub menu
                    Console.WriteLine("Invalid choice, please try again:");
                    goto VolumeRetry;
                }

            }
            else if (menuChoice == 5)
            {
                Console.WriteLine("Distance between two points:");
                //distance func here
            }
            else if (menuChoice == 6)
            {
                Console.WriteLine("Slope of a line:");
                //slope func here
            }
            else if (menuChoice == 7)
            {
                Console.WriteLine("Pythagorean Theorem");
                //pyth theorem func here
            }
            else if (menuChoice == 8)
            {
                Console.WriteLine("Central Tendencies:");

                CentralRetry:
                Console.WriteLine("1. Average/Mean");
                Console.WriteLine("2. Median");
                Console.WriteLine("3. Mode");
                Console.WriteLine("4. Range");
                Console.WriteLine("");
                Console.WriteLine("5. Main Menu");
                Console.WriteLine("6. Exit");

                int centralSubChoice = int.Parse(Console.ReadLine());

                if (centralSubChoice == 1)
                {
                    //average func here
                }
                else if (centralSubChoice == 2)
                {
                    //median func here
                }
                else if (centralSubChoice == 3)
                {
                    //mode func here
                }
                else if (centralSubChoice == 4)
                {
                    //range func here
                }
                else if (centralSubChoice == 5)
                {
                    //sends user back to main menu
                    goto MainRetry;
                }
                else if (centralSubChoice == 6)
                {
                    Console.WriteLine("Take care!");
                    Environment.Exit(0);
                }
                else
                {
                    //sends user back to choice list for this sub menu
                    Console.WriteLine("Invalid choice, please try again:");
                    goto CentralRetry;
                }
            }
            else if (menuChoice == 9)
            {
                Console.WriteLine("Simple Interest:");
                //simple interest func here
            }
            else if (menuChoice == 10)
            {
                Console.WriteLine("Take care!");
                Environment.Exit(0);
            }
            else
            {
                //Sends back to main menu choices
                Console.WriteLine("Invalid choice, please try again:");
                goto MainRetry;
            }
        }
    }
}
