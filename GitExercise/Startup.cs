using System;

namespace GitExercise
{
    public class Startup
    {
        private const string _pass = "abcd1234";

        public static bool IsAuthenticated()
        {
            Console.Write("Enter password to authenticate: ");
            string input = Console.ReadLine();

            return input == _pass;
        }

        public static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Console Calculator App");
                Console.WriteLine(new string('-', 15));
                Console.Write("a = ");

                foreach (var opt in OptionsManager.OptionsList)
                    Console.WriteLine(opt);


                Console.Write("\nChoice = ");
                string choice = (Console.ReadLine() ?? "").ToLower();

                if (choice == "ex")
                {
                    Console.Clear();
                    Console.WriteLine("Goodbye");
                    Console.ReadKey(true);
                    return;
                }

                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                switch (choice)
                {
                    case "a":
                        OptionsManager.Add(a, b);
                        break;
                    case "s":
                        OptionsManager.Add(a, b);
                        break;
                    case "m":
                        OptionsManager.Add(a, b);
                        break;
                    case "dr":
                        OptionsManager.Add(a, b);
                        break;
                        Console.Clear();
                        Console.WriteLine("Goodbye");
                        Console.ReadKey(true);
                        return;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
            }
        }
    }
}
