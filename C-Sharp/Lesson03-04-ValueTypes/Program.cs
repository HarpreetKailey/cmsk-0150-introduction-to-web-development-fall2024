using System;

namespace Module1.Lesson3and4.ValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Types and variables
            //

            // Type -> A type defines the structure and behavior of any data in C#. 
            // Variable -> A variable is a label that refers to an instance of a 
            // specific type.

            // Defining variables and types
            //
            //      <type> <variable>;
            //
            //      int age;
            //      string name;
            //      PersonClassType person;

            //SimpleTypes();
            //Tuples();
        }

        // ///////////////////////////////////////////////////////////////////////
        //
        // Value types and reference types
        //
        // Value types and reference types are the two main categories of C# types. 
        // A variable of a value type contains an instance of the type. 
        // This differs from a variable of a reference type, which contains a 
        // reference to an instance of the type. 

        // ///////////////////////////////////////////////////////////////////////
        //
        // Value Types
        //
        //   Simple Types : short, int, long, decimal, etc
        //                : char, bool, byte
        //   Enum
        //   Struct
        //   Tuple

        static void SimpleTypes()
        {

            int age = 2;
            double price = 10.25;
            var total = age * price;

            Console.WriteLine(total);
            // output
            //
            // 20.5

            bool isAdult = default;
            Console.WriteLine(isAdult);
            // output
            //
            // false

        }

    }
}
