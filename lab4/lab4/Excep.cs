using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public delegate void Message();
    class DivideByZeroException : Exception
    {
        public event Message mess;
        public void Icast()
        {
            if (mess != null)
                mess();
        }
        public void write()
        {
            Console.WriteLine(Message);
        }  
        public DivideByZeroException()
        {
            mess += write;
        }
    }
}
