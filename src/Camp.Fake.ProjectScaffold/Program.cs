using System;

namespace Camp.Fake.ProjectScaffold
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var num = Library.hello(42);
            Console.WriteLine("{0}", num);
            Console.ReadLine();
        }
    }
}