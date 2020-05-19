using System;
using System.Collections.Generic;
using System.Text;

namespace genericExample
{
    class GenTest
    {
        public void runTest()
        {
            //int array example
            GenericTest<int> intArray = new GenericTest<int>(5);

            //set seed vals
            for(int c=0; c < 5; c++)
            {
                intArray.setValue(c, c * 2);
            }

            //retrieve values
            for(int i=0; i<5; i++)
            {
                Console.Write(intArray.getValue(i) + " ");
            }

            Console.WriteLine();
            Console.ReadKey();





            //char array example
            GenericTest<char> charArray = new GenericTest<char>(5);

            //set seed vals
            for(int i = 0; i<5; i++)
            {
                charArray.setValue(i, (char)(i + 97));
            }

            //retrieve values
            for (int i = 0; i < 5; i++)
            {
                Console.Write(charArray.getValue(i) + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
