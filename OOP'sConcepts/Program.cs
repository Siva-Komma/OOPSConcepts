using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_sConcepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welome to OOPs Concepts");
            Console.WriteLine("1.Class and Object\n");
            Console.WriteLine("Choose Your Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    //Class and Object Concept
                    PrintNumbers num = new PrintNumbers();
                    num.Numbers();
                    break;
            }
            Console.ReadLine();
        }
    }
}
