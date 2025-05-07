using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Apprentissage_Csharp
{
    public class ConfigTest
    {


        public static void CastingAndConversion()
        {
            int first = 2;
            string second = "4";
            int result = first + Convert.ToInt16(second);
            Console.WriteLine(result);

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
