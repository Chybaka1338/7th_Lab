using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _7th_Lab
{
    internal class Group
    {
        List<Student> _students;
        string _name;
        double _middleScoreGroup;
        public double MiddleScoreGroup
        {
            get { return _middleScoreGroup; }
        }

        public Group(List<Student> students, string name)
        {
            _students = students;
            SetMiddleScore();
            _name = name;
        }

        public static Group InitializeGroup(string name)
        {
            List<Student> students = new List<Student>();
            int numberExams = 5;
            while(true)
            {
                Student student = Student.InitializeStudent(numberExams);
                if (student == null) return new Group(students, name);
                students.Add(student);
            }
        }

        void SetMiddleScore()
        {
            if(_students == null || _students.Count == 0)
            {
                _middleScoreGroup = 0;
                return;
            }

            _middleScoreGroup = 0;
            foreach(var student in _students)
            {
                _middleScoreGroup += student.MiddleScore;
            }

            _middleScoreGroup = _middleScoreGroup / _students.Count;
        }

        public void Print()
        {
            Console.WriteLine($"{_name} has middle score {_middleScoreGroup}");
        }
    }
}
