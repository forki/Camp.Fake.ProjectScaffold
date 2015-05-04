using System;

namespace Camp.Fake.ProjectScaffold.Client
{
    /// <summary> The main application, entry point for the console. </summary>
    internal class Program
    {
        /// <summary> The entry point for the console. </summary>
        private static void Main(string[] args)
        {
            var num = Library.Hello(42);
            Console.WriteLine("{0}", num);
            Console.ReadLine();
        }
    }
}