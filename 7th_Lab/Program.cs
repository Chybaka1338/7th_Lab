using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _7th_Lab
{
    delegate int[] SetMarks(int numberExams);
    internal class Program
    {
        static void Main(string[] args)
        {
            Task3_1();
            //Task3_4();
            Console.WriteLine("press any key to finish process");
            Console.ReadKey();
        }

        static void Task3_1()
        {
            int numberGroups = 3;
            List<Group> groups = new List<Group>();

            for(int i = 0; i < numberGroups; i++)
            {
                Console.WriteLine($"{i + 1} group");
                groups.Add(Group.InitializeGroup((i + 1).ToString(), SetMarks));
            }

            groups.Sort((g1, g2) => g1.MiddleScoreGroup.CompareTo(g2.MiddleScoreGroup) * (-1));

            groups.ForEach(group => group.Print());
        }

        static int[] SetMarks(int numberExams)
        {
            int seed = DateTime.Now.Millisecond;
            Random r = new Random(seed);
            int[] marks = new int[numberExams];
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = r.Next(2, 5);
            }

            return marks;
        }

        static void Task3_4()
        {
            List<Sportsmen> firstGroup = InitializeGroup();
            List<Sportsmen> secondGroup = InitializeGroup();

            firstGroup.Sort((s1, s2) => s1.TimeSecond.CompareTo(s2.TimeSecond));
            secondGroup.Sort((s1, s2) => s1.TimeSecond.CompareTo(s2.TimeSecond));

            Console.WriteLine("First group");
            firstGroup.ForEach((s) => s.Print());
            Console.WriteLine("Second group");
            secondGroup.ForEach((s) => s.Print());

            List<Sportsmen> commonGroup = GetCommonGroup(firstGroup, secondGroup);
            commonGroup.Sort((s1, s2) => s1.TimeSecond.CompareTo(s2.TimeSecond));
            Console.WriteLine("Common group");
            commonGroup.ForEach((s) => s.Print());
        }

        static List<Sportsmen> InitializeGroup()
        {
            List<Sportsmen> group = new List<Sportsmen>();
            while(true)
            {
                Sportsmen sportsmen = Sportsmen.InitializeSportsmen();
                if (sportsmen == null) return group;
                group.Add(sportsmen);
            }
        }

        static List<Sportsmen> GetCommonGroup(List<Sportsmen> g1, List<Sportsmen> g2)
        {
            List<Sportsmen> commonGroup = new List<Sportsmen>();
            int i = 0;
            int j = 0;
            while (i < g1.Count && j < g2.Count)
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
    }
}
