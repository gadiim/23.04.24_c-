using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task_2

namespace _23._04._24_c_
{
    internal class PriorityQueue<T>
    {
        public List<Element<T>> values = new List<Element<T>>();
        public int Count()
        {
            return values.Count;
        }
        public T Peek()
        {
            Element<T> firstElement = values[0];
            return firstElement.Value;
        }
        public bool isEmpty()
        {
            return values.Count() == 0;
        }
        public T Top()
        {
            Element<T> high_priority = values[0];
            foreach (var value in values)
            {
                if (value.Priority < high_priority.Priority)
                {
                    high_priority = value;
                }
            }
            return high_priority.Value;
        }

        public void Enqueue(Element<T> element)
        {
            if (isEmpty())
            {
                values.Add(element);
            }
            else
            {
                int index = 0;
                while (index < values.Count && element.Priority >= values[index].Priority)
                {
                    index++;
                }
                values.Insert(index, element);
            }
        }
        public T Dequeue()
        {
            Element<T> firstElement = values[0];
            values.RemoveAt(0);
            return firstElement.Value;
        }
        public void Clear()
        {
            values.Clear();
        }
        public void ShowQueue()
        {
            Console.Write($"queue:\t\t\t");
            if (values.Count == 0)
            {
                Console.WriteLine("is empty");
                return;
            }
            foreach (var element in values)
            {
                Console.Write($"{element.Value}  ");
            }
            Console.WriteLine();
        }
    }
}
