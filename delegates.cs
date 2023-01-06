using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    // Declare a delegate type.
    delegate int Operation(int x, int y);
    public class delegates
    {

        public void delegatesE()
        {

            // Create an instance of the delegate that refers to the Add method.
            Operation op = Add;

            // Invoke the delegate.
            int result = op(3, 4);
            Console.WriteLine(result);  // Output: 7
        }

        // A method that matches the delegate's signature.
        static int Add(int x, int y) => x + y;

    }
    
}

    //In C#, a delegate is a type that represents a reference to a method. 
    //Delegates are used to pass methods as arguments to other methods, and to create event-handler methods.
