using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_sConcepts
{
    //Abstraction
    abstract class Vehicles
    {
        public abstract void VehicleType();
    }
    class VehiclesModel : Vehicles
    {
        public override void VehicleType()
        {
            string Name;
            Console.WriteLine("Enter Vehicle Name");
            Name= Console.ReadLine();
            Console.WriteLine("Name of Vehicle :"+Name);
        }
        public void VehiclesDetails()
        {
            Console.WriteLine("Enter Vehicle Model Name");
            string VModel= Console.ReadLine();
            Console.WriteLine("Name of the Vehicle Model: "+VModel);
        }

    }
}

