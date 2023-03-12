using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace _7th_Lab
{
    internal class Group
    {
        List<Person> _persons;

        public static Group InitializeGroup(List<Person> persons)
        {
            Group group = new Group();
            group._persons = persons;
        }

        public void Sort()
        {
            if(_persons == null) 
            {
                Process.GetCurrentProcess().Kill();
            }

            var type = _persons[0].GetType();
            if(Type.GetType("_7th_Lab.Student") == type)
            {
                _persons.Sort((student1, student2) =>
                {
                    return (Student)student1.
                });
            }
        }
    }
}
