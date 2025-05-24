using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apprentissage_Csharp
{
    public class ArrayInC
    {
        public static void ArrayinCsharp()
        {

            string[] pallets = ["B14", "A11", "B12", "A13"];

            Console.WriteLine("Sorted...");
            Array.Sort(pallets); //sort method class the array by alphanumerical order
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
            Console.WriteLine("");
            Console.WriteLine("Reversed...");
            Array.Reverse(pallets);  //reverse method class countrary
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");



            }

        }
        public static void ArrayExo1()
        {
            //The Array.Resize() method, on the other hand, allows you to add or remove elements from your array.

            string[] pallets = ["B14", "A11", "B12", "A13"];
            Console.WriteLine("");

            Array.Clear(pallets, 0, 2); // delete 2 array value starting at index [0] replace byu nothing (null) 
            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Array.Resize(ref pallets, 6); // increase the number of element from 4 to 6
            Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            pallets[4] = "C01";
            pallets[5] = "C02";

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Array.Resize(ref pallets, 3); // shrinking to 3
            Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
            //New array elements and cleared elements are null, meaning they don't point to a value in memory.


        }
        public static void ArrayExo2()
        {
            string value = "abc123";
            char[] valueArray = value.ToCharArray(); //ToCharArray() method is used to create an array of char, where each element of the array represents one character of the original string.
            Array.Reverse(valueArray);
            string result = new string(valueArray);
            Console.WriteLine(result);



        }
    }
}