using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace csharp_console
{
    class Program
    {
        #region BASIC STRUCTURE

        static void Main(string[] args)
        {
            string fileName = GetFileNAme(args);
            if (!File.Exists(fileName))
            {
                Console.WriteLine("Arquivo não encontrado!");
            }
            else
            {
                string[] lines = File.ReadAllLines(fileName);
                ProcessFileLines(lines);
            }
            Console.Read(); //End of program
        }

        private static string GetFileNAme(string[] args)
        {
            string defaultFilePath = "D:\\Learning\\Code\\CSharp\\csharp-console\\entry.txt";
            string fileName = string.Empty;
            if (args.Length > 0)
            {
                fileName = args[0];
            }
            else if (File.Exists(defaultFilePath))
            {
                fileName = defaultFilePath;
            }
            else
            {
                Console.WriteLine("Entre com o PATH do arquivo:");
                fileName = Console.ReadLine();
            }

            return fileName;
        }

        #endregion

        #region SPECIFIC CODE

        /// <summary>
        /// 
        /// This method does the specifics part of the coding test.
        /// All the input processing and business logic to produce the output should be placed in here.
        /// 
        /// </summary>
        /// <param name="lines"></param>
        private static void ProcessFileLines(string[] lines)
        {
            #region OLD DRONES ASSIGMENT
            //long dronesCount = 0, defectCount = 0, toSelect = 0;
            //var quantities = lines[0].Split(' ');

            //dronesCount = Convert.ToInt64(quantities[0]);
            //defectCount = Convert.ToInt64(quantities[1]);
            //toSelect = Convert.ToInt64(quantities[2]);

            //Dictionary<long, long> defectDrones = new Dictionary<long, long>();
            //if (defectCount > 0)
            //{
            //    for (long index = (dronesCount + 1); index <= (dronesCount + defectCount); index++)
            //    {
            //        var drone = Convert.ToInt64(lines[index]);
            //        defectDrones.Add(drone, drone);
            //    }
            //}

            //List<long> drones = new List<long>();
            //for (long index = 1; index <= dronesCount; index++)
            //{
            //    var drone = Convert.ToInt64(lines[index]);
            //    if (!defectDrones.ContainsKey(drone))
            //    {
            //        drones.Add(drone);
            //    }
            //}

            //drones.Sort();
            //for (long index = 0; index < toSelect; index++)
            //{
            //    Console.WriteLine(drones[(int)index]);
            //}
            #endregion

            #region AMAZON ASSIGNMENT 1
            //var inputString = lines[0];
            //var num = Convert.ToInt32(lines[1]);

            //var solutionOne = new Solution();
            //var results = solutionOne.subStringsKDist(inputString, num);
            //Console.WriteLine(results);
            #endregion

            #region AMAZON ASSIGNMENT 2
            //List<char> listChar = new List<char>();
            //for (long index = 0; index < lines.LongLength; index++)
            //{
            //    listChar.Add(lines[index][0]);
            //}
            //var movie = new Movie();
            //movie.lengthEachScene(listChar);
            #endregion

            #region BALANCED EXPRESSIONS
            //long numExpressions = Convert.ToInt64(lines[0]);
            //long numMaxReplacements = Convert.ToInt64(lines[numExpressions + 1]);
            //List<string> expressions = new List<string>();
            //List<int> maxReplacements = new List<int>();
            //for (long index = 1; index <= numExpressions; index++)
            //{
            //    expressions.Add(lines[index]);
            //}
            //for (long index = (numExpressions + 2); index <= (numExpressions + numMaxReplacements + 1); index++)
            //{
            //    maxReplacements.Add(Convert.ToInt32(lines[index]));
            //}
            //int[] result = BalancedExpressions.balancedOrNot(expressions.ToArray(), maxReplacements.ToArray());

            //for (int index = 0; index < result.Length; index++)
            //{
            //    Console.WriteLine(result[index]);
            //}          
            #endregion

            #region THALMIC LABS SOFTWARE ENGINEER BACKEND
            var subsString = lines[0];
            var movies = ThalmicLabsSoftwareEngineerBackend.getMovieTitles(subsString);
            foreach (var movie in movies)
            {
                Console.WriteLine(movie);
            }
            #endregion

            var test = lines;
        }

        #endregion
    }
}
