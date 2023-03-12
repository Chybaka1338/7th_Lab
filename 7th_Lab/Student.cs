using System;

namespace _7th_Lab
{
    delegate int[] SetMarks(int numberExams);
    internal class Student : Person
    {
        int[] _marks;
        double _middleScore;

        public double MiddleScore { get { return _middleScore; } }

        public Student(string _lastName) : base(_lastName)
        {

        }

        public static Student InitializeStudent(int numberExams, SetMarks setMarks)
        {
            Student student = new Student("");
            student._marks = setMarks.Invoke(numberExams);
            student.SetMiddleScore();
            return student;
        }

        private void SetMiddleScore()
        {
            _middleScore = 0;
            foreach(var mark in _marks)
            {
                _middleScore += mark;
            }
            _middleScore /= _marks.Length;
        }

        public void Print()
        {
            Console.Write($"{LastName} ");
            foreach (var mark in _marks)
            {
                Console.Write(mark + ' ');
            }
        }
    }
}
