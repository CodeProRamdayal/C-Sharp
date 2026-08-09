using System;
namespace Csharp_Tutorials.Opps
{
    public class DataType
    {
        /*
         A variable is a named memory location used to store data. Its value can change during program execution.
        What is a Data Type? A data type tells the compiler:What kind of data will be stored.
        How much memory to allocate.
        What operations are allowed.
       
        2.Categories of Data Types in C#
        There are three main categories:
        1.Value Types
        2.Reference Types
        3.Pointer Types (advanced/unsafe code)
       
        1. Value Types
        Value types store the actual value directly in memory.
        Examples:
        1.int
        2.double
        3.bool
        4.char
        5.decimal
        6.float
        7.long
        8.byte
        9.short
        | Data Type | Size             | Example |
| --------- | ---------------- | ------- |
| byte      | 1 byte           | 255     |
| short     | 2 bytes          | 1000    |
| int       | 4 bytes          | 500     |
| long      | 8 bytes          | 500000  |
| float     | 4 bytes          | 12.5f   |
| double    | 8 bytes          | 12.5    |
| decimal   | 16 bytes         | 12.5m   |
| char      | 2 bytes          | 'A'     |
| bool      | 1 byte (logical) | true    |

 2. Reference Types
        Reference types store a reference (address) to the actual object in memory.
        Examples:
        1.string
        2.object
        3.arrays
        4.classes
        5.interfaces
        6.delegates


           

         */
        public void display()
        {
            var numbers = 5;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "John";
            var isworking = true;
            Console.WriteLine("Hello, World!" + " " + numbers);
            Console.WriteLine("Total Price: " + totalPrice);
            Console.WriteLine("Character: " + character);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Is Working: " + isworking);
            Console.WriteLine("Count: " + count);
            try
            {
                int numberInput = 12346;
                byte convertByte = Convert.ToByte(numberInput);
                Console.WriteLine("Converted Byte: " + convertByte);
            }
            catch (Exception ex) { Console.WriteLine("Error: User cannot be converted from integer to byte :: " + ex.Message); }

        }
    }
}