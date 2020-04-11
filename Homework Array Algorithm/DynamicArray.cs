using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Array_Algorithm
{
    public class DynamicArray : IDynamicArray
    {
        private int[] array = new int[6];
        public void Add(int item)
        {
            int? emptyIndex = FindEmptyIndex();

            if (emptyIndex != null)
            {
                array[(int)emptyIndex] = item;
            }
            else
            {
                var newBiggerArray = new int[array.Length + 1];
                for (int i = 0; i < array.Length; i++)
                {
                    newBiggerArray[i] = array[i];
                }
                array = newBiggerArray;
                array[array.Length] = item;
            }
        }

        public int GetIndex(int value)
        {
            //Define the value of the array
            //Return the position of the array if the value is present in it
            //Throw exception if value is not present

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            throw new Exception("Value is not present.");
        }

        public int GetValue(int index)
        {
            //Check if index is out of range
            //Return the value according to the enterred position

            if (index > array.Length - 1)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            else
            {
                return array[index];
            }

        }

        public void Remove(int index)
        {
            //Define position
            //Check if position is within range
            //Move to the right the positions, elements on the right side of the position will be moved to the left side a[i] = a[i + 1]
            //Array will be modified with the removed value on the specified position

            if (index > array.Length - 1)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            else
            {
                for (int i = index; i < array.Length - 1; i++)
                {
                    array[i] = array[i + 1];
                }
            }
        }

        private int? FindEmptyIndex()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    return i;
                }
            }
            return null;
        }
    }
}
