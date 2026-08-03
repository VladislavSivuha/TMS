using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Homework11
    {
        public void Test()
        {
            //MyLinkedList
            MyLinkedList<TestClass> list2 = new MyLinkedList<TestClass>();
            TestClass tt1 = new TestClass(1);
            TestClass tt2 = new TestClass(2);
            TestClass tt3 = new TestClass(3);
            TestClass tt4 = new TestClass(4);
            TestClass tt5 = new TestClass(5);

            list2.AddFirst(tt2);
            var f = list2.FirstNode;
            var l = list2.LastNode;
            list2.AddFirst(tt1);
            f = list2.FirstNode;
            l = list2.LastNode;
            list2.AddLast(tt3);
            f = list2.FirstNode;
            l = list2.LastNode;
            Console.WriteLine($"{list2.MyCount()}");
            list2.RemoveFirst();
            list2.RemoveLast();
            Console.WriteLine($"{list2.MyCount()}");
            return;

            //MyStack
            MyStack<string> myStack = new MyStack<string>("q");

            foreach (var i in myStack.Arr)
                Console.WriteLine($"{i}");
            Console.WriteLine("------------------");

            myStack.Push("w");
            myStack.Push("e");
            myStack.Push("r");
            myStack.Push("t");
            myStack.Push("y");
            myStack.Push("!");

            foreach (var i in myStack.Arr)
                Console.WriteLine($"{i}");
            Console.WriteLine("------------------");

            Console.WriteLine($"Pop(): {myStack.Pop()}");

            foreach (var i in myStack.Arr)
                Console.WriteLine($"{i}");
            Console.WriteLine("------------------");

            Console.WriteLine($"Peek: {myStack.Peek()}");

            foreach (var i in myStack.Arr)
                Console.WriteLine($"{i}");
            Console.WriteLine("------------------");

            

            //MyList
            MyList<int> myList = new MyList<int>(3);

            Console.WriteLine($"{myList.Count}");
            
            foreach (int i in myList.Arr)
                Console.WriteLine($"{i}");
            Console.WriteLine("------------------");

            myList.Add(10);

            foreach (int i in myList.Arr)
                Console.WriteLine($"{i}");
            Console.WriteLine("------------------");

            myList.RemoveByIndex(3);

            foreach (int i in myList.Arr)
                Console.WriteLine($"{i}");
            Console.WriteLine("------------------");

            myList.Add(10);
            Console.WriteLine($"{myList.Contains(10)}");
            Console.WriteLine($"{myList.Contains(20)}");

            foreach (int i in myList.Arr)
                Console.WriteLine($"{i}");
            Console.WriteLine("------------------");

            myList[9] = 69;
            
            foreach (int i in myList.Arr)
                Console.WriteLine($"{i}");
            Console.WriteLine("------------------");

            
            
            //Основное задание
            var p = new ComparablePair<int, int>(1, 100);
            var q = new ComparablePair<int, int>(2, 0);

            p.CompareTo(q);
            Console.WriteLine($"{p.CompareTo(q)}");
            Console.WriteLine("---------------------");

            Random random = new Random();

            List<ComparablePair<int, int>> comparablePairs = new List<ComparablePair<int, int>>();
            comparablePairs.Add(new ComparablePair<int, int>(random.Next(10), random.Next(10)));
            comparablePairs.Add(new ComparablePair<int, int>(random.Next(10), random.Next(10)));
            comparablePairs.Add(new ComparablePair<int, int>(random.Next(10), random.Next(10)));
            comparablePairs.Add(new ComparablePair<int, int>(random.Next(10), random.Next(10)));
            comparablePairs.Add(new ComparablePair<int, int>(random.Next(10), random.Next(10)));
            comparablePairs.Add(new ComparablePair<int, int>(random.Next(10), random.Next(10)));
            comparablePairs.Add(new ComparablePair<int, int>(random.Next(10), random.Next(10)));

            foreach (var item in comparablePairs)
            {
                Console.WriteLine($"{item.TKey} - {item.TValue}");
            }


            comparablePairs.Sort();
            Console.WriteLine("---------------------");

            foreach (var item in comparablePairs)
            {
                Console.WriteLine($"{item.TKey} - {item.TValue}");
            }
        }

    }

    public class Pair<T, U>
        where T : IComparable<T>
        where U : IComparable<U>
    {
        public T TKey { get; }
        public U TValue { get; }

        public Pair(T key, U value)
        {
            TKey = key;
            TValue = value;
        }
    }
    public class ComparablePair<T, U> : Pair<T, U>, IComparable<ComparablePair<T, U>>
        where T : IComparable<T>
        where U : IComparable<U>
    {

        public ComparablePair(T key, U value) : base(key, value)
        {

        }

        public int CompareTo(ComparablePair<T, U>? other)
        {
            if(other == null)
                return 1;

            var res = TKey.CompareTo(other.TKey);

            if(res != 0)
                return res;

            return TValue.CompareTo(other.TValue);
        }
    }


    //MyList<T>
    public class MyList<T>
    {
        public T[] Arr { get; set; }
        public int Count { get => Arr.Length; }

        public MyList()
        {
            Arr = new T[5];
        }
        public MyList(int startLenth)
        {
            Arr = new T[startLenth];
        }

        public void Add(T newItem)
        {
            T[] newArr = new T[Arr.Length + 1];
            for (int i = 0; i < Arr.Length; i++)
            {
                newArr[i] = Arr[i];
            }
            newArr[newArr.Length - 1] = newItem;
            Arr = newArr;
        }
        public void RemoveByIndex(int index)
        {
            if (index >= Arr.Length || index < 0)
            {
                Console.WriteLine("Индекс выходит за размер массива!");
                return;
            }
            
            T[] newArr = new T[Arr.Length - 1];
            int newArrCount = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                newArr[newArrCount++] = Arr[i];
            }
            Arr = newArr;
        }
        public bool Contains(T search)
        {
            //return Arr.Contains(search);

            foreach (T item in Arr)
            {
                if (item.Equals(search))
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        public T this[int index]
        {
            get 
            {
                if (index >= Arr.Length || index < 0)
                {
                    Console.WriteLine("Индекс выходит за размер массива!");
                    return default;
                }
                return Arr[index];
            }
            set 
            {
                if (index >= Arr.Length || index < 0)
                {
                    Console.WriteLine("Индекс выходит за размер массива!");
                    return;
                }
                Arr[index] = value;
            }
        }
        //Реализовать индексатор
    }
    public class MyStack<T>
    {
        public T[] Arr { get; private set; }
        public int Count { get => Arr.Length; }

        public MyStack(T item)
        {
            Arr = new T[] { item };
        }

        public void Push(T newItem)
        {
            var newArr = new T[Arr.Length + 1];
            for (int i = 0; i < Arr.Length; i++)
            {
                newArr[i] = Arr[i];
            }
            newArr[newArr.Length - 1] = newItem;
            Arr = newArr;
        }
        public T Pop()
        {
            T lastItem = Arr[Arr.Length - 1];

            var newArr = new T[Arr.Length - 1];
            
            for (int i = 0; i < Arr.Length - 1; i++)
            {
                newArr[i] = Arr[i];
            }
            Arr = newArr;
            return lastItem;
        }
        public T Peek()
        {
            if (Arr.Length == 0)
                return default;
            
            return Arr[Arr.Length - 1];
        }
        public void IsEmpty()
        {
            //Для чего этот метод?
        }
    }
    public class MyLinkedList<T>
    {
        public MyLinkedListNode<T>? FirstNode { get; set; }
        public MyLinkedListNode<T>? LastNode { get; set; }



        public void AddFirst(T newItem)
        {
            var newNode = new MyLinkedListNode<T>(newItem);

            if (FirstNode == null)
            {
                FirstNode = newNode;
                LastNode = LastNode is null ? newNode : null;
            }
            else
            { 
                FirstNode.FirstValue = newNode;
                newNode.LastValue = FirstNode;
                FirstNode = newNode;
            }
        }
        public void AddLast(T newItem)
        {
            var newNode = new MyLinkedListNode<T>(newItem);

            if (LastNode == null)
            {
                LastNode = newNode;
                FirstNode = FirstNode is null ? newNode : null;
            }
            else
            { 
                LastNode.LastValue = newNode;
                newNode.FirstValue = LastNode;
                LastNode = newNode;
            }
        }
        public void RemoveFirst()
        {
            if (FirstNode != null)
                FirstNode = FirstNode.LastValue is null ? null : FirstNode.LastValue;
        }
        public void RemoveLast()
        {
            if(LastNode != null)
                LastNode = LastNode.FirstValue is null ? null : LastNode.FirstValue;
        }
        public int MyCount()
        {
            int count = 0;

            var current = FirstNode;

            while (current != null)
            {
                count++;
                current = current.LastValue;
            }

            return count;
        }
    }
    public class MyLinkedListNode<T>
    {
        public MyLinkedListNode<T>? FirstValue { get; set; }
        public T Value { get; set; }
        public MyLinkedListNode<T>? LastValue { get; set; }

        public MyLinkedListNode(T item)
        {
            Value = item;
        }
    }





    public class TestClass
    {
        public int ID { get; set; }

        public TestClass(int id)
        {
            ID = id;
        }
    }
}
