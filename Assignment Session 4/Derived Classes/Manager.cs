using Assignment_Session_4.Base_Classes;

namespace Assignment_Session_4.Derived_Classes
{
    internal class Manager : Employee
    {
        public override void Work()
        {
            base.Work();
            Console.WriteLine("Manager is managing");
        }
    }
}
