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
            Group commonGroup = new Group();
            List<Person> commonPersons = new List<Person>();
            int i = 0;
            int j = 0;
            while (i < _persons.Count && j < g._persons.Count)
            {
                var s = _persons[i].GetResult() < g._persons[j].GetResult() ? _persons[i++] : g._persons[j++];
                commonPersons.Add(s);
            }
            while (i < _persons.Count)
            {
                commonPersons.Add(_persons[i++]);
            }
            while (j < g._persons.Count)
            {
                commonPersons.Add(g._persons[j++]);
            }
            commonGroup._persons = commonPersons;
            commonGroup._middle = (g.Middle + Middle) / 2;

            return commonGroup;
        }

        public void PrintGroup()
        {
            Console.WriteLine("Group");
            foreach(var person in _persons)
            {
                person.Print();
            }
            Console.WriteLine("__________________");
        }
    }
}
