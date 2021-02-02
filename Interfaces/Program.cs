using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interfaces!");
            License license = new License(new DateTime(2000, 1, 1, 0, 0, 0));
            Console.WriteLine(license.HasExpired);

            License license2 = new License(new DateTime(2030, 1, 1, 0, 0, 0));
            Console.WriteLine(license2.HasExpired);
        }
    }
}
