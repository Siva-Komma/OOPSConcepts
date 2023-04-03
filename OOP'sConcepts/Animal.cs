using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_sConcepts
{
    //Method Overriding
    public class Animal    
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("The animal make sounds");
        }
    }
    class Pig : Animal  
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
}
