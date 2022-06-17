using System;
using System.Runtime.InteropServices;

namespace DataSrtuctures
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //----------------------------------------------------------------------------------------------------------
            // List<T> check
            //----------------------------------------------------------------------------------------------------------
            DymanicArray<int> list = new DymanicArray<int>();
            list.Add(5);
            list.Add(25);
            list.Add(35);
            list.Add(55);
            list.Add(65);
            list.Add(75);
            
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list.Get(i) + " ");
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------");


            //----------------------------------------------------------------------------------------------------------
            // CircularBuffer<T> check
            //----------------------------------------------------------------------------------------------------------
            var circularBuffer = new CircularBuffer<int>(4); // должен вывести последние 4 значения
            circularBuffer.Add(8);
            circularBuffer.Add(18);
            circularBuffer.Add(28);
            circularBuffer.Add(38);
            circularBuffer.Add(48);
            circularBuffer.Add(58);

            for (int i = 0; i < circularBuffer.Count; i++)
            {
                Console.Write(circularBuffer.Get(i) + " "); // должен вывести последние 4 значения 
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------");

            //----------------------------------------------------------------------------------------------------------
            // Queue<T> check
            //----------------------------------------------------------------------------------------------------------           
            var queue = new Queue<string>();
            queue.Enqueue("Kate");
            queue.Enqueue("Sam");
            queue.Enqueue("Alice");
            queue.Enqueue("Tom");

            Console.WriteLine();
            var firstItem = queue.Dequeue();
            Console.Write("Извлеченный элемент: ");
            Console.WriteLine(firstItem); // Извлеченный элемент: Name: Kate 
            var secondItem = queue.Dequeue();
            Console.Write("Извлеченный элемент: ");
            Console.WriteLine(secondItem); // Извлеченный элемент: Name: Sam 
            queue = new Queue<string>();
            var Item = queue.Peak(); //null
            Console.WriteLine(Item);
            Console.WriteLine("-------------------------");

            //----------------------------------------------------------------------------------------------------------
            //BinaryHeap<int> check
            //----------------------------------------------------------------------------------------------------------    
            BinaryHeap heap = new BinaryHeap();
            heap.Add(5);
            heap.Add(3);
            heap.Add(25);
            heap.Add(17);
            heap.Add(44);
            heap.Add(1);
            heap.Add(29);
            heap.Add(2);
            for (int i = 0; i < heap.Count; i++)
            {
                Console.Write(heap.Gett(i) + " ");
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Max 1:" + heap.ExtractMaximum());
            Console.WriteLine("Max 2:" + heap.ExtractMaximum());
            Console.WriteLine("Max 3:" + heap.ExtractMaximum());
            Console.WriteLine("-------------------------");
            //----------------------------------------------------------------------------------------------------------
            //LinkedList<T> check
            //----------------------------------------------------------------------------------------------------------
            var linkedList = new LinkedList<string>();
            linkedList.AddLast("Вася");
            linkedList.AddLast("Петя");
            
            linkedList.PrintAll();
            // Вася 
            // Петя 
            
            linkedList.AddFirst("Антон");
            linkedList.AddFirst("Рома");
            
            linkedList.PrintAll();
            //  Рома 
            //  Антон 
            //  Вася 
            //  Петя 
            
            linkedList.Remove("Вася");
            linkedList.PrintAll();
            //  Рома 
            //  Антон 
            //  Петя 
        }
    }
}




