using System;
using System.Text;
using System.Threading.Tasks;

namespace csharp_console
{
    public class BalancedExpressions
    {
        public static int[] balancedOrNot(string[] expressions, int[] maxReplacements)
        {
            int[] result = new int[expressions.Length];
            char leftArrow = '<';

            for (int index = 0; index < expressions.Length; index++)
            {
                char[] expression = expressions[index].ToCharArray(); ;
                int maxReplacement = maxReplacements[index];
                int unbalancedLeftArrow = 0;
                int replacements = 0;

                for (int charIndex = 0; charIndex < expression.Length; charIndex++)
                {
                    if (expression[charIndex] == leftArrow)
                    {
                        unbalancedLeftArrow++;
                    }
                    else if (unbalancedLeftArrow > 0)
                    {
                        unbalancedLeftArrow--;
                    }
                    else
                    {
                        replacements++;
                    }
                }

                if ((unbalancedLeftArrow == 0) && (replacements <= maxReplacement))
                {
                    result[index] = 1;
                }
                else
                {
                    result[index] = 0;
                }

            }
            return result;
        }
    }
}
