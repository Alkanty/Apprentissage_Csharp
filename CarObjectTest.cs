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
    //COMMENT OF METHOD CAPITAL LETTER COMMENT OF CODE LOWERCASE
    // {} JUMP A LIGNE AFTER LINKED CLASS/METHOD/LOOP BUT SAME LEVEL +
    // INDENTING AFTER {}
    // CONDITION EXCEPTION(switch,if,) : ALL ON ONE LINE

    public class InstanceObject()
    {
        public static void InstanceObjectNow()
               { 
  
                CarObjectTest car1 = new CarObjectTest("408","Peugeot",2020);
                car1.GetCarInfo();
              }

    }
    

    class CarObjectTest
    {
        //FIELDS THAT ARE PUBLIC (NOT SAFE) OF MY OBJECT CAROBJECTTEST
        public string carname;
        public string carconstructor;
        public int caryear;
        public int caractualspeed;
        public int carmaxspeed;
        public bool carengineon;

        //CONSTRUCTOR : SPECIAL METHOD THAT IS CREATED BY DEFAULT IF NO CREATED : KEEPS THE SAME NAME AS THE CLASS IT IS ATTACH TO : USED TO ASSIGN ARGUMENT TO FIELDS
        public CarObjectTest(string carname,string carconstructor,int caryear)
        {
            //the "this" links the different fields to the requested parameters  
            this.carname = carname;
            this.carconstructor = carconstructor;
            this.caryear = caryear;

        }


        //METHODS OF MY OBJECT CAR OBJECTTEST
        public void GetCarInfo()
        {
            Console.WriteLine($"car is a {carname} from {carconstructor} \n it has been made in {caryear} ");

        }
        
        public void RaiseSpeed()
        {
            if (carengineon == true) { caractualspeed = 30; Console.WriteLine($"car is speeding towards {caractualspeed} km/h)"); }
            else
            {
                Console.WriteLine("engine need to be started first");


            }

        }
    }
}
