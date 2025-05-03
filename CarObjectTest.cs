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

    class CarObjectTest
    {
        string carname;
        string carconstructor;
        int caryear;
        int carspeed;
        bool carengineon;

        void GetCarInfo()
        {
            Console.WriteLine($"car is a {carname} from {carconstructor} \n it has been made in {caryear} ");

        }
        
        void RaiseSpeed()
        {
            if (carengineon == true) { carspeed = 30; Console.WriteLine($"car is speeding towards {carspeed} km/h)"); }
            else
            {
                Console.WriteLine("engine need to be started first");


            }

        }
    }
}
