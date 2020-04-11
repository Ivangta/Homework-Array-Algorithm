using System;

namespace Homework_Array_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            IDynamicArray array = new DynamicArray();

            array.Add(4);
            array.Add(5);
            array.Add(6);
            array.Add(10);

            array.Remove(1);
            array.Remove(1);

            Console.WriteLine(array.GetValue(0));
            Console.WriteLine(array.GetIndex(10));
        }
    }
}
