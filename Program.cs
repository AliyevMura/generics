using System.Collections;
using System.Threading.Channels;

namespace Taskcollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> MyArrayList = new MyClass<int>();
            MyArrayList.Add(1);
            MyArrayList.Add(2);
            MyArrayList.Add(3);
        }
    }

    internal class MyClass<T>
    {
        public T[] MyArrayList = new T[0];

        public void Add(T num)
        {
            Array.Resize(ref MyArrayList, MyArrayList.Length + 1);
            MyArrayList[MyArrayList.Length - 1] = num;
        }

        public void ClearMethods()
        {
            Array.Resize(ref MyArrayList, 0);
        }

        public int CountMethods()
        {
            int count = 0;
            foreach (T element in MyArrayList)
            {
                count++;
            }
            return count;
        }
    }
}
