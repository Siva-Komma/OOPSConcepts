using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_sConcepts
{
    public  class Vehicle
    {
        public void VehicleType()
        {
            string VName;
            Console.WriteLine("Enter Vehicle Type");
            VName =Console.ReadLine();
            Console.WriteLine("Vechile Type: " + VName);
        }
    }
    public class VehicleDetails : Vehicle
    {
        public  void Details()
        {
            VehicleType();
            string Model;
            Console.WriteLine("Enter Vehicle Model");
            Model = Console.ReadLine();
            Console.WriteLine("Vechile Model: "+Model);
        }
    }
}
