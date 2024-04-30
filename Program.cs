using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

//Тема: Вступ у Generics
//Модуль 10. Part 1

namespace _23._04._24_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Завдання 1
            //Створіть generic-версію методу Swap для обміну значеннями двох змінних.

            Console.WriteLine($"Task 1\n");

            Variable <int> value_1 =  new Variable<int>(2);
            Variable <int> value_2 =  new Variable<int>(3);

            Console.WriteLine($"value 1 = {value_1.Value};\tvalue 2 = {value_2.Value}");

            Console.WriteLine("\n<int>value_1 SWAP value_2\n"); value_1.ToSwap(value_2);

            Console.WriteLine($"value 1 = {value_1.Value};\tvalue 2 = {value_2.Value}");

            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
            Console.Clear();

            //Завдання 2
            //Створіть generic-клас «Черга» з пріоритетами.
            //Реалізуйте стандартні методи і властивості для роботи черги
            //із пріоритетами.
            //Детальніше за посиланням:
            //https://uk.wikipedia.org/wiki/Черга_з_пріоритетом.

            Console.WriteLine($"Task 2\n");

            Element<int> int_element_1 = new Element<int>(0 , 1);
            Element<int> int_element_2 = new Element<int>(12 , 0);
            Element<int> int_element_3 = new Element<int>(5 , 2);
            Console.WriteLine(int_element_1.ToString());
            Console.WriteLine(int_element_2.ToString());
            Console.WriteLine(int_element_3.ToString());

            PriorityQueue<int> int_queue = new PriorityQueue<int>();

            Console.WriteLine("\n<int>value.ENQUEUE\n");
            int_queue.Enqueue(int_element_1);
            int_queue.Enqueue(int_element_2);
            int_queue.Enqueue(int_element_3);
            int_queue.ShowQueue();

            Console.WriteLine($"\n<int>value.TOP:\t\t{int_queue.Top()}");

            Console.WriteLine($"\n<int>value.COUNT:\t{int_queue.Count()}");

            Console.WriteLine($"\n<int>value.DEQUEUE:\t{int_queue.Dequeue()}\n");
            
            int_queue.ShowQueue();

            Console.WriteLine($"\n<int>value.PEEK:\t{int_queue.Peek()}");

            Console.WriteLine($"\n<int>value.CLEAR");
            int_queue.Clear();

            Console.WriteLine($"\n<int>value.IsEMPTY:\t{int_queue.isEmpty()}\n");
            int_queue.ShowQueue();

            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"Task 2\n");

            Element<double> double_element_1 = new Element<double>(0.1, 1);
            Element<double> double_element_2 = new Element<double>(12.0, 0);
            Element<double> double_element_3 = new Element<double>(5.2, 2);
            Console.WriteLine(double_element_1.ToString());
            Console.WriteLine(double_element_2.ToString());
            Console.WriteLine(double_element_3.ToString());

            PriorityQueue<double> double_queue = new PriorityQueue<double>();

            Console.WriteLine("\n<double>value.ENQUEUE\n");

            double_queue.Enqueue(double_element_1);
            double_queue.Enqueue(double_element_2);
            double_queue.Enqueue(double_element_3);
            double_queue.ShowQueue();

            Console.WriteLine($"\n<double>value.TOP:\t{double_queue.Top()}");

            Console.WriteLine($"\n<double>value.COUNT:\t{double_queue.Count()}");

            Console.WriteLine($"\n<double>value.DEQUEUE:\t{double_queue.Dequeue()}\n");

            double_queue.ShowQueue();

            Console.WriteLine($"\n<double>value.PEEK:\t{double_queue.Peek()}");

            Console.WriteLine($"\n<double>value.CLEAR");
            double_queue.Clear();

            Console.WriteLine($"\n<double>value.IsEMPTY:\t{double_queue.isEmpty()}\n");
            double_queue.ShowQueue();

            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"Task 2\n");

            Element<string> string_element_1 = new Element<string>("A", 1);
            Element<string> string_element_2 = new Element<string>("B", 0);
            Element<string> string_element_3 = new Element<string>("C", 2);
            Console.WriteLine(string_element_1.ToString());
            Console.WriteLine(string_element_2.ToString());
            Console.WriteLine(string_element_3.ToString());

            PriorityQueue<string> string_queue = new PriorityQueue<string>();

            Console.WriteLine("\n<string>value.ENQUEUE\n");

            string_queue.Enqueue(string_element_1);
            string_queue.Enqueue(string_element_2);
            string_queue.Enqueue(string_element_3);
            string_queue.ShowQueue();

            Console.WriteLine($"\n<string>value.TOP:\t{string_queue.Top()}");           

            Console.WriteLine($"\n<string>value.COUNT:\t{string_queue.Count()}");
            
            Console.WriteLine($"\n<string>value.DEQUEUE:\t{string_queue.Dequeue()}\n");

            string_queue.ShowQueue();

            Console.WriteLine($"\n<string>value.PEEK:\t{string_queue.Peek()}");

            Console.WriteLine($"\n<string>value.CLEAR");
            string_queue.Clear();

            Console.WriteLine($"\n<string>value.IsEMPTY:\t{string_queue.isEmpty()}\n");
            string_queue.ShowQueue();

            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
            Console.Clear();

            //            Завдання 3
            //Створіть generic-клас «Кільцева Черга». Реалізуйте
            //стандартні методи і властивості для роботи кільцевої
            //черги.
            //Детальніше за посиланням:
            //https://uk.wikipedia.org/wiki / Циклічний_буфер.

            Console.WriteLine($"Task 3\n");

            CircularQueue<int> int_circular_queue = new CircularQueue<int>(3);
            Console.WriteLine("\n<int>value.ENQUEUE\n");
            int_circular_queue.Enqueue(0);
            int_circular_queue.Enqueue(12);
            int_circular_queue.Enqueue(5);
            int_circular_queue.ShowQueue();

            Console.WriteLine($"\n<int>value.COUNT:\t{int_circular_queue.Count()}");

            Console.WriteLine($"\n<int>value.DEQUEUE:\t{int_circular_queue.Dequeue()}\n");
            int_circular_queue.ShowQueue();

            Console.WriteLine($"\n<int>value.PEEK:\t{int_circular_queue.Peek()}");

            Console.WriteLine($"\n<int>value.CLEAR");
            int_circular_queue.Clear();

            Console.WriteLine($"\n<int>value.IsEMPTY:\t{int_circular_queue.IsEmpty()}\n");
            int_circular_queue.ShowQueue();

            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"Task 3\n");

            CircularQueue<double> double_circular_queue = new CircularQueue<double>(3);
            Console.WriteLine("\n<double>value.ENQUEUE\n");
            double_circular_queue.Enqueue(0.1);
            double_circular_queue.Enqueue(12.5);
            double_circular_queue.Enqueue(5.0);
            double_circular_queue.ShowQueue();

            Console.WriteLine($"\n<double>value.COUNT:\t{double_circular_queue.Count()}");

            Console.WriteLine($"\n<double>value.DEQUEUE:\t{double_circular_queue.Dequeue()}\n");
            double_circular_queue.ShowQueue();

            Console.WriteLine($"\n<double>value.PEEK:\t{double_circular_queue.Peek()}");

            Console.WriteLine($"\n<double>value.CLEAR");
            double_circular_queue.Clear();

            Console.WriteLine($"\n<double>value.IsEMPTY:\t{double_circular_queue.IsEmpty()}\n");
            double_circular_queue.ShowQueue();

            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine($"Task 3\n");

            CircularQueue<string> string_circular_queue = new CircularQueue<string>(3);
            Console.WriteLine("\n<double>value.ENQUEUE\n");
            string_circular_queue.Enqueue("A");
            string_circular_queue.Enqueue("B");
            string_circular_queue.Enqueue("C");
            string_circular_queue.ShowQueue();

            Console.WriteLine($"\n<string>value.COUNT:\t{string_circular_queue.Count()}");

            Console.WriteLine($"\n<string>value.DEQUEUE:\t{string_circular_queue.Dequeue()}\n");
            string_circular_queue.ShowQueue();

            Console.WriteLine($"\n<string>value.PEEK:\t{string_circular_queue.Peek()}");

            Console.WriteLine($"\n<string>value.CLEAR");
            string_circular_queue.Clear();

            Console.WriteLine($"\n<string>value.IsEMPTY:\t{string_circular_queue.IsEmpty()}\n");
            string_circular_queue.ShowQueue();

            Console.WriteLine();


            //            Завдання 4
            //Створіть generic-клас однозв’язний список. Реалізуйте
            //стандартні методи і властивості для роботи однозв’язкового списку.
            //Детальніше за посиланням:
            //http://www.btechsmartclass.com/data_structures/single-linked-list.html.



            //            Завдання 5
            //Створіть generic-клас для двозв’язкового списку.
            //Реалізуйте стандартні методи і властивості для роботи
            //двозв’язкового списку.
            //Детальніше за посиланням:
            //http://www.btechsmartclass.com/data_structures/double-linked-list.html.


        }
    }
}
