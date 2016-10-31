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
            Rectangle rec = new Rectangle(new Points(1, 1),new Points(0,1),new Points(0,2),new Points(1,2));
            
            InvalidCastException exc = new InvalidCastException();

            try
            {
                throw new System.InvalidCastException();
            }
            catch(System.InvalidCastException)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
