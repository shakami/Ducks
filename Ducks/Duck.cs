using System;
using System.Collections.Generic;

namespace Ducks
{
    public abstract class Duck
    {
        public List<string> Actions;
        public List<Func<string>> ActionMethods;

        public Duck()
        {
            Actions = new List<string>
            {
                "swim",
                "display"
            };

            ActionMethods = new List<Func<string>>
            {
                Swim,
                Display
            };
        }

        public string Swim()
        {
            return "Here's some ducks swimming!\n" +
                   "   _          _          _\n" +
                   " >(')____,  >(')____,  >(')____,\n" +
                   "   (` = ~~/  (` = ~~/   (` = ~~/\n" +
                   "~^~^`---'~^~^~^`---'~^~^~^`---'~^";
        }

        public abstract string Display();
    }
}
