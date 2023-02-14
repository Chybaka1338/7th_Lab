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

        double _middleScoreGroup;
        public double MiddleScoreGroup
        {
            get { return _middleScoreGroup; }
        }
        public Group(List<Student> students)
        {
            _students = students;
            SetMiddleScore();
        }

        public static Group InitializeGroup()
        {
            List<Student> students = new List<Student>();
            int numberExams = 5;
            while(true)
            {
                Student student = Student.InitializeStudent(numberExams);
                if (student.Equals(null)) return new Group(students);
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
            if (_students.Equals(null))
            {
                Console.WriteLine("Group is empty");
                return;
            }

            foreach(var student in _students)
            {
                student.
            }
        }
    }
}
