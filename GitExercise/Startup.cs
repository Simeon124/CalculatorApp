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
                if(IsAuthenticated())
                {
                    Console.WriteLine("Console Calculator App");
                    Console.WriteLine(new string('-', 15));

                    Console.Write("a = ");
                    double a = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                    Console.Write("b = ");
                    double b = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                    
                    Console.WriteLine("Choose one from the listed options:");
                    foreach (string option in OptionsManager.OptionsList)
                    {
                        Console.WriteLine($"\t{option}");
                    }

                    Console.Write("Option: ");
                    string choice = Console.ReadLine();
                    
                    switch (choice)
                    {
                        case "a":
                            OptionsManager.Add(a, b);
                            break;
                        case "s":
                            OptionsManager.Subtract(a, b);
                            break;
                        case "m":
                            OptionsManager.Multiply(a, b);
                            break;
                        case "d":
                            OptionsManager.Divide(a, b);
                            break;
                        case "dr":
                            OptionsManager.Add(a, b);
                            break;
                            Console.Clear();
                            Console.WriteLine("Goodbye");
                            Console.ReadKey(true);
                            return;
                        case "sabs":
                            OptionsManager.SubtractAbs(a, b);
                            break;
                    }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey(true);
                }
            }
            
        }
    }
}
