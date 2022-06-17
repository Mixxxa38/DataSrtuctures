using System;

namespace DataSrtuctures
{
    public class DymanicArray<T> // My  List<T>, динамический массив
    {
        private const int DefaultSize = 4; // размер массива по умолчанию
        internal int Count { get; private set; } // счетчик 

        private T[] _array; // массив дженерик

        public DymanicArray() // конструктор
        {
            _array = new T[DefaultSize];
        }
        public void Add(T value) // метод добавления значения в массив
        {
            if (Count == _array.Length) // если  индекс равен длинне массива
            {
                //копируем массив в новый, в 2 раза большего размера
                Array.Resize(ref _array, _array.Length * 2);
            }

            _array[Count] = value; // т.к. место есть в массиве, значение записываем в массив под  индексом
            Count++; // увеличиваем на 1
        }
        public T Get(int index) // возвращает индекс 
        {
            return _array[index]; // вернули индекс массива
        }
    }
}