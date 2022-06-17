using System;

namespace DataSrtuctures
{
    public class Node<T>
    {
        public T Value; // Хранимые данные
        
        public Node<T> Next;  // Следующий элемент связного списка
        
        public Node(T value) // Создание нового экземпляра связного списка(конструктор)
        {
            Value = value;
        }
        
        public void Print() // Приведение объекта к строке/ печать
        {
            Console.WriteLine(Value);
        }
    }
}