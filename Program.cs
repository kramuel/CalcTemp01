using System;
using System.Linq;

namespace CalcTemp01
{
    class Program
    {
        static void Main(string[] args)
        {
            //vars
            int[] menuInt = new int[5] { 1, 2, 3, 4, 0 };
            int userInput;

            //draw menu ( method)
            PrintMenu();


            //get user menu sel
            userInput = int.Parse(Console.ReadLine());
            while (!menuInt.Contains(userInput))
            {
                //wrong input loop
                Console.WriteLine("wrong input try again: ");
                userInput = int.Parse(Console.ReadLine());
            }

            MenuChoice(userInput);


            //menu1 convert cel -> far
            if (userInput == 1)
            {
                CelToFar();
            }

            //menu2 convert far -> cel


            //menu3 convert cel -> kel


            //menu4 convert kel -> far


            //menu 0 exit;


            //print result





            //stop


            Console.ReadKey();
        }
        static void PrintMenu()
        {
            
            Console.WriteLine("Hello welcome to converter, please choose:");
            Console.WriteLine("1: Convert from Celsius to Fahrenheit.");
            Console.WriteLine("2: Convert from Fahrenheit to Celsius.");
            Console.WriteLine("3: Convert from Celsius to Kelvin.");
            Console.WriteLine("4: Convert from Kelvin to Fahrenheit.");
            Console.WriteLine("0: Quit");
            Console.WriteLine("Please enter 1-4 to choose:  ");
           
        }
        static void MenuChoice(int userInput)
        {

        }
        static void CelToFar()
        {
            
            Console.Clear();
            Console.WriteLine("vilkommen till celsius to fahrenheit converter!!");
            while ()
            {
                Console.WriteLine("What is the  *number*?:  ");
                int userInput = int.Parse(Console.ReadLine());


                Console.WriteLine("enter '1' to convert another number");
                Console.WriteLine("enter '2' toexit to menu");
            }
            



        }
    }
}
