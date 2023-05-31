using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stiva_Coada_Optimizat
{
    internal class Stack
    {
        static void Main(string[] args)
        {
            /*TADL d = new TADL();
            for (int i = 0; i < 21; i++)
            {
                d.AddEnd(i);
                Console.WriteLine(d.View());
            }
            for (int i = 0; i < 21; i++)
            {
                //d.DelBegin();
                Console.WriteLine("(" + d.DelBegin() + ") " + d.View());
            }*/
            Stiva st = new Stiva(5);
            for (int i = 0; i < 21; i++)
            {
                st.Push(i);
                Console.WriteLine(st.View());
            }
            for (int i = 0; i < 21; i++)
            {
                Console.WriteLine("(" + st.Pop() + st.View());
            }
            Console.ReadKey();
            Console.WriteLine();

        }
    }
}
