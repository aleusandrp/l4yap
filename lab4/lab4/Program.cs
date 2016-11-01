using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Geom Object = new Geom(new Points(1, 1),new Points(0,1),new Points(0,2),new Points(1,2));

            DivideByZeroException eventus = new DivideByZeroException();

            try
            {
                throw new DivideByZeroException();
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine(eventus.Message);
            }
        }
    }
}
