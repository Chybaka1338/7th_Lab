using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7th_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static void Task3_1()
        {
            List<Group> groups = new List<Group>();
            groups.Sort((Group g1, Group g2) =>
            {
                return g1.MiddleScoreGroup.CompareTo(g2.MiddleScoreGroup) * (-1);
            });

            groups.ForEach(g => g.);
        }
    }
}
