using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_sConcepts
{
    public class TypesOfMethods
    {
        //Static Method and Parameterised Method
        public void StdDetail()
        {
            int id = 1;
            string Name = "siva";
            Console.WriteLine($"Enter Id {id} Name {Name} ");
        }
        public static void StdDetails(int age, int marks)
        {
            int id = 1;
            string Name = "siva";
            Console.WriteLine($"Enter Id {id} Name {Name} age {age} marks {marks} ");
        }
    }
}

