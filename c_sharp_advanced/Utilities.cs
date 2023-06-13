using System;

namespace c_sharp_advanced
{
    public class Utilities<T> where T : IComparable, new()
    {
        public T Max(T a, T b) //generic method w/ constraint
        {
            return a.CompareTo(b) > 0 ? a : b;
        }


        public void DoSomething(T value)
        {
            var obj = new T();
        }
    }
}
