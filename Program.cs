// Jeremy Gallen's program to demonstrate delegates

// Overall namespace
namespace Delegates
{
    // Main class
    public class TestDelegate
    {
        // Delegate with no parameters or return type
        public delegate void FirstDelegate();

        // First function
        public void function1()
        {
            Console.WriteLine("This is the first function.");
        }

        // Second function
        public void function2()
        {
            Console.WriteLine("This is the second function.");
        }

        // Third function
        public void function3()
        {
            Console.WriteLine("This is the third function.");
        }

        // Main method
        static void Main(string[] args)
        {
            TestDelegate testdelegate = new TestDelegate();

            // Instantiation
            TestDelegate.FirstDelegate fd1 = new TestDelegate.FirstDelegate(testdelegate.function1);
            TestDelegate.FirstDelegate fd2 = new TestDelegate.FirstDelegate(testdelegate.function2);
            TestDelegate.FirstDelegate fd3 = new TestDelegate.FirstDelegate(testdelegate.function3);

            // Invocation
            fd1();
            fd2();
            fd3();
        }
    }
}