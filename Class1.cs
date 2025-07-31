using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNZ
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            PNZ n = new PNZ(num);
            n.check();

        }
    }
}
