using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace MultiUseCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //response string declared here for use later in menus/submenus for navigation purposes
            string menuResponse;
                        

            //NOTE: methods are at bottom
            //EXTRA NOTE: end of methods asks if user wants to do a new equation, but can't put choices after into new method,
            //didn't want to use 'goto' but it simply works the best for navigating menus in this case

            Console.WriteLine("Multi-Use Calculator Intro");

            //Main menu
            Console.WriteLine("Please enter a number and press enter to select a category:");

            //'goto' point for this menu
            MainRetry:
            Console.WriteLine("1. Simple Math");
            Console.WriteLine("2. Perimeters");
            Console.WriteLine("3. Areas");
            Console.WriteLine("4. Volumes");
            Console.WriteLine("5. Distance Between 2 Points on a Plane");
            Console.WriteLine("6. Slope");
            Console.WriteLine("7. Pythagorean Theorem");
            Console.WriteLine("8. Central Tendencies (Mean, Median, etc)");
            Console.WriteLine("9. Simple interest");
            Console.WriteLine("10. Exit");


            var menuChoice = Convert.ToInt32(Console.ReadLine());

            switch (menuChoice)
            {
                case 1:
                    //'goto' point for this sub menu
                    SimpleRetry:

                    Console.WriteLine("Simple math equations: \n");

                    Console.WriteLine("1. Add");
                    Console.WriteLine("2. Subtract");
                    Console.WriteLine("3. Divide");
                    Console.WriteLine("4. Multiply");
                    Console.WriteLine("");
                    Console.WriteLine("5. Back to Main Menu");
                    Console.WriteLine("6. Exit");


                    var simpleSubChoice = Convert.ToInt32(Console.ReadLine());

                    switch (simpleSubChoice)
                    {
                        case 1:
                            //add function here
                            break;
                        case 2:
                            //subtract function here
                            break;
                        case 3:
                            //division function here
                            break;
                        case 4:
                            //multiply function here
                            break;
                        case 5:
                            //sends back to main menu
                            goto MainRetry;
                        case 6:
                            Console.WriteLine("Take care! Press any key to quit.");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice, please try again:");
                            goto SimpleRetry;
                    }

                    break;
                case 2:
                    //'goto' point for this sub menu
                    PerimeterRetry:

                    Console.WriteLine("Perimeter Equations: \n");

                    Console.WriteLine("1. Square");
                    Console.WriteLine("2. Rectangle");
                    Console.WriteLine("3. Triangle");
                    Console.WriteLine("4. Circle (Circumference)");
                    Console.WriteLine("5. Anything else with sides");
                    Console.WriteLine("");
                    Console.WriteLine("6. Main Menu");
                    Console.WriteLine("7. Exit");

                    var perimeterSubChoice = Convert.ToInt32(Console.ReadLine());

                    switch (perimeterSubChoice)
                    {
                        case 1:
                            CalcSquarePerimeter();

                            Console.WriteLine("Type SM for SubMenu, MM for Main Menu, or Q to quit.");
                            menuResponse = Console.ReadLine();
                            if (menuResponse != null && menuResponse.ToLower() == "sm")
                                goto PerimeterRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "q")
                            {
                                Console.WriteLine("Take care! Press any key to quit.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. Please try again.");
                                //goto whatever submenu we're in
                                goto PerimeterRetry;
                            }
                            break;
                        case 2:
                            CalcRectPerimeter();

                            Console.WriteLine("Type SM for SubMenu, MM for Main Menu, or Q to quit.");
                            menuResponse = Console.ReadLine();
                            if (menuResponse != null && menuResponse.ToLower() == "sm")
                                goto PerimeterRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "q")
                            {
                                Console.WriteLine("Take care! Press any key to quit.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. Please try again.");
                                //goto whatever submenu we're in
                                goto PerimeterRetry;
                            }
                            break;
                        case 3:
                            CalcTrianglePerimeter();

                            Console.WriteLine("Type SM for SubMenu, MM for Main Menu, or Q to quit.");
                            menuResponse = Console.ReadLine();
                            if (menuResponse != null && menuResponse.ToLower() == "sm")
                                goto PerimeterRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "q")
                            {
                                Console.WriteLine("Take care! Press any key to quit.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. Please try again.");
                                //goto whatever submenu we're in
                                goto PerimeterRetry;
                            }
                            break;
                        case 4:
                            CalcCircleCircumference();

                            Console.WriteLine("Type SM for SubMenu, MM for Main Menu, or Q to quit.");
                            menuResponse = Console.ReadLine();
                            if (menuResponse != null && menuResponse.ToLower() == "sm")
                                goto PerimeterRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "q")
                            {
                                Console.WriteLine("Take care! Press any key to quit.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. Please try again.");
                                //goto whatever submenu we're in
                                goto PerimeterRetry;
                            }
                            break;
                        case 5:
                            Console.WriteLine("Add up all the sides! It's as simple as that. Seriously.");
                            break;
                        case 6:
                            //sends user to main menu
                            goto MainRetry;
                        case 7:
                            Console.WriteLine("Take care! Press any key to quit.");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                        default:
                            //sends user back to choice list for this sub menu
                            Console.WriteLine("Invalid choice, please try again:");
                            goto PerimeterRetry;
                    }

                    break;
                case 3:
                    //'goto' point for this sub menu
                    AreaRetry:

                    Console.WriteLine("Area equations: \n");

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

                    var areaSubChoice = Convert.ToInt32(Console.ReadLine());

                    switch (areaSubChoice)
                    {
                        case 1:
                            CalcSquareArea();

                            Console.WriteLine("Type SM for SubMenu, MM for Main Menu, or Q to quit.");
                            menuResponse = Console.ReadLine();
                            if (menuResponse != null && menuResponse.ToLower() == "sm")
                                goto AreaRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "q")
                            {
                                Console.WriteLine("Take care! Press any key to quit.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. Please try again.");
                                //goto whatever submenu we're in
                                goto AreaRetry;
                            }
                            break;
                        case 2:
                            CalcRectangleArea();

                            Console.WriteLine("Type SM for SubMenu, MM for Main Menu, or Q to quit.");
                            menuResponse = Console.ReadLine();
                            if (menuResponse != null && menuResponse.ToLower() == "sm")
                                goto AreaRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "q")
                            {
                                Console.WriteLine("Take care! Press any key to quit.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. Please try again.");
                                //goto whatever submenu we're in
                                goto AreaRetry;
                            }
                            break;
                        case 3:
                            CalcParallelogramArea();

                            Console.WriteLine("Type SM for SubMenu, MM for Main Menu, or Q to quit.");
                            menuResponse = Console.ReadLine();
                            if (menuResponse != null && menuResponse.ToLower() == "sm")
                                goto AreaRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "q")
                            {
                                Console.WriteLine("Take care! Press any key to quit.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. Please try again.");
                                //goto whatever submenu we're in
                                goto AreaRetry;
                            }
                            break;
                        case 4:
                            CalcTriangleArea();

                            Console.WriteLine("Type SM for SubMenu, MM for Main Menu, or Q to quit.");
                            menuResponse = Console.ReadLine();
                            if (menuResponse != null && menuResponse.ToLower() == "sm")
                                goto AreaRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "q")
                            {
                                Console.WriteLine("Take care! Press any key to quit.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. Please try again.");
                                //goto whatever submenu we're in
                                goto AreaRetry;
                            }
                            break;
                        case 5:
                            CalcCircleArea();

                            Console.WriteLine("Type SM for SubMenu, MM for Main Menu, or Q to quit.");
                            menuResponse = Console.ReadLine();
                            if (menuResponse != null && menuResponse.ToLower() == "sm")
                                goto AreaRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "q")
                            {
                                Console.WriteLine("Take care! Press any key to quit.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. Please try again.");
                                //goto whatever submenu we're in
                                goto AreaRetry;
                            }
                            break;
                        case 6:
                            CalcSphereArea();

                            Console.WriteLine("Type SM for SubMenu, MM for Main Menu, or Q to quit.");
                            menuResponse = Console.ReadLine();
                            if (menuResponse != null && menuResponse.ToLower() == "sm")
                                goto AreaRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "q")
                            {
                                Console.WriteLine("Take care! Press any key to quit.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. Please try again.");
                                //goto whatever submenu we're in
                                goto AreaRetry;
                            }
                            break;
                        case 7:
                            CalcTrapezoidArea();

                            Console.WriteLine("Type SM for SubMenu, MM for Main Menu, or Q to quit.");
                            menuResponse = Console.ReadLine();
                            if (menuResponse != null && menuResponse.ToLower() == "sm")
                                goto AreaRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "q")
                            {
                                Console.WriteLine("Take care! Press any key to quit.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. Please try again.");
                                //goto whatever submenu we're in
                                goto AreaRetry;
                            }
                            break;
                        case 8:
                            CalcCubeArea();

                            Console.WriteLine("Type SM for SubMenu, MM for Main Menu, or Q to quit.");
                            menuResponse = Console.ReadLine();
                            if (menuResponse != null && menuResponse.ToLower() == "sm")
                                goto AreaRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "q")
                            {
                                Console.WriteLine("Take care! Press any key to quit.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. Please try again.");
                                //goto whatever submenu we're in
                                goto AreaRetry;
                            }
                            break;
                        case 9:
                            CalcCylinderArea();

                            Console.WriteLine("Type SM for SubMenu, MM for Main Menu, or Q to quit.");
                            menuResponse = Console.ReadLine();
                            if (menuResponse != null && menuResponse.ToLower() == "sm")
                                goto AreaRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "q")
                            {
                                Console.WriteLine("Take care! Press any key to quit.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. Please try again.");
                                //goto whatever submenu we're in
                                goto AreaRetry;
                            }
                            break;
                        case 10:
                            goto MainRetry;
                        case 11:
                            Console.WriteLine("Take care! Press any key to quit.");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                        default:
                            //sends user back to choice list for this sub menu
                            Console.WriteLine("Invalid choice, please try again:");
                            goto AreaRetry;
                    }

                    break;
                case 4:
                    //'goto' point for this sub menu
                    VolumeRetry:

                    Console.WriteLine("Volume equations:");

                    Console.WriteLine("1. Cube");
                    Console.WriteLine("2. Rectangular Container");
                    Console.WriteLine("3. Pyramid");
                    Console.WriteLine("4. Cylinder");
                    Console.WriteLine("5. Cone");
                    Console.WriteLine("6. Sphere");
                    Console.WriteLine("");
                    Console.WriteLine("7. Main Menu");
                    Console.WriteLine("8. Exit");

                    var volumeSubChoice = Convert.ToInt32(Console.ReadLine());

                    switch (volumeSubChoice)
                    {
                        case 1:
                            CalcCubeVolume();

                            Console.WriteLine("Type SM for SubMenu, MM for Main Menu, or Q to quit.");
                            menuResponse = Console.ReadLine();
                            if (menuResponse != null && menuResponse.ToLower() == "sm")
                                goto VolumeRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "q")
                            {
                                Console.WriteLine("Take care! Press any key to quit.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. Please try again.");
                                //goto whatever submenu we're in
                                goto VolumeRetry;
                            }
                            break;
                        case 2:
                            CalcRectContainerVolume();

                            Console.WriteLine("Type SM for SubMenu, MM for Main Menu, or Q to quit.");
                            menuResponse = Console.ReadLine();
                            if (menuResponse != null && menuResponse.ToLower() == "sm")
                                goto VolumeRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "q")
                            {
                                Console.WriteLine("Take care! Press any key to quit.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. Please try again.");
                                //goto whatever submenu we're in
                                goto VolumeRetry;
                            }
                            break;
                        case 3:
                            CalcPyramidVolume();

                            Console.WriteLine("Type SM for SubMenu, MM for Main Menu, or Q to quit.");
                            menuResponse = Console.ReadLine();
                            if (menuResponse != null && menuResponse.ToLower() == "sm")
                                goto VolumeRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "q")
                            {
                                Console.WriteLine("Take care! Press any key to quit.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. Please try again.");
                                //goto whatever submenu we're in
                                goto VolumeRetry;
                            }
                            break;
                        case 4:
                            CalcCylinderVolume();

                            Console.WriteLine("Type SM for SubMenu, MM for Main Menu, or Q to quit.");
                            menuResponse = Console.ReadLine();
                            if (menuResponse != null && menuResponse.ToLower() == "sm")
                                goto VolumeRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "q")
                            {
                                Console.WriteLine("Take care! Press any key to quit.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. Please try again.");
                                //goto whatever submenu we're in
                                goto VolumeRetry;
                            }
                            break;
                        case 5:
                            CalcConeVolume();

                            Console.WriteLine("Type SM for SubMenu, MM for Main Menu, or Q to quit.");
                            menuResponse = Console.ReadLine();
                            if (menuResponse != null && menuResponse.ToLower() == "sm")
                                goto VolumeRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "q")
                            {
                                Console.WriteLine("Take care! Press any key to quit.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. Please try again.");
                                //goto whatever submenu we're in
                                goto VolumeRetry;
                            }
                            break;
                        case 6:
                            CalcSphereVolume();

                            Console.WriteLine("Type SM for SubMenu, MM for Main Menu, or Q to quit.");
                            menuResponse = Console.ReadLine();
                            if (menuResponse != null && menuResponse.ToLower() == "sm")
                                goto VolumeRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "q")
                            {
                                Console.WriteLine("Take care! Press any key to quit.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. Please try again.");
                                //goto whatever submenu we're in
                                goto VolumeRetry;
                            }
                            break;
                        case 7:
                            //sends user to main menu
                            goto MainRetry;
                        case 8:
                            Console.WriteLine("Take care! Press any key to quit.");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                        default:
                            //sends user back to choice list for this sub menu
                            Console.WriteLine("Invalid choice, please try again:");
                            goto VolumeRetry;
                    }

                    break;
                case 5:
                    CalcPointsDistance();

                    DistRetry:
                    Console.WriteLine("Type MM for Main Menu, or Q to quit.");
                    menuResponse = Console.ReadLine();
                    if (menuResponse != null && menuResponse.ToLower() == "mm")
                        goto MainRetry;
                    else if (menuResponse != null && menuResponse.ToLower() == "q")
                    {
                        Console.WriteLine("Take care! Press any key to quit.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                        //goto whatever submenu we're in
                        goto DistRetry;
                    }
                    break;
                case 6:
                    SlopeOfLine();

                    SlopeRetry:
                    Console.WriteLine("Type MM for Main Menu, or Q to quit.");
                    menuResponse = Console.ReadLine();
                    if (menuResponse != null && menuResponse.ToLower() == "mm")
                        goto MainRetry;
                    else if (menuResponse != null && menuResponse.ToLower() == "q")
                    {
                        Console.WriteLine("Take care! Press any key to quit.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                        //goto whatever submenu we're in
                        goto SlopeRetry;
                    }
                    break;
                case 7:
                    PythagoreanTheorem();

                    PythRetry:
                    Console.WriteLine("Type MM for Main Menu, or Q to quit.");
                    menuResponse = Console.ReadLine();
                    if (menuResponse != null && menuResponse.ToLower() == "mm")
                        goto MainRetry;
                    else if (menuResponse != null && menuResponse.ToLower() == "q")
                    {
                        Console.WriteLine("Take care! Press any key to quit.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                        //goto whatever submenu we're in
                        goto PythRetry;
                    }
                    break;
                case 8:
                    //'goto' point for this sub menu
                    CentralRetry:

                    Console.WriteLine("Central Tendencies:");

                    Console.WriteLine("1. Average/Mean");
                    Console.WriteLine("2. Median");
                    Console.WriteLine("3. Mode");
                    Console.WriteLine("4. Range");
                    Console.WriteLine("");
                    Console.WriteLine("5. Main Menu");
                    Console.WriteLine("6. Exit");

                    var centralTendSubChoice = Convert.ToInt32(Console.ReadLine());

                    switch (centralTendSubChoice)
                    {
                        case 1:
                            CalcAverage();

                            AvgRetry:
                            Console.WriteLine("Type MM for Main Menu, SM for SubMenu, or Q to quit.");
                            menuResponse = Console.ReadLine();
                            if (menuResponse != null && menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "sm")
                                goto CentralRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "q")
                            {
                                Console.WriteLine("Take care! Press any key to quit.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. Please try again.");
                                //goto whatever submenu we're in
                                goto AvgRetry;
                            }
                            break;
                        case 2:
                            CalcMedian();

                            MedianRetry:
                            Console.WriteLine("Type MM for Main Menu, SM for SubMenu, or Q to quit.");
                            menuResponse = Console.ReadLine();
                            if (menuResponse != null && menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "sm")
                                goto CentralRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "q")
                            {
                                Console.WriteLine("Take care! Press any key to quit.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. Please try again.");
                                //goto whatever submenu we're in
                                goto MedianRetry;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Mode method under construction. Sorry.");
                            goto MainRetry;
                        case 4:
                            RangeRetry:

                            Console.WriteLine("Type MM for Main Menu, SM for SubMenu, or Q to quit.");
                            menuResponse = Console.ReadLine();
                            if (menuResponse != null && menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "sm")
                                goto CentralRetry;
                            else if (menuResponse != null && menuResponse.ToLower() == "q")
                            {
                                Console.WriteLine("Take care! Press any key to quit.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. Please try again.");
                                //goto whatever submenu we're in
                                goto RangeRetry;
                            }
                            CalcRange();
                            break;
                        case 5:
                            //sends user back to main menu
                            goto MainRetry;
                        case 6:
                            Console.WriteLine("Take care! Press any key to quit.");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                        default:
                            //sends user back to choice list for this sub menu
                            Console.WriteLine("Invalid choice, please try again:");
                            goto CentralRetry;
                    }

                    break;
                case 9:
                    CalcSimpleInterest();

                    InterestRetry:
                    Console.WriteLine("Type MM for Main Menu, or Q to quit.");
                    menuResponse = Console.ReadLine();
                    if (menuResponse != null && menuResponse.ToLower() == "mm")
                        goto MainRetry;
                    else if (menuResponse != null && menuResponse.ToLower() == "q")
                    {
                        Console.WriteLine("Take care! Press any key to quit.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                        //goto whatever submenu we're in
                        goto InterestRetry;
                    }
                    break;
                case 10:
                    Console.WriteLine("Take care! Press any key to quit.");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                default:
                    //Sends back to main menu choices
                    Console.WriteLine("Invalid choice, please try again:");
                    goto MainRetry;
            }

        }

        //start of math methods


        //Perimeters
        static void CalcSquarePerimeter()
        {
            string calcResponse;
            do
            {
                Console.Write("Side (S) = ");
                double s = double.Parse(Console.ReadLine());
                double p = 4 * s;
                Console.WriteLine("The perimeter is: {0}", p);
                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        static void CalcRectPerimeter()
        {
            string calcResponse;
            do
            {
                Console.Write("Length = ");
                double l = double.Parse(Console.ReadLine());
                Console.Write("Width = ");
                double w = double.Parse(Console.ReadLine());
                double p = (2 * l) + (2 * w);
                Console.WriteLine("The perimeter is: {0}", p);
                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        static void CalcTrianglePerimeter()
        {
            string calcResponse;
            do
            {
                Console.Write("Side 1 = ");
                double s1 = double.Parse(Console.ReadLine());
                Console.Write("Side 2 = ");
                double s2 = double.Parse(Console.ReadLine());
                Console.Write("Side 2 = ");
                double s3 = double.Parse(Console.ReadLine());
                double p = s1 + s2 + s3;
                Console.WriteLine("The perimeter is: {0}", p);
                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        static void CalcCircleCircumference()
        {
            string calcResponse;
            do
            {
                Console.Write("Diameter (Remember D=2*radius) = ");
                double d = double.Parse(Console.ReadLine());
                double c = d * Math.PI;
                Console.WriteLine("The perimeter is: {0}", c);
                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        //Areas
        static void CalcSquareArea()
        {
            string calcResponse;
            do
            {
                Console.Write("Side (S) = ");
                double s = double.Parse(Console.ReadLine());
                double a = s * s;
                Console.WriteLine("The area is: {0}", a);
                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        static void CalcRectangleArea()
        {
            string calcResponse;
            do
            {
                Console.Write("Length = ");
                double l = double.Parse(Console.ReadLine());
                Console.Write("Width = ");
                double w = double.Parse(Console.ReadLine());
                double a = l * w;
                Console.WriteLine("The area is: {0}", a);
                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        static void CalcParallelogramArea()
        {
            string calcResponse;
            do
            {
                Console.Write("Base = ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Height = ");
                double h = double.Parse(Console.ReadLine());
                double a = b * h;
                Console.WriteLine("The area is: {0}", a);
                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        static void CalcTriangleArea()
        {
            string calcResponse;
            do
            {
                Console.Write("Base = ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Height = ");
                double h = double.Parse(Console.ReadLine());
                double a = .5 * (b * h);
                Console.WriteLine("The area is: {0}", a);
                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        static void CalcCircleArea()
        {
            string calcResponse;
            do
            {
                Console.Write("Radius = ");
                double r = double.Parse(Console.ReadLine());
                double a = Math.PI * (r * r);
                Console.WriteLine("The area is: {0}", a);
                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        static void CalcSphereArea()
        {
            string calcResponse;
            do
            {
                Console.Write("Radius = ");
                double r = double.Parse(Console.ReadLine());
                double s = 4 * Math.PI * (r * r);
                Console.WriteLine("The area is: {0}", s);
                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        static void CalcTrapezoidArea()
        {
            string calcResponse;
            do
            {
                Console.Write("B1 = ");
                double b1 = double.Parse(Console.ReadLine());
                Console.Write("B2 = ");
                double b2 = double.Parse(Console.ReadLine());
                Console.Write("Height = ");
                double h = double.Parse(Console.ReadLine());
                double a = .5 * ((b1 + b2) * h);
                Console.WriteLine("The area is: {0}", a);
                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        static void CalcCubeArea()
        {
            string calcResponse;
            do
            {
                Console.Write("Side (S) = ");
                double s = double.Parse(Console.ReadLine());
                double a = 6 * (s * s);
                Console.WriteLine("The surface area is: {0}", a);
                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        static void CalcCylinderArea()
        {
            string calcResponse;
            do
            {
                Console.Write("Radius = ");
                double r = double.Parse(Console.ReadLine());
                Console.Write("Height = ");
                double h = double.Parse(Console.ReadLine());
                double a = 2 * Math.PI * (r * h);
                Console.WriteLine("The surface area is: {0}", a);
                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        //Volumes

        static void CalcCubeVolume()
        {
            string calcResponse;
            do
            {
                Console.Write("Side (S) = ");
                double s = double.Parse(Console.ReadLine());
                double v = s * s * s;
                Console.WriteLine("The volume is: {0}", v);
                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        static void CalcRectContainerVolume()
        {
            string calcResponse;
            do
            {
                Console.Write("Length = ");
                double l = double.Parse(Console.ReadLine());
                Console.Write("Width = ");
                double w = double.Parse(Console.ReadLine());
                Console.Write("Height = ");
                double h = double.Parse(Console.ReadLine());
                double v = l * w * h;
                Console.WriteLine("The volume is: {0}", v);
                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        static void CalcPyramidVolume()
        {
            string calcResponse;
            do
            {
                Console.Write("Base = ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Height = ");
                double h = double.Parse(Console.ReadLine());
                double v = (b * b * h) / 3;
                Console.WriteLine("The volume is: {0}", v);
                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        static void CalcCylinderVolume()
        {
            string calcResponse;
            do
            {
                Console.Write("Radius = ");
                double r = double.Parse(Console.ReadLine());
                Console.Write("Height = ");
                double h = double.Parse(Console.ReadLine());
                double v = Math.PI * (r * r) * h;
                Console.WriteLine("The volume is: {0}", v);
                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        static void CalcConeVolume()
        {
            string calcResponse;
            do
            {
                Console.Write("Radius = ");
                double r = double.Parse(Console.ReadLine());
                Console.Write("Height = ");
                double h = double.Parse(Console.ReadLine());
                double v = (Math.PI * (r * r) * h) / 3;
                Console.WriteLine("The volume is: {0}", v);
                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        static void CalcSphereVolume()
        {
            string calcResponse;
            do
            {
                Console.Write("Radius = ");
                double r = double.Parse(Console.ReadLine());
                double v = (4 * (Math.PI * (r * r * r))) / 3;
                Console.WriteLine("The volume is: {0}", v);
                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        //Distance between 2 points on a plane

        static void CalcPointsDistance()
        {
            string calcResponse;
            do
            {
                Console.Write("x1 = ");
                double x1 = double.Parse(Console.ReadLine());
                Console.Write("y1 = ");
                double y1 = double.Parse(Console.ReadLine());
                Console.Write("x2 = ");
                double x2 = double.Parse(Console.ReadLine());
                Console.Write("y2 = ");
                double y2 = double.Parse(Console.ReadLine());
                double d = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
                Console.WriteLine("The distance is: {0}", d);
                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        //Slope equation of M = (x2-x1) / (y2-y1)
        static void SlopeOfLine()
        {
            string calcResponse;
            do
            {
                Console.Write("x1 = ");
                double x1 = double.Parse(Console.ReadLine());
                Console.Write("y1 = ");
                double y1 = double.Parse(Console.ReadLine());
                Console.Write("x2 = ");
                double x2 = double.Parse(Console.ReadLine());
                Console.Write("y2 = ");
                double y2 = double.Parse(Console.ReadLine());
                double y3 = (y2 - y1);
                double x3 = (x2 - x1);

                //'x3' is the denominator in the slope equation
                //this if statement makes it 
                //so something like -1/-1 shows as 1 (the correct answer)

                if (x3 == y3 || x3 == 1 || y3 % x3 == 0)
                {
                    double m = y3 / x3;
                    Console.WriteLine("The slope of the line is: {0} (simplified) or {1}/{2} for fractional notation.", m, y3, x3);
                }
                else if (x3 != y3)
                {
                    Console.WriteLine("The slope of the line is: {0}/{1}", y3, x3);
                }
                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        //Name kinda explains what this one is
        static void PythagoreanTheorem()
        {
            string calcResponse;
            do
            {
                RetryEquation:
                Console.WriteLine("Enter 0 for the side you want to know. \n");
                Console.Write("A = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("B = ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("C = ");
                double c = double.Parse(Console.ReadLine());

                if (a == 0)
                {
                    a = Math.Sqrt((c * c) - (b * b));
                    Console.WriteLine("The length of side A is: {0}", a);
                }
                else if (b == 0)
                {
                    b = Math.Sqrt((c * c) - (a * a));
                    Console.WriteLine("The length of side B is: {0}", b);
                }
                else if (c == 0)
                {
                    c = Math.Sqrt((a * a) + (b * b));
                    Console.WriteLine("The length of side C is: {0}", c);
                }
                else
                {
                    Console.WriteLine("You screwed up somewhere. Please re-read the instructions and try again. \n");
                    goto RetryEquation;
                }
                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        static void CalcAverage()
        {
            //used for do-while loop
            string calcResponse;

            List<double> avgList = new List<double>();
            do
            {
                double averageTotal = 0;
                Console.WriteLine("How many numbers are you entering?");
                int avgAmount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your numbers to find the average:");
                for (int i = 0; i < avgAmount; i++)
                {
                    double avgEntry = Convert.ToDouble(Console.ReadLine());
                    avgList.Add(avgEntry);
                    averageTotal += avgEntry;
                }
                averageTotal = averageTotal / avgAmount;
                Console.WriteLine("Your average is: {0}", averageTotal);
                avgList.Clear();

                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        static void CalcMedian()
        {
            //used for do-while loop
            string calcResponse;
            List<double> medianList = new List<double>();
            do
            {
                double medianTotal;
                Console.WriteLine("How many numbers are you entering?");
                int medianAmount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your numbers to find the median:");
                for (int i = 0; i < medianAmount; i++)
                {
                    double medianEntry = Convert.ToDouble(Console.ReadLine());
                    medianList.Add(medianEntry);
                }
                //takes middle 2 indices of an evenly numbered list and finds the avg of them
                if (medianList.Count % 2 == 0)
                {
                    medianTotal = ((medianList.ElementAt(medianList.Count / 2) - 1) +
                                   (medianList.ElementAt(medianList.Count / 2))) / 2;
                    Console.WriteLine("Your median is: {0}", medianTotal);
                    medianList.Clear();
                }
                //if not, just finds the middle number (median...)
                else if (medianList.Count % 2 == 1)
                {
                    medianTotal = (medianList.ElementAt(medianAmount / 2));
                    Console.WriteLine("Your median is: {0}", medianTotal);
                    medianList.Clear();
                }

                medianList.Clear();
                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        static void CalcRange()
        {
            //used for do-while loop
            string calcResponse;
            List<double> rangeList = new List<double>();
            do
            {
                double rangeTotal;
                Console.WriteLine("How many numbers are you entering?");
                int rangeListSize = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your numbers to find the range:");
                for (int i = 0; i < rangeListSize; i++)
                {
                    double rangeListEntry = Convert.ToDouble(Console.ReadLine());
                    rangeList.Add(rangeListEntry);
                }
                rangeList.Sort();
                rangeTotal = rangeList.ElementAt(rangeListSize - 1) - rangeList.ElementAt(0);
                Console.WriteLine("Your range is: {0}", rangeTotal);
                rangeList.Clear();

                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();

            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }

        static void CalcSimpleInterest()
        {
            //used for do-while loop
            string calcResponse;
            do
            {
                Console.Write("Principle (P) = ");
                double p = double.Parse(Console.ReadLine());
                Console.Write("Rate per year (in decimal) (r) = ");
                double r = double.Parse(Console.ReadLine());
                Console.Write("Time (in years) (t) = ");
                double t = double.Parse(Console.ReadLine());

                double interest = p * (r / 100) * t;

                Console.WriteLine("Your simple interest is: ${0}", interest);

                Console.WriteLine("Do another? Y for Yes, or press enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse != null && calcResponse.ToLower() == "y");
        }
    }
}
