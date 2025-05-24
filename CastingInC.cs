using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Apprentissage_Csharp
{
    public class CastingInC
    {

        public static void CastingAndConversionExo2()
        {
            // Replace the code comments in the starter code with your own code to solve the challenge:

            // Solve for result1: Divide value1 by value2, display the result as an int
            // Solve for result2: Divide value2 by value3, display the result as a decimal
            // Solve for result3: Divide value3 by value1, display the result as a float
            
            //OUTPUT    
            //Divide value1 by value2, display the result as an int: 2
            //Divide value2 by value3, display the result as a decimal: 1.4418604651162790697674418605
            //Divide value3 by value1, display the result as a float: 0.3909091

                        int value1 = 11;
                        decimal value2 = 6.2m;
                        float value3 = 4.3f;

            // Your code here to set result1
            // Hint: You need to round the result to nearest integer (don't just truncate)
            int result1 = Convert.ToInt32(value1 / value2);
            Console.WriteLine($"Divide {value1} by {value2}, display the result as an int: {result1}");

            // Your code here to set result2
            decimal result2 =  value2 / Convert.ToDecimal(value3);
            Console.WriteLine($"Divide {value2} by {value3}, display the result as a decimal: {result2}");

            // Your code here to set result3
            float result3 =  value3 / value1 ;
            Console.WriteLine($"Divide {value3} by {value1}, display the result as a float: {result3}");



        }


        public static void CastingAndConversionExo1()
        {

            //  Create a looping structure that can be used to iterate through each string value in the array values.
            //  https://learn.microsoft.com/en-us/training/modules/csharp-convert-cast/4-challenge
            // Rule 1: If the value is alphabetical, concatenate it to form a message.
            //Rule 2: If the value is numeric, add it to the total. 
            //Rule 3: The result should match the following output: Message: ABCDEF Total: 68.3

            string[] values = { "12,3", "45", "ABC", "11", "DEF" };
            float numberadd = 0;
            string wordadd = "";


            foreach (string value in values)

            {
                if (float.TryParse(value, out float result))
                {
                    Console.WriteLine("DEBUG:adding it to the rest of the numbers");
                    numberadd += result;
                }
                else
                {
                    Console.WriteLine("DEBUG: adding it to the rest of the words");
                    wordadd += value;
                }
            }
            Console.WriteLine($"Message:{wordadd} \nTotal :{numberadd}");


        }


        public static void CastingAndConversion()
        { 
            //int first = 2;
            //string second = "4";
            //int result = first + Convert.ToInt16(second);        // Convert.class tha able to convert multiple format str to int
            //Console.WriteLine(result);                           // better for ROUNDING

            //decimal myDecimal = 3.14m;
            //Console.WriteLine($"decimal: {myDecimal}");             

            //int myInt = (int)myDecimal;                           // cast dec > int = trunk the number to only 3 . Narrowing conversion
            //Console.WriteLine($"int: {myInt}");                   // Casting is an instruction to the C# compiler that you know precision may be lost, but you're willing to accept it.
            // BEWARE OF THE TRUNCATED

            //string first1 = "5";
            //string second2 = "7";
            //int sum = int.Parse(first1) + int.Parse(second);      // Parse() method, which converts a string into the given data type. In this case
            //Console.WriteLine(sum);





            //string value = "102";                                   // Parse() If successful, it stores the converted value in an out paramete It returns a bool to indicate whether the action succeeded or failed
            //int result = 0;

            //if (int.TryParse(value, out result))
            //{
            //    Console.WriteLine($"Measurement: {result}");
            //}
            //else
            //{
            //    Console.WriteLine("Unable to report the measurement.");
            //}
            //Console.WriteLine($"Measurement (w/ offset): {50 + result}");

        }
        public static void ValueTypeLimit()
        {
            
            //TYPE VALUE (INT/FLOAT) store data in "STACK". allocate memory on the CPU, is erased when executed
            
            Console.WriteLine("Signed integral types:");

            Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

            Console.WriteLine("");
            Console.WriteLine("Unsigned integral types:");

            Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

            Console.WriteLine("");
            Console.WriteLine("Floating point types:");
            // binary type that are less precise than decimal but precise enough > use base 2
            Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            //more precise but use base 16 and use memory ! good for banking system
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

            //TYPE REFERENCE (STRING/ARRAY/CLASS) store data in "HEAP". the heap is shared between multiple app via the OS (use often "new" KEYWORD to create a new space in the HEAP)

            int[] data; // pointing to nothing = a null array
            int[] data2 = new int[10]; //The new keyword informs .NET Runtime to create an instance of int array, and then coordinate with the operating system to store the array sized for three int values in memory
            string shortenedString = "Hello World!"; // in background System.String is called to initialize in the HEAP
        }

    }
}
