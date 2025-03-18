namespace Part_7_Lists_Programming_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Random generator = new Random();
            string choice = "";
            bool quit = false;

            for (int i = 0; i < 25; i++)
            {
                numbers.Add(generator.Next(10, 21));
            }
        }
    }
}
