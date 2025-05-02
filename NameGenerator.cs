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
    // {} JUMP A LIGNE AFTER LINKED CLASS/METHOD/LOOP/TRY BUT SAME LEVEL +
    // INDENTING AFTER {}
    // CONDITION EXCEPTION(switch,if,) : ALL ON ONE LINE

    static class NameGenerator
    {
        public static void CreateLetter()
        {


            char char1;
            char char2;
            char char3;

            while (true) 
            {

                try
                {
                    Console.WriteLine("choose letters number 1");
                    char1 = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("choose letters number 2");
                    char2 = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("choose letters number 3");
                    char3 = Convert.ToChar(Console.ReadLine());
                    break;
                }
                catch (Exception )
                { 
                   Console.WriteLine("must be letter only ! back to the beginning");                
                }
            }



            Console.WriteLine($"hello my name is {NameCompiler(char1, char2, char3)}");

        }

        static string NameCompiler(params char[] letters)
        {
            //COUNT NUMBER OF PARAMETER
            var count = letters == null ? 0 : letters.Length;
            Console.WriteLine(count); //debug

            //CREATE EMPTY STRING VAR FOR THE NAME GEN
            string namegen = string.Empty;

            int numberletter = 0;
            
            try
            {
                Console.WriteLine("choose number of letter you wish to generate");
                numberletter = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {

            }

            //LOOP FOR CREATING WORD BASED ON CHAR INPUT
            for (int i = 0; i < numberletter; i++) 
            {

                //RANDOM LETTER POSITION GENERATOR
                Random random = new Random();
                int numgen = random.Next(count);

                namegen += letters[numgen];
                Console.WriteLine(namegen);
            }

            return namegen;




        }


    }
    
}
