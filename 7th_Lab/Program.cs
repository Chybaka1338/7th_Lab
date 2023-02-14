using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _7th_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task3_1();
            Console.WriteLine("press any key to finish process");
            Console.ReadKey();
            Student student = new Student();
        }

        static void Task3_1()
        {
            int numberGroups = 3;
            List<Group> groups = new List<Group>();

            for(int i = 0; i < numberGroups; i++)
            {
                Console.WriteLine($"{i + 1} group");
                groups.Add(Group.InitializeGroup((i + 1).ToString()));
            }

            groups.Sort((g1, g2) => g1.MiddleScoreGroup.CompareTo(g2.MiddleScoreGroup) * (-1));

            groups.ForEach(group => group.Print());
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

            List<Sportsmen> commonGroup = firstGroup.Concat(secondGroup).ToList();
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
    }
}
