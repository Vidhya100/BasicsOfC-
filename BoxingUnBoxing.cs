using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    public class BoxingUnBoxing
    {
        public void Boxing()
        {
            int i = 42;
            object o = i;  // boxing

            // Now o is an object that contains the value 42.
            // We can perform any operations that are valid for objects on o.
            Console.WriteLine(o);

            // To retrieve the value from o, we need to unbox it back to an int.

            int j = (int)o;  // unboxing
            Console.WriteLine(j);

            // If we try to unbox o to a type that is incompatible with its original value,
            // a InvalidCastException will be thrown.
            try
            {
                double d = (double)o;  // unboxing
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    
}
/*
     In C#, boxing is the process of converting a value type to the object type. 
     This is done by creating a new object instance and copying the value into it.   

     Unboxing is the reverse process, in which the object type is converted back to a value type.
     This is done by extracting the value from the object.
    
    Boxing and unboxing are typically used when working with collections that are based on the object type, such as the ArrayList class. 
    They can also be used to pass value type parameters to methods that take object type arguments.

     boxing and unboxing can have a performance cost, as they involve creating and destroying objects.
    
 */
