using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemVersionLib
{
    interface IArithmetic
    {
        int Add(int op1, int op2);

        int Subtract(int op1, int op2);
    }
}
