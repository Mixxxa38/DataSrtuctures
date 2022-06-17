using System;

namespace DataSrtuctures
{
    public class Queue<T> // My  Queue<T> Очередь
    {
        private const int DefaultSize = 4; // размер массива по умолчанию
        public int Count; // количество элементов
        public int Head; // первый элемент очереди
        private T[] _array; //  массив дженерик

        public Queue() // конструктор
        {
            _array = new T[DefaultSize];
        }

        public void Enqueue(T value) // добавление в очередь
        {
            if (Count == _array.Length) // если в массиве больше нет места
            {
                Array.Resize(ref _array, Count * 2); //копируем массив в новый, в 2 раза большего размера
                _array[Count] = value;
                Count++;
            }
            else // если в  массиве массиве есть место
            {
                _array[Count] = value; // добавляем значение 
                Count++; // количество элементов + 1
            }
        }

        public T Dequeue() // удаление из очереди
        {
            var temp = _array[Head]; // 
            _array[Head] = default(T); // становится значение по умолчанию
            Head++; // Переходим на 1 значение далее
            return temp;
        }

        public T Peak() // возвращает первый элемент
        {
            if (_array[Head] == null) Console.Write("пусто");
            return _array[Head % _array.Length];
        }
    }
}