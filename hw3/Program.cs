using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Some testing string ";
            AmountSymbolsInString(s);
            FindDublicateChars(s);
            
        }
        static void AmountSymbolsInString(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            List<char> chars = s.ToList<char>();
            while (chars.Count != 0)
            {
                dict.Add(chars.First(), chars.FindAll(chars.First().Equals).Count);
                chars.RemoveAll(chars.First().Equals);
            }
            foreach (var i in dict)
            {
                Console.WriteLine("{0} {1}",i.Key, i.Value);
            }
        }
        static void FindDublicateChars(string s)
        {
            List<char> chars = s.ToList<char>();
            HashSet<char> unique = new HashSet<char>();
            HashSet<char> dublicated = new HashSet<char>();
            foreach (var i in chars)
            {
                if (unique.Add(i) == false)
                    dublicated.Add(i);
            }
            Console.WriteLine(dublicated.ToArray());
        }
    }
}
