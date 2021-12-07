using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorsAndAngle;

namespace KataVectorsAndAngles
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector obj = new Vector(6, 8);
            Vector obj2= new Vector(4, 6);
            Console.WriteLine(obj.Magnitude());
            Console.WriteLine(obj.DotProduct(obj, obj2));
            Console.WriteLine(obj.AngleBetween(obj, obj2));
            Console.ReadKey();
        }
    }
}
