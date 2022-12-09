using System;

namespace Password_Generator
{
    class Program
    {
        static void Main()
        {
            string your_safe_word = ""; //Insert a safe word about yourself that nobody knows
            Console.WriteLine(Convert.ToString(new Random().Next(10, 25)) + $"{your_safe_word}_Car£4!2"); //Prints your safe password to output
        }
    }
}
