using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task_1

namespace _23._04._24_c_
{
    internal class Variable<T>
    {
        public T Value { get; set; }

        public Variable(T value)
        {
            Value = value;
        }
        public void ToSwap(Variable<T> value)
        {
            T temp_value = Value;
            Value = value.Value;
            value.Value = temp_value;
        }
    }
}
