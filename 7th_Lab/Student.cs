using System;

namespace _7th_Lab
{
    internal class Student
    {
        int[] _marks;
        double _middleScore;
        string _lastName;
        public double MiddleScore
        {
            get { return _middleScore; }
        }

        public string LastName
        {
            get { return _lastName; }
        }

        private Student(string lastName, int[] marks, double middleScore)
        {
            _lastName = lastName;
            _marks = marks;
            _middleScore = middleScore;
        }

        public static Student InitializeStudent(int numberExams)
        {
            Console.Write("Enter the last name of student: ");
            string lastName = Console.ReadLine();
            int[] marks = SetMarks(numberExams);

            if (String.IsNullOrEmpty(lastName) || marks == null)
                return null;

            double middle = GetMiddleScore(marks);
            return new Student(lastName, marks, middle);
        }

        static int[] SetMarks(int numberExams)
        {
            int[] marks = new int[numberExams];
            try
            {
                for (int i = 0; i < marks.Length; i++)
                {
                    int mark;
                    do
                    {
                        Console.Write($"input {i + 1} mark: ");
                        mark = int.Parse(Console.ReadLine());
                    } while (mark < 2 && mark > 5);
                    marks[i] = mark;
                }
            } 
            catch(Exception)
            {
                return null;
            }
            return marks;
        }

        static double GetMiddleScore(int[] marks)
        {
            if(marks == null)
            {
                return 0;
            }

            double middleScore = 0;
            foreach(var mark in marks)
            {
                middleScore += mark;
            }

            return middleScore / marks.Length;
        }

        public void Print()
        {
            Array.ForEach(_marks, mark => Console.Write($"\t{mark}\t"));
            Console.WriteLine($"{_lastName}");
        }
    }
}
