namespace DataSrtuctures
{
    public class LinkedList<T>
    {
        public Node<T> Head = null; // Первый (головной) элемент списка.
        
        public Node<T> Tail = null; // Крайний (хвостовой) элемент списка.
        
        public void AddLast(T data) // Добавить данные в  связный список
        {
            Node<T> node = new Node<T>(data); // создали ноду

            if (Tail == null) // если хвост null
            {
                Tail = node; // нода равна хвосту
                Head = node; // и нода равна голове, т.е элементов пока нет
            }
            else
            {
                Tail.Next = node; // последнему элементу(который был последний) указали ссылку на следующий
                Tail = node; // нода равна хвосту
            }
        }
        
        public void AddFirst(T data) // Добавляет ноду в самое начало
        {
            Node<T> node = new Node<T>(data);
            
            if (Head == null) // голова хвост null
            {
                Tail = node; // нода равна хвосту
                Head = node; // нода равна голове
            }
            else
            {
                node.Next = Head; //показываем новой первой ноде, ссылку на следующий элемент(старый первый)
                Head = node;  // нода равна голове
            }
        }
        
        public void Remove(T data) // Удалить данные из связного списка. Выполняется удаление первого совпадения данных
        {
            var currentNode = Head; // пусть нужная нода это голова
            while (currentNode != null) // пробегаемся от головы по всем нодам
            {
                if (currentNode.Value.Equals(data)) // если значения совпали
                {
                    currentNode.Value = currentNode.Next.Value; // текущее значение записывается в значение сл. ноды
                    currentNode.Next = null; // а  ссылка на сл. ноду равна null
                }
                currentNode = currentNode.Next;// и текущая нода становится следующей(берет ее значения и ссылку) 
            }
        }
        
        public void PrintAll() // Вывод всех объектов в консоль
        {
            if (Head == null) //нечего выводить
            {
                return;
            }

            Node<T> node = Head;
            while (node!= null) //до тех пор пока нода не равна null
            {
                node.Print(); //печатаем ноду
                node = node.Next; // переходим к следующей ноде
            }
        }
    }
}