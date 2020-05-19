using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteratorExampleAss4
{
    class runTest
    {
        iteratorExample iterator = new iteratorExample();
        public void newTest()
        {
            Console.ReadLine();
            IEnumerable<string> elements = iterator.dayToDay();
            foreach (string day in elements)
            {
                Console.WriteLine(day);
                Console.ReadLine();
            }
            

        }
        

    }
}
