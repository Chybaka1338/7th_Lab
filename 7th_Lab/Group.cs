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

        public int NumberStudents
        {
            get { return _students.Count; }
        }

        public Group()
        {
            _name = null;
            _students = new List<Student>();
            _middleScoreGroup = 0;
        }

        public Group(List<Student> students, string name)
        {
            _students = students;
            SetMiddleScore();
            _name = name;
        }

        public static Group InitializeGroup(string name, SetMarks setMarks)
        {
            List<Student> students = new List<Student>();
            int numberExams = 5;
            while(true)
            {
                Student student = Student.InitializeStudent(numberExams, setMarks);
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
            Console.WriteLine($"{_name} has middle score {Math.Round(_middleScoreGroup, 1)}");
        }

        public void ExpandGroup(Group group)
        {
            Group commonGroup = new Group();
            int i = 0;
            int j = 0;

            while(i < group.NumberStudents && j < this.NumberStudents)
            {
                Student s = group._students[i].MiddleScore < this._students[j].MiddleScore ? this._students[j++] : group._students[i++];
                commonGroup._students.Add(s);
            }

            while(i < group.NumberStudents)
            {
                commonGroup._students.Add(group._students[i++]);
            }

            while (j < this.NumberStudents)
            {
                commonGroup._students.Add(this._students[j++]);
            }
            this._students = commonGroup._students;
        }
    }
}
