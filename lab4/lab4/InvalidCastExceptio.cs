using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public delegate void Del();
    class InvalidCastException:Exception
    {
        public event Del evt;
        public void Icast()
        {
            if (evt != null)
                evt();
        }
        public void mes()
        {
            Console.WriteLine(Message);
        }  
        public InvalidCastException()
        {
            evt += mes;
        }
    }
}
