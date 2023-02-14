using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7th_Lab
{
    internal class Sportsmen : Student
    {
        int _timeSecond;
        DateTime _time;

        public int TimeSecond
        {
            get { return _timeSecond; }
        }

        public DateTime Time
        {
            get { return _time; }
        }

        public Sportsmen(string lastName, int timeSecond) : base(lastName)
        {
            _timeSecond = timeSecond;
            _time = new DateTime().AddSeconds(timeSecond);
        }

        public static Sportsmen InitializeSportsmen()
        {
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            if (String.IsNullOrEmpty(lastName)) return null;
            int timeSecond = GetTime();
            return new Sportsmen(lastName, timeSecond);
        }

        static int GetTime()
        {
            return new Random(DateTime.Now.Second).Next(1350, 1620);
        }
    }
}
