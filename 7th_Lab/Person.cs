﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7th_Lab
{
    abstract class Person
    {
        string _lastName;

        public string LastName { get { return _lastName; } }

        public Person(string lastName)
        {
            _lastName = lastName;
        }

        abstract public void Print();

        abstract public double GetResult();
    }
}
