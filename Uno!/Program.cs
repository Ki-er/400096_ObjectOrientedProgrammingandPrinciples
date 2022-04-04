using System;


namespace Uno_
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uno!");


            GameManager gameManager = new GameManager();

            GameManager.Initialise();


            


            Console.WriteLine("Press Any Key To Exit");
            Console.ReadKey();
        }


        public static int GetNumberFromUserInRange(string pQuestion, int pMin, int pMax)
        {
            int result = pMax + 1;

            do
            {
                Console.WriteLine(pQuestion);
                Console.WriteLine("Enter a number between " + pMin + " and " + pMax + " inclusive");
                try
                {
                    result = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine(Console.ReadLine() + " is not a valid input.");
                    Console.WriteLine(" ");

                    continue;
                }
                if (result < pMin || result > pMax)
                {
                    Console.WriteLine(result + " is not in range.");
                    Console.WriteLine(" ");
                    continue;
                }
                else
                {
                    return result;
                }
            } while (true);
        }

        //static void Menu()
        //{
        //    Console.WriteLine("Uno!");
        //    Console.WriteLine(" ");

        //    Console.WriteLine("Select an Option from below");
        //    Console.WriteLine("1. Play Standard Uno");
        //    Console.WriteLine("2. Rules");
        //    Console.WriteLine("3. Exit");
        //}
    }
}





