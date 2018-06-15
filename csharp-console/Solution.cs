using System;
using System.Collections.Generic;

public class Solution
{
    public List<string> subStringsKDist(string inputStr, int num)
    {
        var results = new List<string>();
        var charArray = inputStr.ToCharArray();

        Dictionary<char, char> distinctChars = new Dictionary<char, char>();
        long index = 0;
        while (index < charArray.LongLength)
        {
            if (!distinctChars.ContainsKey(charArray[index]))
            {
                distinctChars.Add(charArray[index], charArray[index]);
            }
            index++;
        }

        if (distinctChars.Count > num)
        {
            //char
        }
        else if (distinctChars.Count == num)
        {
            var str = string.Empty;
            foreach (var value in distinctChars.Values)
            {
                str += value;
            }
            
            results.Add(str);
        }

        return results;
    }
}