using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _7th_Lab
{
    internal class Group
    {
        List<Person> _persons;
        double _middle;
        public double Middle { get { return _middle; } }

        public static Group InitializeGroup(List<Person> persons)
        {
            Group group = new Group();
            group._persons = persons;
            group.SetMiddle();
            group.Sort();
            return group;
        }

        void SetMiddle()
        {
            _middle = 0;

            if (_persons == null)
            {
                Process.GetCurrentProcess().Kill();
            }

            _persons.ForEach(per =>
            {
                _middle += per.GetResult();
            });

            _middle /= _persons.Count;
        }

        public void Sort()
        {
            if(_persons == null) 
            {
                Process.GetCurrentProcess().Kill();
            }

            var type = _persons[0].GetType();
            var reverse = Type.GetType("_7th_Lab.Student") == type ? -1 : 1;
            _persons.Sort((person1, person2) =>
            {
                return person1.GetResult().CompareTo(person2.GetResult()) * reverse;
            });
        }

        public Group ExpandGroup(Group g)
        {
            List<Person> commonGroup = new List<Person>();
            int i = 0;
            int j = 0;
            while (i < this.Count && j < g2.Count)
            {
                Sportsmen s = g1[i].TimeSecond < g2[j].TimeSecond ? g1[i++] : g2[j++];
                commonGroup.Add(s);
            }
            while (i < g1.Count)
            {
                commonGroup.Add(g1[i++]);
            }
            while (j < g2.Count)
            {
                commonGroup.Add(g2[j++]);
            }

            return commonGroup;
        }

        public void PrintGroup()
        {
            foreach(var person in _persons)
            {
                person.Print();
            }
        }
    }
}
