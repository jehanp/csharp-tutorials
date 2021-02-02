using System;

namespace Singletons{
    
    public class MainClient{
        static void Main(string[] args) {
            Console.WriteLine("Singletons!");

            Singleton.Instance.DoSomething();
        }
    }
}