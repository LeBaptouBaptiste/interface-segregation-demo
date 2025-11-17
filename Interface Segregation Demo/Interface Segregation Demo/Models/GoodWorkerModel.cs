namespace Interface_Segregation_Demo.Models
{
    // Interface representing the ability to eat.
    // A class implements it only if this behavior makes sense.
    interface IFeedable
    {
        void Eat();
    }

    // Interface representing the ability to work.
    // Separated so that no class is forced to use unrelated methods.
    interface IWorkable
    {
        void Work();
    }

    // Interface representing the ability to sleep.
    // Each interface focuses on a single responsibility.
    interface ISleepable
    {
        void Sleep();
    }

    // Example of a class that actually needs all three behaviors:
    // eating, working, sleeping.
    // It implements ONLY the interfaces that match its real capabilities.
    class GoodHumanWorker : IFeedable, IWorkable, ISleepable
    {
        public void Eat() { Console.WriteLine("I eat!"); }
        public void Work() { Console.WriteLine("I work!"); }
        public void Sleep() { Console.WriteLine("I sleep!"); }
    }

    // Example of a class that should NOT be forced to implement Eat() or Sleep().
    // A robot only needs to work, so it implements only the IWorkable interface.
    class GoodRobotWorker : IWorkable
    {
        public void Work() { Console.WriteLine("Robot working!"); }
    }

}
