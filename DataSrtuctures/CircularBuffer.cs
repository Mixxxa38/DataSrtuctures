namespace DataSrtuctures
{
    public class CircularBuffer<T> // Циклический буффер<T>, перезаписывает по кругу значения последние элементы
    { 
      // для перезаписи => если индекс больше длинны массива, то значение перезаписали и длинна массива осталась прежней
        public int Count => nextIndex > _array.Length ? _array.Length : nextIndex;
        public int nextIndex { get; private set; } // счетчик 

        private T[] _array; // массив дженерик

        public CircularBuffer(int count) // конструктор
        {
            _array = new T[count];
        }

        public void Add(T value) // метод добавления значения в массив
        {
            int currentIndex = nextIndex % _array.Length; //
            _array[currentIndex] = value; //  значение записываем в массив под индексом
            ++nextIndex; // увеличиваем на 1(префикс)
        }

        public T Get(int index) // возвращает индекс 
        {
            if (nextIndex < _array.Length) //  индекс есть в массиве
            {
                return _array[index]; // вернули индекс массива
            }

            return _array[(nextIndex + index) % _array.Length]; // вернули индекс массива 
        }
    }
}