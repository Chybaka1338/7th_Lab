using System;
using System.Collections.Generic;

namespace _7th_Lab
{
    internal class Program
    {
        static int seed;
        static Random r;

        static void Main(string[] args)
        {
            seed = DateTime.Now.Millisecond;
            r = new Random(seed);
            Task3_4();
            Console.ReadKey();
        }

        #region task3_1
        static void Task3_1()
        {
            List<Group> groups = new List<Group>();
            for(int i = 0; i < 3; i++)
            {
                groups.Add(Group.InitializeGroup(GetListStudents()));
            }

            groups.Sort((g1, g2) =>
            {
                return g1.Middle.CompareTo(g2.Middle) * (-1);
            });

            groups.ForEach(g =>
            {
                Console.WriteLine($"Group: {Math.Round(g.Middle, 1)}");
                g.PrintGroup();
            });
        }

        static List<Person> GetListStudents()
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < 6; i++)
            {
                people.Add(Student.InitializeStudent("q" + i, 5, SetMarks));
            }
            return people;
        }

        static int[] SetMarks(int numberExams)
        {
            int[] marks = new int[numberExams];
            for(int i = 0; i < marks.Length; i++)
            {
                marks[i] = r.Next(2, 6);
            }
            return marks;
        }
        #endregion

        #region Task3_4
        static void Task3_4()
        {
            List<Group> groups = new List<Group>();
            for(int i = 0; i < 2; i++)
            {
                groups.Add(Group.InitializeGroup(GetListSportsmen()).Sort);
            }

            

            groups.ForEach(g =>
            {
                g.PrintGroup();
            });
        }

        static List<Person> GetListSportsmen()
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < 6; i++)
            {
                people.Add(Sportsmen.InitializeSportsmen("q" + i, GetTime));
            }
            return people;
        }

        static int GetTime()
        {
            int timeSecond = r.Next(1320, 1650);
            return timeSecond;
        }
        #endregion
    }
}
