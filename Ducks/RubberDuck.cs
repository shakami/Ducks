using System;

namespace Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            Actions.Add("squeak");
            ActionMethods.Add(Squeak);
        }

        public string Squeak()
        {
            return " (o< (sqeak!)\n" +
                   "< _)";
        }

        public override string Display()
        {
            return "This is a rubber duck!";
        }
    }
}
