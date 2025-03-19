using System.Reflection.Emit;

namespace Part_7_Lists_Programming_Assignment
{
    internal class Program
    {
        public static void IntList()
        {
            List<int> numbers = new List<int>();
            Random generator = new Random();
            string choice;
            bool done = false;

            Console.WriteLine("Hello and Welcome to the List of Integers!");
            Console.WriteLine("Here's your list of Random Integers:");
            Console.WriteLine();

            for (int i = 0; i < 25; i++)
            {
                numbers.Add(generator.Next(10, 21));
                Console.Write(numbers[i]);
            }
            while (!done)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("What would you like to do with it?");
                Console.WriteLine();
                Console.WriteLine("1 - Sort List");
                Console.WriteLine("2 - Make New List");
                Console.WriteLine("3 - Remove Numbers");
                Console.WriteLine("4 - Add Numbers");
                Console.WriteLine("5 - Count a Number");
                Console.WriteLine("6 - Print Large Number");
                Console.WriteLine("7 - Print Small Nunber");
                Console.WriteLine("8 - Add and Average");
                Console.WriteLine("9 - Quit");
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1" || choice == "sort list")
                {
                    numbers.Sort();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        Console.WriteLine();
                        Console.Write(numbers[i]);
                    }
                    Console.WriteLine("Done!");
                }
                
                else if (choice == "2" || choice == "make new list")
                {

                }

                else if (choice == "3" || choice == "remove numbers")
                {

                }

                else if (choice == "4" || choice == "add numbers")
                {

                }
            }
            
        }
        public static void StringList()
        {
            List<string> vegetables = new List<string>() {"Carrot", "Beet", "Celery", "Radish", "Cabbage"};
        }
        static void Main(string[] args)
        {
            string choice = "";
            bool quit = false;

            while (quit != true)
            {
                Console.Clear();
                Console.WriteLine("Welcome back, once again, the most copy-and-paste menu ever.");
                Console.WriteLine("Only got two (not including the quit option) options this time.");
                Console.WriteLine("Please select what you'd like to do:");
                Console.WriteLine();
                Console.WriteLine("1 - List of Int");
                Console.WriteLine("2 - List of Strings");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "list of int" || choice == "1")
                {
                    IntList();
                    Console.WriteLine("Press ENTER to continue:");
                    Console.ReadLine();
                }

                else if (choice == "list of strings" || choice == "2")
                {
                    StringList();
                    Console.WriteLine("Press ENTER to continue:");
                    Console.ReadLine();
                } 

                else if (choice == "quit" || choice == "q")
                {
                    quit = true;
                    Console.WriteLine("Alright, see ya!");
                }

                else
                {
                    Console.WriteLine("Invalid Option. Please press ENTER to continue:");
                    Console.ReadLine();
                }
            }
        }
    }
}
