using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace MultiUseCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //response string declared here for use later
            string menuResponse;
            //NOTE: methods are at bottom

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

                    Console.WriteLine("Simple math equations:");

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

                    Console.WriteLine("Perimeter Equations:");

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
                            if (menuResponse.ToLower() == "sm")
                                goto PerimeterRetry;
                            else if (menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse.ToLower() == "q")
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
                            if (menuResponse.ToLower() == "sm")
                                goto PerimeterRetry;
                            else if (menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse.ToLower() == "q")
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
                            if (menuResponse.ToLower() == "sm")
                                goto PerimeterRetry;
                            else if (menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse.ToLower() == "q")
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
                            if (menuResponse.ToLower() == "sm")
                                goto PerimeterRetry;
                            else if (menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse.ToLower() == "q")
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

                    Console.WriteLine("Area equations:");

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
                            if (menuResponse.ToLower() == "sm")
                                goto AreaRetry;
                            else if (menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse.ToLower() == "q")
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
                            if (menuResponse.ToLower() == "sm")
                                goto AreaRetry;
                            else if (menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse.ToLower() == "q")
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
                            if (menuResponse.ToLower() == "sm")
                                goto AreaRetry;
                            else if (menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse.ToLower() == "q")
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
                            if (menuResponse.ToLower() == "sm")
                                goto AreaRetry;
                            else if (menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse.ToLower() == "q")
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
                            if (menuResponse.ToLower() == "sm")
                                goto AreaRetry;
                            else if (menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse.ToLower() == "q")
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
                            if (menuResponse.ToLower() == "sm")
                                goto AreaRetry;
                            else if (menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse.ToLower() == "q")
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
                            if (menuResponse.ToLower() == "sm")
                                goto AreaRetry;
                            else if (menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse.ToLower() == "q")
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
                            if (menuResponse.ToLower() == "sm")
                                goto AreaRetry;
                            else if (menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse.ToLower() == "q")
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
                            if (menuResponse.ToLower() == "sm")
                                goto AreaRetry;
                            else if (menuResponse.ToLower() == "mm")
                                goto MainRetry;
                            else if (menuResponse.ToLower() == "q")
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
                            //cube func here
                            break;
                        case 2:
                            //rectangular cont func here
                            break;
                        case 3:
                            //pyramid func here
                            break;
                        case 4:
                            //cylinder func here
                            break;
                        case 5:
                            //cone func here
                            break;
                        case 6:
                            //sphere func here
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
                    Console.WriteLine("Distance between two points:");
                    //distance func here
                    break;
                case 6:
                    Console.WriteLine("Slope of a line:");
                    //slope func here
                    break;
                case 7:
                    Console.WriteLine("Pythagorean Theorem");
                    //pyth theorem func here
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
                            //average func here
                            break;
                        case 2:
                            //median func here
                            break;
                        case 3:
                            //mode func here
                            break;
                        case 4:
                            //range func here
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
                    Console.WriteLine("Simple interest:");
                    //simple interest func here
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

        //THIS PART GOES IN METHOD
        //public void MethodName(overloads here)
        //do{
        //math here (use Console.Write("varletter ") then readline for input to show after "letter: "
        //CW("New problem?")
        //}
        //'while' {new problem answer.ToLower == "yes"}

        //THIS PART GOES IN MENU
        //CW("Type 1 for Main Menu, 2 to Quit")
        //var answer = Console.ReadLine();
        //if (answer == 1)
        //goto MainRetry
        //else if (answer == 2)
        //CW("Bye")
        //Environment.Exit(0)


        //Perimeters
        static void CalcSquarePerimeter()
        {
            string calcResponse;
            do
            {
                Console.Write("Side (S) = ");
                decimal s = Convert.ToDecimal(Console.ReadLine());
                decimal p = 4 * s;
                Console.WriteLine("The perimeter is: {0}", p);
                Console.WriteLine("Do another? Y for Yes, or enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse.ToLower() == "y");
        }

        static void CalcRectPerimeter()
        {
            string calcResponse;
            do
            {
                Console.Write("Length = ");
                decimal l = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Width = ");
                decimal w = Convert.ToDecimal(Console.ReadLine());
                decimal p = (2*l) + (2*w);
                Console.WriteLine("The perimeter is: {0}", p);
                Console.WriteLine("Do another? Y for Yes, or enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse.ToLower() == "y");
        }

        static void CalcTrianglePerimeter()
        {
            string calcResponse;
            do
            {
                Console.Write("Side 1 = ");
                decimal s1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Side 2 = ");
                decimal s2 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Side 2 = ");
                decimal s3 = Convert.ToDecimal(Console.ReadLine());
                decimal p = s1 + s2 + s3;
                Console.WriteLine("The perimeter is: {0}", p);
                Console.WriteLine("Do another? Y for Yes, or enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse.ToLower() == "y");
        }

        static void CalcCircleCircumference()
        {
            string calcResponse;
            do
            {
                Console.Write("Diameter (Remember D=2*radius) = ");
                decimal d = Convert.ToDecimal(Console.ReadLine());
                decimal c = d * (Convert.ToDecimal(Math.PI));
                Console.WriteLine("The perimeter is: {0}", c);
                Console.WriteLine("Do another? Y for Yes, or enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse.ToLower() == "y");
        }

        //Areas
        static void CalcSquareArea()
        {
            string calcResponse;
            do
            {
                Console.Write("Side (S) = ");
                decimal s = Convert.ToDecimal(Console.ReadLine());
                decimal a = s * s;
                Console.WriteLine("The area is: {0}", a);
                Console.WriteLine("Do another? Y for Yes, or enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse.ToLower() == "y");
        }

        static void CalcRectangleArea()
        {
            string calcResponse;
            do
            {
                Console.Write("Length = ");
                decimal l = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Width = ");
                decimal w = Convert.ToDecimal(Console.ReadLine());
                decimal a = l * w;
                Console.WriteLine("The area is: {0}", a);
                Console.WriteLine("Do another? Y for Yes, or enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse.ToLower() == "y");
        }

        static void CalcParallelogramArea()
        {
            string calcResponse;
            do
            {
                Console.Write("Base = ");
                decimal b = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Height = ");
                decimal h = Convert.ToDecimal(Console.ReadLine());
                decimal a = b * h;
                Console.WriteLine("The area is: {0}", a);
                Console.WriteLine("Do another? Y for Yes, or enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse.ToLower() == "y");
        }

        static void CalcTriangleArea()
        {
            string calcResponse;
            do
            {
                Console.Write("Base = ");
                decimal b = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Height = ");
                decimal h = Convert.ToDecimal(Console.ReadLine());
                decimal a = Convert.ToDecimal(.5) * (b * h);
                Console.WriteLine("The area is: {0}", a);
                Console.WriteLine("Do another? Y for Yes, or enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse.ToLower() == "y");
        }

        static void CalcCircleArea()
        {
            string calcResponse;
            do
            {
                Console.Write("Radius = ");
                decimal r = Convert.ToDecimal(Console.ReadLine());
                decimal a = Convert.ToDecimal(Math.PI) * (r * r);
                Console.WriteLine("The area is: {0}", a);
                Console.WriteLine("Do another? Y for Yes, or enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse.ToLower() == "y");
        }

        static void CalcSphereArea()
        {
            string calcResponse;
            do
            {
                Console.Write("Radius = ");
                decimal r = Convert.ToDecimal(Console.ReadLine());
                decimal s = 4 * Convert.ToDecimal(Math.PI) * (r * r);
                Console.WriteLine("The area is: {0}", s);
                Console.WriteLine("Do another? Y for Yes, or enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse.ToLower() == "y");
        }

        static void CalcTrapezoidArea()
        {
            string calcResponse;
            do
            {
                Console.Write("B1 = ");
                decimal b1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("B2 = ");
                decimal b2 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Height = ");
                decimal h = Convert.ToDecimal(Console.ReadLine());
                decimal a = Convert.ToDecimal(.5) * ((b1 + b2) * h);
                Console.WriteLine("The area is: {0}", a);
                Console.WriteLine("Do another? Y for Yes, or enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse.ToLower() == "y");
        }

        static void CalcCubeArea()
        {
            string calcResponse;
            do
            {
                Console.Write("Side (S) = ");
                decimal s = Convert.ToDecimal(Console.ReadLine());
                decimal a = 6 * (s * s);
                Console.WriteLine("The surface area is: {0}", a);
                Console.WriteLine("Do another? Y for Yes, or enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse.ToLower() == "y");
        }

        static void CalcCylinderArea()
        {
            string calcResponse;
            do
            {
                Console.Write("Radius = ");
                decimal r = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Height = ");
                decimal h = Convert.ToDecimal(Console.ReadLine());
                decimal a = 2 * Convert.ToDecimal(Math.PI) * (r * h);
                Console.WriteLine("The surface area is: {0}", a);
                Console.WriteLine("Do another? Y for Yes, or enter to see your options.");
                calcResponse = Console.ReadLine();
            }
            while (calcResponse.ToLower() == "y");
        }
    }
}
