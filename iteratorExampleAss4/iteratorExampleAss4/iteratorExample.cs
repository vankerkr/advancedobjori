using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteratorExampleAss4
{
    class iteratorExample
    {
        List<String> daysOfWeek = new List<String>();
        public iteratorExample()
        {
            

            daysOfWeek.Add("Sunday");
            daysOfWeek.Add("Monday");
            daysOfWeek.Add("Tuesday");
            daysOfWeek.Add("Wednesday");
            daysOfWeek.Add("Thursday");
            daysOfWeek.Add("Friday");
            daysOfWeek.Add("Saturday");
        }

        public IEnumerable<String> dayToDay()
        {
            for(int i=0;i < daysOfWeek.Count; i++)
            {
                yield return daysOfWeek[i];
            }
        }
    }
}
