using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motorcycle m1 = new Motorcycle("Henrik",false);
            m1.start();
            m1.shiftGearUp();
            Console.WriteLine(m1);
            m1.stop();
            Console.WriteLine(m1);
            Console.ReadKey();
        }
    }
}
