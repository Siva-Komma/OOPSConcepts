using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_sConcepts
{
    public class PrintNumbers
    {
        public void Numbers()
        {
            int i = 0, n;
            Console.WriteLine("Enter number");
            n=Convert.ToInt32(Console.ReadLine());
            for(i=0;i<=n;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
