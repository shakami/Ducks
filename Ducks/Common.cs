using System;

namespace Ducks
{
    public static class Common
    {
        public static int GetNumericInput()
        {
            char input = ' ';
            while (!char.IsNumber(input))
            {
                Console.WriteLine("please enter a number");
                input = Console.ReadKey().KeyChar;
                Console.Write("\n");
            }

            return (int)char.GetNumericValue(input);
        }
    }
}
