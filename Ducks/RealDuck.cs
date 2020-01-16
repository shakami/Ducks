using System;

namespace Ducks
{
    public abstract class RealDuck : Duck
    {
        public RealDuck()
        {
            Actions.Add("quack");
            ActionMethods.Add(Quack);
            Actions.Add("fly");
            ActionMethods.Add(Fly);
        }

        public string Quack()
        {
            return " (o< (quack!)\n" +
                   "< _)";
        }

        public string Fly()
        {
            return "Here's some ducks flying!\n" +
                   "  _      _      _\n" +
                   ">(.)__ <(.)__ =(.)__\n" +
                   " (___ / (___ / (___ / ";
        }

        public override string Display()
        {
            return "This is a real duck!";
        }
    }
}
