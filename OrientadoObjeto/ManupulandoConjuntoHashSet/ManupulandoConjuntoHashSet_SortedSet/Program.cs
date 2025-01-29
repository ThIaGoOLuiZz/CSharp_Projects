using System.Collections.Generic;

namespace ManupulandoConjuntoHashSet_SortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Computer"));

            foreach (string i in set)
            {
                Console.WriteLine(i);
            }
        }
    }
}
