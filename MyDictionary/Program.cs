using GenericsIntro;
using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(1, "A book");
            dictionary.Add(2, "B book");
        }
    }
}
