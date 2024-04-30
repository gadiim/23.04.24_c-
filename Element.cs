using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._04._24_c_
{
    internal class Element<T>
    {
        private T _value { get; set; }
        private int _priority { get; set; }
        public Element(T value, int priority)
        {
            Value = value;
            Priority = priority;
        }
        public T Value { get { return _value; } set { _value = value; } }
        public int Priority { get { return _priority; } set { _priority = value; } }
        public override string ToString()
        {
            return $"item:\t{Value}\t-> priority:\t{Priority}";
        }
    }
}
