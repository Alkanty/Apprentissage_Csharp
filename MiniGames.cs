using System;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Threading.Tasks.Dataflow;
using Apprentissage_Csharp;

namespace MiFirstPrograms
{

    ////NOMENCLATURE////
    //NAMESPACE + CLASS + METHOD = PASCAL CASE
    // VARIABLE = LOWER CASE
    // COMMENT ALWAYS ON ONE LINE : BRIEF IN ONE SENTENCE ON TOP OF THE ELEMENT DESCRIBE
    //COMMENT OF METHOD CAPITAL LETTER COMMENT OF CODE LOWERCASE
    // {} JUMP A LIGNE AFTER LINKED CLASS/METHOD/LOOP BUT SAME LEVEL +
    // INDENTING AFTER {}
    // CONDITION EXCEPTION(switch,if,) : ALL ON ONE LINE

    class MiniGames
    {
        static void Main(string[] args)
        {
            ArrayInC.ArrayExo2();
        }
        static void RockPaperScissor()
        {

            bool gamestart = true;


            while (gamestart == true)
            {
                //INIT VAR
                Console.WriteLine($"welcome to rock.paper.scissor ! the one who manage to reach 3 points win ");
                int computerpoint = 0;
                int playerpoint = 0;

                for (; playerpoint < 3;)
                {
                    for (; computerpoint < 3;)
                    {


                        //DISPLAY POIN
                        Console.WriteLine($"player has {playerpoint} and computer has {computerpoint} points");

                        //CHOICE OF THE PLAYER
                        Console.WriteLine("choose /rock/paper/scissor ? ");
                        string playerchoice = Console.ReadLine();
                        switch (playerchoice)
                        {
                            case "rock": playerchoice = "1"; Convert.ToInt32(playerchoice); break;
                            case "paper": playerchoice = "2"; Convert.ToInt32(playerchoice); break;
                            case "scissor": playerchoice = "3"; Convert.ToInt32(playerchoice); break;
                            default: playerchoice = "1"; Convert.ToInt32(playerchoice); break;
                        }
                        //CHOICE OF THE COMPUTER
                        Random random = new Random();
                        int computerchoice = Convert.ToInt32(random.Next(1, 4));
                        Console.WriteLine("the computer is choosing...");
                        Thread.Sleep(2000);
                        if (computerchoice == 1) { Console.WriteLine("rock !!"); }
                        else if (computerchoice == 2) { Console.WriteLine("paper !!"); }
                        else if (computerchoice == 3) { Console.WriteLine("scissor !!"); }

                        //CREATION OF A COMPARATIVE DIC
                        int[] TableauComparatif = new int[] { Convert.ToInt32(playerchoice), computerchoice };

                        //RESOLUTION

                        if (TableauComparatif[0] == TableauComparatif[1]) { Console.WriteLine("Equal match, no point is allocated "); }
                        else if (TableauComparatif[0] == 1 && TableauComparatif[1] == 3) { Console.WriteLine("Rock win over scissor, you have won a point"); playerpoint += 1; }
                        else if (TableauComparatif[0] == 1 && TableauComparatif[1] == 2) { Console.WriteLine("Rock loose over over paper, computer has won a point"); computerpoint += 1; }
                        else if (TableauComparatif[0] == 2 && TableauComparatif[1] == 1) { Console.WriteLine("Paper win over rock, you have won a point"); playerpoint += 1; }
                        else if (TableauComparatif[0] == 2 && TableauComparatif[1] == 3) { Console.WriteLine("Paper loose over scissor, computer has won a point"); computerpoint += 1; }
                        else if (TableauComparatif[0] == 3 && TableauComparatif[1] == 2) { Console.WriteLine("scissor win over paper, you have won a point"); playerpoint += 1; }
                        else if (TableauComparatif[0] == 3 && TableauComparatif[1] == 1) { Console.WriteLine("scissor loose over rock, computer has won a point"); computerpoint += 1; }



                    }
                    if (computerpoint == 3) break;
                }

            }

        }
        static void GuessingNumber()
        {
            //INIT VAR
            Random random = new Random();
            int computerchoice = random.Next(1, 101);
            int playerchoice;
            int playertries;
            string continuegame = "yes";

            //LOOP FOR EXITING GAME
            while (continuegame == "yes")
            {
                Console.WriteLine("Welcome to GuessingNumberGame ! the computer has chosen a number from 1 to 100, try to guess it ! ");
                // LOOP FOR COUNTING PLAYER TRIES
                for (playertries = 0; playertries < 10; playertries++)
                {

                    //COMPARAISON 
                    playerchoice = Convert.ToInt32(Console.ReadLine());
                    if (playerchoice > computerchoice) { Console.WriteLine("Lower"); }
                    else if (playerchoice < computerchoice) { Console.WriteLine("Higher"); }
                    else if (playerchoice == computerchoice) { Console.WriteLine($"You found it in {playertries} tries ! welldone "); break; }
                }
                Console.WriteLine("do you want to continue ? yes or no ! ");
                continuegame = Console.ReadLine();
            }
        }
        public static void RandomNumber()
        {


            //init de la variable de jeu
            string proceedprog = "yes";

            //boucle de demarrage du jeu
            while (proceedprog == "yes")
            {
                //init de la partie en cours
                string proceedgame = "yes";

                //init du numéro aléatoire
                Random random = new Random();
                int randomnumber = random.Next(1, 100);

                //init du numéro utilisateur
                int guessednumber;

                Console.WriteLine("Welcole to the GuessNumber game ! a number from 1 to 100 has been chosen, you have to guess it ! ");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("guess the number");
                    guessednumber = Convert.ToInt32(Console.ReadLine());
                    if (guessednumber > randomnumber)
                    { Console.WriteLine("lower, you want to continue ? "); }
                    else if (guessednumber < randomnumber)
                    { Console.WriteLine("Higher, you want to continue ?"); }
                    else if (guessednumber == randomnumber)
                    { Console.WriteLine($"You got it !! the number was {randomnumber} you used {i} round to guess it"); break; }
                }
                Console.WriteLine("you want to launch an other game ? ");
                proceedprog = Console.ReadLine();
            }
        }
        public static void Calculator()
        {

            double operation;
            string proceedprog = "yes";

            while (proceedprog == "yes")
            {


                Console.WriteLine("Welcome to the calculator");

                // INIT NUMBER

                Console.WriteLine("Enter Number 1");
                double calcnumber1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Number 2");
                double calcnumber2 = Convert.ToDouble(Console.ReadLine());

                string calcoperator = "/";

                while (calcoperator == "/" || calcoperator == "+" || calcoperator == "-" || calcoperator == "*")
                {
                    Console.WriteLine("Enter calcoperator (/ or * or + or -)");
                    calcoperator = Console.ReadLine();



                    switch (calcoperator)
                    {
                        case "/": operation = calcnumber1 / calcnumber2; Console.WriteLine($"{calcnumber1} {calcoperator} {calcnumber2} = {operation}"); break;
                        case "+": operation = calcnumber1 + calcnumber2; Console.WriteLine($"{calcnumber1} {calcoperator} {calcnumber2} = {operation}"); break;
                        case "-": operation = calcnumber1 - calcnumber2; Console.WriteLine($"{calcnumber1} {calcoperator} {calcnumber2} = {operation}"); break;
                        case "*": operation = calcnumber1 * calcnumber2; Console.WriteLine($"{calcnumber1} {calcoperator} {calcnumber2} = {operation}"); break;
                    }
                    break;

                }
                Console.WriteLine("would you wish to continue ? yes/no");
                proceedprog = Console.ReadLine();
            }


        }
    }
}    

    



