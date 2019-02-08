using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Program
    {
        static void Main()
        {
            Interface1 CH1 = new T1();
            Interface2 CH2 = new T2();
            Interface3 CH3 = new T3();
            CH1.Toffee1();
            CH2.Toffee2();
            CH3.Toffee3();

        }
        class T1 : Interface1
        {
            public void Toffee1()
            {
                
                Console.WriteLine("HELLO");
            }
        }
        class T2 : Interface2
        {
            public void Toffee2()
            {

                Console.WriteLine("WELCOME");
            }
        }
       
        }

    }
}
