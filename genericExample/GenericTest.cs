using System;
using System.Collections.Generic;
using System.Text;

namespace genericExample
{
    class GenericTest<T>
    {
        private T[] genArray;
        public GenericTest(int size)
        {
            genArray = new T[size + 1];
        }

        public T getValue(int index)
        {
            return genArray[index];
        }

        public void setValue(int index, T value)
        {
            genArray[index] = value;
        }
    
    
    
    
    
    }


}
