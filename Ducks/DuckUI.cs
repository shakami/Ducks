using System;

namespace Ducks
{
    enum DuckTypes
    {
        RedHead = 1,
        Mallard,
        Rubber,
        Decoy
    }

    class DuckUI
    {
        public void Run()
        {
            DisplayHeader();

            while (true)
            {
                Console.WriteLine("Select one of these options:");
                Console.WriteLine("1. Red Head Duck\n" +
                                  "2. Mallard Duck\n" +
                                  "3. Rubber Duck\n" +
                                  "4. Decoy Duck\n" +
                                  "0. Exit");

                var input = Common.GetNumericInput();

                var duck = ProcessDuck(input);

                if (duck != null)
                {
                    string result = null;
                    while (result == null)
                    {
                        result = TakeAction(duck);
                    }
                    Console.WriteLine(result);

                    WaitForUserToContinue();
                }
            }
        }

        private static Duck ProcessDuck(int input)
        {
            switch (input)
            {
                case (int)DuckTypes.RedHead:
                    return new RedHeadDuck();
                case (int)DuckTypes.Mallard:
                    return new MallardDuck();
                case (int)DuckTypes.Rubber:
                    return new RubberDuck();
                case (int)DuckTypes.Decoy:
                    return new DecoyDuck();
                case 0:
                    Console.WriteLine("goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }
            return null;
        }

        private static string TakeAction(Duck duck)
        {
            DisplayPossibleActions(duck);

            var input = Common.GetNumericInput();

            if (input > duck.Actions.Count || input < 1)
            {
                Console.WriteLine("invalid input");
                return null;
            }

            return duck.ActionMethods[input - 1]();
        }

        private static void DisplayPossibleActions(Duck duck)
        {
            Console.WriteLine("Select one of these options:");
            for (int i = 0; i < duck.Actions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {duck.Actions[i]}");
            }
        }

        private static void WaitForUserToContinue()
        {
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void DisplayHeader()
        {
            Console.WriteLine("______________\n" +
                              "|            |\n" +
                              "|Duck Program|\n" +
                              "|____________|\n\n");
        }
    }
}
