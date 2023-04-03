using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_sConcepts
{
    //Method OverLoading
    public class Calculation
    {
        public static void Sum(int x, int y)
        {
            int z = x + y;
            Console.WriteLine("Z value: "+z);
        }
        public static void Sum(float x, int y)
        {
            float z = x + y;
            Console.WriteLine("Z value: " + z);
        }
        public static void Sum(string name, int x, int y)
        {
            int z = x + y;
            Console.WriteLine("Z value: " + z);
            Console.WriteLine("Name is: "+name);
        }


    }
}
