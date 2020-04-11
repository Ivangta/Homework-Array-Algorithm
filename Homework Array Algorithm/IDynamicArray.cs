using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Array_Algorithm
{
    public interface IDynamicArray
    {
        void Add(int item);
        void Remove(int index);
        int GetValue(int index);
        int GetIndex(int value);
    }
}
