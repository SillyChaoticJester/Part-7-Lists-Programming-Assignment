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
            int sum = 0, userAdd = 0, userCount, userRemove, countAmount = 0;
            decimal average = 0M;
            bool done = false;

            Console.WriteLine("Hello and Welcome to the List of Integers!");
            
            while (!done)
            {
                Console.WriteLine("Here's your list of Random Integers:");
                Console.WriteLine();

                for (int i = 0; i < 25; i++)
                {
                    numbers.Add(generator.Next(10, 21));
                    Console.Write(numbers[i] + " ");
                }
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
                    for (int i = 0; i < 25; i++)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Done!");
                    Console.WriteLine("Press ENTER to continue:");
                    Console.ReadLine();
                }
                
                else if (choice == "2" || choice == "make new list")
                {
                    numbers.Clear();
                    for (int i = 0; i < 25; i++)
                    {
                        numbers.Insert(i, generator.Next(10, 21));
                        Console.Write(numbers[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Done!");
                    Console.WriteLine("Press ENTER to continue:");
                    Console.ReadLine();
                }

                else if (choice == "3" || choice == "remove numbers")
                {
                    Console.WriteLine("Which value from the list (10-20) would you like to get rid of?");
                    while (!Int32.TryParse(Console.ReadLine(), out userRemove))
                            Console.WriteLine("Invalid Integer, please try again:");
                    if (userRemove > 20 || userRemove < 10)
                    {
                        Console.WriteLine("That's not a number within the list, please try again:");
                        while (!Int32.TryParse(Console.ReadLine(), out userRemove)) ;
                        Console.WriteLine("Invalid Integer, please try again:");
                    }
                    for (int i = 0; i < 25; i++)
                    {
                        if (numbers.Contains(userRemove));
                        {
                            numbers.Remove(userRemove);
                        }
                    }
                    Console.WriteLine("Done!");
                    Console.WriteLine("Press ENTER to continue:");
                    Console.ReadLine();
                }

                else if (choice == "4" || choice == "add numbers")
                {
                    Console.WriteLine("What number would you like to add to the list?");
                    while (!Int32.TryParse(Console.ReadLine(), out userAdd));
                    {
                        Console.WriteLine("Invalid Integer, please try again:");
                    }
                    numbers.Add(userAdd);
                    Console.WriteLine("Done!");
                    Console.WriteLine("Press ENTER to continue:");
                    Console.ReadLine();
                }

                else if (choice == "5" || choice == "count a number")
                {
                    Console.WriteLine("What number (from 10-20) would you like to count for?");
                    while (!Int32.TryParse(Console.ReadLine(), out userCount));
                        Console.WriteLine("Invalid Integer, please try again:");
                    if (userCount > 20 || userCount < 10)
                    {
                        Console.WriteLine("That's not a number within the list, please try again:");
                        while (!Int32.TryParse(Console.ReadLine(), out userCount)) ;
                            Console.WriteLine("Invalid Integer, please try again:");
                    }
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers.Contains(userAdd));
                        {
                            countAmount++;
                        }
                    }
                    Console.WriteLine($"There was {countAmount} {userCount} in the List!");
                    Console.WriteLine("Press ENTER to continue:");
                    Console.ReadLine();
                }

                else if (choice == "6" || choice == "print large number")
                {
                    Console.WriteLine(numbers.Max());
                    Console.WriteLine("Done!");
                    Console.WriteLine("Press ENTER to continue:");
                    Console.ReadLine();
                }

                else if (choice == "7" || choice == "print small number")
                {
                    Console.WriteLine(numbers.Min());
                    Console.WriteLine("Done!");
                    Console.WriteLine("Press ENTER to continue:");
                    Console.ReadLine();
                }

                else if (choice == "8" || choice == "add and average")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }
                    average = sum / numbers.Count;
                    Console.WriteLine($"The Sum of the List would be {sum}");
                    Console.WriteLine($"And the Average of the List would be {Math.Round(average)}");
                    Console.WriteLine("Press ENTER to continue:");
                    Console.ReadLine();
                }

                else if (choice == "9" || choice == "quit")
                {
                    done = true;
                    Console.WriteLine("Alright, see ya!");
                    Console.WriteLine();
                }
            }
            
        }
        public static void StringList()
        {
            List<string> vegetables = new List<string>() {"Carrot", "Beet", "Celery", "Radish", "Cabbage"};
            string choice, userSearch, userAdd, valueRemove;
            int indexRemove, count = 0, searchFound = 0;
            bool done = false;

            Console.WriteLine("Hello and Welcome to the List of Strings!");

            while (!done)
            {
                Console.WriteLine("Here's a List of Vegetables:");
                Console.WriteLine();
                Console.WriteLine("Vegetables:");

                for (int i = 0; i < 25; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{i} - {vegetables[i].ToUpper()}");

                }
                Console.WriteLine();
                Console.WriteLine("What would you like to do with it?");
                Console.WriteLine();
                Console.WriteLine("1 - Sort List");
                Console.WriteLine("2 - Remove Vegetable (Index)");
                Console.WriteLine("3 - Remove Vegetable (Value)");
                Console.WriteLine("4 - Add Vegetable");
                Console.WriteLine("5 - Search for Vegetable");
                Console.WriteLine("6 - Clear List");
                Console.WriteLine("7 - Quit");
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1" || choice == "sort list")
                {
                    vegetables.Sort();
                    for (int i = 0; i < vegetables.Count; i++)
                    {
                        Console.WriteLine();
                        Console.Write(vegetables[i]);
                    }
                    Console.WriteLine("Done!");
                    Console.WriteLine("Press ENTER to continue:");
                    Console.ReadLine();
                }

                else if (choice == "2")
                {
                    Console.WriteLine("Which Index would you like to Remove?");
                    Console.WriteLine("(Hint: It MUST be the number of the Vegetable, and NOT the name itself.)");
                    Console.WriteLine();
                    while (!Int32.TryParse(Console.ReadLine(), out indexRemove))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Integer. Please Try Again:");
                    }
                    while (indexRemove > vegetables.Count || indexRemove < 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Index chosen cannot be less than or greater than the amount that is in the list.");
                        Console.WriteLine("Please Try Again:");
                        while (!Int32.TryParse(Console.ReadLine(), out indexRemove))
                            Console.WriteLine("Invalid Integer. Please Try Again:");
                    }
                    vegetables.RemoveAt(indexRemove);
                    Console.WriteLine();
                    Console.WriteLine("Done!");
                    Console.WriteLine("Press ENTER to continue:");
                    Console.ReadLine();
                }

                else if (choice == "3")
                {
                    Console.WriteLine("Which Value would you like to Remove?");
                    Console.WriteLine("(Hint: It MUST be the name of the Vegetable, and NOT the number.)");
                    valueRemove = Console.ReadLine().ToUpper().Trim();
                    if (vegetables.Contains(valueRemove))
                    {
                        vegetables.Remove(valueRemove);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("That doesn't exist in the list!");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Done!");
                    Console.WriteLine("Press ENTER to continue:");
                    Console.ReadLine();
                }

                else if (choice == "4" || choice == "add vegetable")
                {
                    Console.WriteLine("What type of Vegetable would you like to add?");
                    Console.WriteLine("If you type something that ISN'T a Vegetable... why would you do that?");
                    userAdd = Console.ReadLine().ToUpper().Trim();

                    vegetables.Add(userAdd);

                    Console.WriteLine();
                    Console.WriteLine("Done!");
                    Console.WriteLine("Press ENTER to continue:");
                    Console.ReadLine();
                }

                else if (choice == "5" || choice == "search for vegetable")
                {
                    Console.WriteLine("What vegetable would you like to count for?");
                    userSearch = Console.ReadLine().ToUpper().Trim();

                    for (int i = 0; i < vegetables.Count; i++)
                    {
                        if (vegetables.Contains(userSearch))
                        {
                            count++;
                            searchFound = i;
                        }
                    }
                    if (count > 0)
                    {
                        Console.WriteLine($"There was {count} {userSearch}(s), and its index is {searchFound}");
                    }
                    else
                    {
                        Console.WriteLine($"There wasn't any {userSearch} in the List!");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Press ENTER to continue:");
                    Console.ReadLine();
                }

                else if (choice == "6" || choice == "clear list")
                {
                    vegetables.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Done!");
                    Console.WriteLine("Press ENTER to continue:");
                    Console.ReadLine();
                }

                else if (choice == "7" || choice == "quit")
                {
                    done = true;
                    Console.WriteLine("Alright, see ya!");
                    Console.WriteLine();
                }
            }
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
