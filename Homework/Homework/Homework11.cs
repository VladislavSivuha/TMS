using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Homework11
    {
        public void Test()
        {
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
}
