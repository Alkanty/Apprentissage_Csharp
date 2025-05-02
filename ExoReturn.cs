using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apprentissage_Csharp
{

    ////NOMENCLATURE////
    //NAMESPACE + CLASS + METHOD = PASCAL CASE
    // VARIABLE = LOWER CASE
    // COMMENT ALWAYS ON ONE LINE : BRIEF IN ONE SENTENCE ON TOP OF THE ELEMENT DESCRIBE
    // {} JUMP A LIGNE AFTER LINKED CLASS/METHOD/LOOP BUT SAME LEVEL +
    // INDENTING AFTER {}
    // CONDITION EXCEPTION(switch,if,) : ALL ON ONE LINE

    class ExoReturn
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose letters");
            string let1 = "A";
            string let2 = "B";
            string let3 = "C";



            Console.WriteLine($"hello my name is {NameGenerator(let1, let2, let3)}");

        }

        static string NameGenerator(params string[] letters)
        {
            //COUNT NUMBER OF PARAMETER
            var count = letters == null ? 0 : letters.Length;
            Console.WriteLine(count); //debug

            //CREATE EMPTY STRING VAR FOR THE NAME GEN
            string namegen = string.Empty;




            //LOOP FOR CREATING WORD BASED ON CHAR INPUT
            foreach (string letter in letters) 
            {

                //RANDOM LETTER POSITION GENERATOR
                Random random = new Random();
                int numgen = random.Next(count);

                namegen  += letters[numgen];
                Console.WriteLine(namegen);
            }

            return namegen;




        }


    }
    
}
