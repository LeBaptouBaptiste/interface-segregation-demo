namespace Interface_Segregation_Demo.Models
{
    // A single, large interface that forces every class
    // to implement ALL behaviors, even if they don't apply.
    // This violates the Interface Segregation Principle (ISP).
    interface IWorker
    {
        void Eat();
        void Work();
        void Sleep();
    }

    // This class technically works fine because a human
    // really does all three actions. The problem is not here.
    // The problem comes when another class doesn't need all behaviors.
    class BadHumanWorker : IWorker
    {
        public void Eat() { Console.WriteLine("I eat!"); }
        public void Work() { Console.WriteLine("I work!"); }
        public void Sleep() { Console.WriteLine("I sleep!"); }
    }

    // This class clearly shows why the interface is badly designed.
    // A robot does not eat and does not sleep,
    // yet it is FORCED to implement those methods.
    // This results in exceptions and useless code.
    class BadRobotWorker : IWorker
    {
        public void Work() { Console.WriteLine("Robot working!"); }

        // These two methods make no sense for a robot.
        // They only exist because the interface is too large.
        public void Sleep() { throw new NotImplementedException(); }
        public void Eat() { throw new NotImplementedException(); }
    }
}
