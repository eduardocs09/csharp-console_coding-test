using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_console
{
    public static class Combinatorial
    {
        public static List<string> CombinationWithNoRepetition(string input, int itensLength)
        {
            var results = new List<string>();
            char[] charArray = input.ToCharArray().Distinct().ToArray();
            int[] positionControl = new int[itensLength];
            int index = 0;
            return results;
        }
    }
}
