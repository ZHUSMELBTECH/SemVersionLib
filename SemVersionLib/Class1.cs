using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemVersionLib
{
    public class Class1 : Interface1
    {
        public int Add(int op1, int op2)
            => op1 + op2;

        public int Subtract(int op1, int op2)
            => op1 - op2;
    }
}
