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
                CarObjectTest car2 = new CarObjectTest("R11", "Renault", 1998);
                car2.GetCarInfo();
                car2.RaiseSpeed(true);
                // Getting acces to the static class field carnumber
                Console.WriteLine(CarObjectTest.carnumber);
                

        }

    }

    // PARENT CLASS OF VEHICULE : GIVES HIS METHOD AND FIELD TO BE USED BY THE CHILDREN (INHERITANCE)
    // ABSTRACT CLASS : PROHIB THE ABILITY TO CALL THE  OBJECT CLASS AND METHOD THAT ARE LINKED TO IT, 
    abstract class VehiculeObjectTest() 
    {
        public int vehiculecurrentspeed ;
        public int vehiculemaxspeed = 200;
        bool vehiculecanfly ;
        bool vehiculecangoroad;
        bool vehiculecangowater;

    }


    //CANT CREATE OBJECT FROM A STATIC CLASS
    //CHILD CLASS OF CAR : INHERIT THE FIELDS FROM VEHICULE (INHERITANCE)
    class CarObjectTest : VehiculeObjectTest
    {
        //FIELDS THAT ARE PUBLIC (NOT SAFE) OF MY OBJECT CAROBJECTTEST
        string carname;
        string carconstructor;
        //the static field provides us with the ability to increment the variable without overiding each time a new instance of a class is made. it belong to the class and not the instance ! 
        public static int carnumber ;
        int caryear;
        bool carengineon;

        //CONSTRUCTOR : SPECIAL METHOD THAT IS CREATED BY DEFAULT IF NO CREATED : KEEPS THE SAME NAME AS THE CLASS IT IS ATTACH TO : USED TO ASSIGN ARGUMENT TO FIELDS
        public CarObjectTest(string carname,string carconstructor,int caryear)
        {
            //the "this" links the different fields to the requested parameters  
            this.carname = carname;
            this.carconstructor = carconstructor;
            this.caryear = caryear;

            //add 1 to car number each time a new instance of the object is created and tho the construtor is used : you can use the constructor method like a regular method too
            carnumber++; 



        }


        //METHODS OF MY OBJECT CAR OBJECTTEST
        public void GetCarInfo()
        {
            Console.WriteLine($"car is a {carname} from {carconstructor} \n it has been made in {caryear} ");

        }

        public void RaiseSpeed(bool carengineon)
        {
            if (carengineon == true) { vehiculecurrentspeed = 30; Console.WriteLine($"the car {carname} is speeding towards {vehiculecurrentspeed} km/h)"); }
            else
            {
                Console.WriteLine("engine need to be started first");


            }

        }
    }
}
