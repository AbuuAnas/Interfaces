using System;

namespace Interfaces
{
    class Program
    {
        //interfaces are much like abstract classes
        //in that they can not be instantiated and must be inherited

        //they can only contain methods with no bodies
        //they can not contain fields but can contain properties

        //they can not have static members
        //when a child class inherits an interface,
        //we say that implements the interface

        //one of the key differences between an abstract class and an interface is that
        //class can only inherit one abstract class but can implement multiple interface

        //it is common to start the name of an interface with the letter I
        //All properties and methods in an interface are public,
        //so there is no need to add any access modifiers to them

        interface IShape
        {
            int MyNumber { get; set; }

            void InterfaceMethod();
        }

        class ClassA : IShape
        {
            private int myNUmber;

            public int MyNumber
            {
                get { return myNUmber; }
                set
                {
                    if (value < 0)
                        myNUmber = 0;
                    else
                    {
                        myNUmber = value;
                    }
                }

            }

            public void InterfaceMethod()
            {
                Console.WriteLine("The number is {0}.", MyNumber);
            }
        }

        static void Main(string[] args)
        {
            ClassA a = new ClassA();
            a.MyNumber = 5;
            a.InterfaceMethod();
            Console.ReadKey();
        }
    }
}

