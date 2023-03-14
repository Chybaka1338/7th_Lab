using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7th_Lab
{
    delegate int GetTimeSecond();
    internal class Sportsmen : Person
    {
        int _timeSecond;
        DateTime time;
        private Sportsmen(string lastName) : base(lastName)
        {

        }

        public static Sportsmen InitializeSportsmen(string lastName, GetTimeSecond getTimeSecond)
        {
            Sportsmen sportsmen = new Sportsmen(lastName);
            sportsmen._timeSecond = getTimeSecond.Invoke();
            sportsmen.time = new DateTime().AddSeconds(sportsmen._timeSecond);
            return sportsmen;
        }

        override
        public void Print()
        {
            Console.WriteLine($"{this.LastName} {time.Minute}m : {time.Second}s");
        }

        override
        public double GetResult()
        {
            return _timeSecond;
        }
    }
}
