using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task_3

namespace _23._04._24_c_
{
    internal class CircularQueue<T>
    {
        private List<T> elements;
        private int head;
        private int tail;
        private int size;
        private int count;

        public CircularQueue(int size)
        {
            this.size = size;
            elements = new List<T>(size);
            head = 0;
            tail = -1;
            count = 0;
        }
        public int Count()
        {
            return count;
        }
        public void Enqueue(T item)
        {
            tail = (tail + 1) % size;
            elements.Insert(tail, item);
            count++;
        }
        public bool IsEmpty()
        {
            return count == 0;
        }

        public T Dequeue()
        {
            T dequeued = elements[head];
            elements.RemoveAt(head);
            count--;
            return dequeued;
        }
        public T Peek()
        {
            return elements[head];
        }
        public void Clear()
        {
            elements.Clear();
            head = 0;
            tail = -1;
            count = 0;
        }
        public void ShowQueue()
        {
            Console.Write($"queue:\t\t\t");
            if (count == 0)
            {
                Console.WriteLine("is empty");
                return;
            }
            int index = head;
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{elements[index]}  ");
                index = (index + 1) % size;
            }
            Console.WriteLine();
        }
    }
}
