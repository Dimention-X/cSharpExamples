using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regular_Expression_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex(@"\d+");
            Match match = reg.Match("Akhilesh");
            if(match.Success)
            {
                Console.WriteLine(match.Value);
            }
            else
                Console.WriteLine("Match nt found");
        }
    }
}
