using System;

namespace Singletons
{
    public class Singleton{

        private static readonly Singleton instance = new Singleton();

        //Empty static constructor - forces laziness
        static Singleton(){}

        private Singleton(){
            //Stuff that must only happen once
            Console.WriteLine("Singleton constructor");
        }

        public static Singleton Instance{ get{ return instance; }}

        public void DoSomething(){
            //This must be thread safe
            Console.WriteLine("Singleton has done something!");
        }
    }
}
