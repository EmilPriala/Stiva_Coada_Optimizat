using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stiva_Coada_Optimizat
{
    public class Stiva : TADL 
    {
        public Stiva(int bufferSize) : base(bufferSize) { }
        public override int Pop()
        {
            return base.DelEnd();
        }
        public override void Push(int value)
        {
            base.AddEnd(value);
        }
    }
}
