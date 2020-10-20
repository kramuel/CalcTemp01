using System;
using System.Linq;

namespace CalcTemp01
{
    class Program
    {
        static void Main(string[] args)
        {
            //vars
            int userInput;

            //constant loop, quits with 0 in menu
            while (true)
            {
                //draw menu ( method )
                PrintMenu();


                //get user menu sel
                userInput = GetUsrSel();
                
                //check if quit
                if (userInput == 0)
                {
                    //exit de game
                    Console.WriteLine("Thanks for using dis, byebye");
                    break;
                }
                else
                {//runs the chosen converter method
                    switch( userInput )
                    {
                        //menu1 convert cel -> far
                        case 1:
                            ConverterMode("Celsius", "Fahrenheit", userInput);
                            break;
                        //menu2 convert far -> cel
                        case 2:
                            ConverterMode("Fahrenheit", "Celsius", userInput);
                            break;
                        //menu3 convert cel -> kel
                        case 3:
                            ConverterMode("Celsius", "Kelvin", userInput);
                            break;
                        //menu4 convert kel -> far
                        case 4:
                            ConverterMode( "Kelvin", "Fahrenheit", userInput);
                            break;
                    }
                }
            }
        }

        static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Hello welcome to converter, please choose:");
            Console.WriteLine("1: Convert from Celsius to Fahrenheit.");
            Console.WriteLine("2: Convert from Fahrenheit to Celsius.");
            Console.WriteLine("3: Convert from Celsius to Kelvin.");
            Console.WriteLine("4: Convert from Kelvin to Fahrenheit.");
            Console.WriteLine("0: Quit");
            Console.WriteLine("Please enter 1-4 to choose:  ");
           
        }

       
        static int GetUsrSel()
        {
            int userInput = int.Parse(Console.ReadLine());
            //input can only be 0-4
            int[] menuInt = new int[5] { 1, 2, 3, 4, 0 };
            while (!menuInt.Contains(userInput))
            {
                //wrong input loop
                Console.WriteLine("wrong input try again: ");
                userInput = int.Parse(Console.ReadLine());
            }
            return userInput;
        }

        //menu for the converter, clears console and is in loop. esc to go back to menu
        static void ConverterMode(string from, string to, int menuChoice)
        {
            double? outTemp;
            double inTemp;
            ConsoleKeyInfo cki;

            do
            {

                Console.Clear();
                Console.WriteLine("**** {0} to {1} Converter! ****", from, to);
                Console.Write("Enter temperature in {0}:  ", from);
                inTemp = double.Parse(Console.ReadLine());
                outTemp = ConvertCalculations(menuChoice, inTemp);

                Console.WriteLine("The temperature {1}{0}{3} is equal to {2}{0}{4}", (char)176, inTemp, outTemp, from[0], to[0]);
                Console.WriteLine("Press 'Escape' to go back to the menu, hit any other key to convert another number!");
                cki = Console.ReadKey(false);

            } while (cki.Key != ConsoleKey.Escape);
            
        }

        static double? ConvertCalculations(int menuChoice, double inTemp)
        {
            switch (menuChoice)
            {
                //cel -> far
                case 1:
                    return ( inTemp * 1.8 ) - 32 ;
                //far -> cel
                case 2:
                    return ( inTemp - 32 ) / 1.8 ;
                //cel -> kel  
                case 3:
                    return inTemp + 273.15;
                //kel -> far    
                case 4:
                    return ( inTemp * 1.8 ) - 459.67;
                    
                default:
                    return null;

            }
        }
        
        //#region mathematics calculations
        //static double CelToFarCalc(double celsius)
        //{
        //    return celsius * 123;
        //}
        //static double FarToCelCalc(double fahrenheit)
        //{
        //    /*Console.Clear();
        //    Console.WriteLine("vilkommen till fahrenheit to celsius converter!!");*/
        //    return fahrenheit * 32;
        //}

        //static double CelToKelCalc(double celsius)
        //{
        //    /*Console.Clear();
        //    Console.WriteLine("vilkommen till Celsius to Kelvin converter!!");*/
        //    return celsius - 32;
        //}

        //static double KelToFarCalc(double kelvin)
        //{
        //    /*Console.Clear();
        //    Console.WriteLine("vilkommen till Kelvin to Fahrenheit converter!!");*/
        //    return kelvin * 1233;
        //}
        //#endregion
        
    }
}
