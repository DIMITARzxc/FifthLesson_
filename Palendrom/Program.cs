using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palendrom
{
    class Program
    {
        public static bool Compare(string s)
        {

            for (int i = 0; i < s.Length / 2; i++)

                if (s[i] != s[s.Length - i - 1])
                    return false;
            return true;
        }
        static void Main()
        {
            Console.WriteLine("Write some word");
            string s = Console.ReadLine();
            if (Compare(s))
                Console.WriteLine("This word is palindrom");
            else Console.WriteLine("This word is not palindrom");
            Console.ReadLine();
        }
    }
}
