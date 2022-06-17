using System.Collections.Generic;
using System.Linq;

namespace DataSrtuctures
{
    public class BinaryHeap //Двоичная куча 
    {
        private List<int> _heapData = new List<int>(); // List
        public int Count => _heapData.Count(); // последнее место в массиве/размер массива

        public void Add(int value) // Добавление элемента. Сложность  O(log2 N).
        {
            _heapData.Add(value); //добавили
            ShiftUp(_heapData.Count - 1); // начинаем в конца поднимать
        }

        public int Gett(int index)
        {
            return _heapData[index];
        }

        private void Swap(List<int> array, int leftIndex, int rightIndex) // метод сравнения/перестановки местами
        {
            (array[leftIndex], array[rightIndex]) = (array[rightIndex], array[leftIndex]);
        }

        private void ShiftUp(int index) //Подъем/сдвиг значение вверх по дереву
        {
            int parentIndex = (index - 1) / 2; // родитель с индексом index имеет индекс (index - 1) / 2
            var currentElement = _heapData[index]; //текущий
            var parentElement = _heapData[parentIndex]; //родительский;
            if (currentElement > parentElement)
            {
                Swap(_heapData, index, parentIndex); //перестановка
                ShiftUp(parentIndex); // опять поднимаем элемент(рекурсивно)
            }
        }

        private void ShiftDown(int index) //Опускаем/просеиваем значение вниз по дереву
        {
            int leftChild = 2 * index + 1; // левый потомок вершины с индексом index имеет индекс 2*index+1; 
            int rightChild = 2 * index + 2; // правый 2*index+2

            if (leftChild >= _heapData.Count) // если нет левого потомка,то выходим
            {
                return;
            }

            var largestChild = leftChild; //пусть максимальный будет левым
            // если есть правый и он оказался больше чем левый
            if (rightChild < _heapData.Count && _heapData[leftChild] < _heapData[rightChild])
            {
                largestChild = rightChild; // то правый  больший
            }

            if (_heapData[index] >
                _heapData[largestChild]) //если наш индекс уже больше, то выходим(нет смысла падать вниз)
            {
                return;
            }

            Swap(_heapData, index, largestChild); //перестановка
            ShiftDown(largestChild); //опять опускаем элемент(рекурсивно)
        }

        public int ExtractMaximum() // метод извленения максимального значения
        {
            var result = _heapData[0]; // первый элемент
            _heapData[0] = _heapData[_heapData.Count - 1];
            ShiftDown(0);
            return result;
        }
    }
}