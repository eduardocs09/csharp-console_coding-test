using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_console
{
    public class Movie
    {
        public List<int> lengthEachScene(List<char> inputList)
        {
            var results = new List<int>();

            var index = 0;
            var sceneCount = 0;
            while (index < inputList.Count)
            {
                sceneCount++;
                var scene = inputList[index];
                var remainingList = inputList.GetRange(index + 1, inputList.Count - (index + 1));
                if (!remainingList.Contains(scene))
                {
                    results.Add(sceneCount);
                    sceneCount = 0;
                }
                index++;
            }
            return results;
        }
    }
}
