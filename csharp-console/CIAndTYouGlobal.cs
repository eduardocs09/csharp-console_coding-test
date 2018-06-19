using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace csharp_console
{
    public class CIAndTYouGlobal
    {
        public static void maximumCupcakes(string[] trips)
        {
            for (int i = 0; i < trips.Length; i++)
            {
                var testCaseInputs = trips[i].Split(' ');
                var n = Convert.ToInt32(testCaseInputs[0]);
                var c = Convert.ToInt32(testCaseInputs[1]);
                var m = Convert.ToInt32(testCaseInputs[2]);

                int cupCakes = n / c;
                int wrappers = cupCakes;

                while ((wrappers / m) >= 1)
                {
                    int newCupCakes = wrappers / m;
                    int wrappersLeft = wrappers % m;
                    wrappers = wrappersLeft + newCupCakes;
                    cupCakes += newCupCakes;
                }

                Console.WriteLine(cupCakes);
            }
        }

        public static int slotGame(string[] spins)
        {
            List<int> maxStops = new List<int>();
            List<List<int>> newSpins = new List<List<int>>();

            for (int i = 0; i < spins.Length; i++)
            {
                List<int> spin = new List<int>();
                for (int j = 0; j < spins[i].Length; j++)
                {
                    int element = Convert.ToInt32((spins[i][j]).ToString());
                    spin.Add(element);
                }
                newSpins.Add(spin);
            }

            while (newSpins[0].Count() >= 1)
            {
                int max = 0;
                foreach (var list in newSpins)
                {
                    int listMaxValue = list.Max();
                    if (listMaxValue > max)
                    {
                        max = listMaxValue;
                    }
                    list.Remove(listMaxValue);
                }
                maxStops.Add(max);
            }

            return maxStops.Sum();
        }

        public static int minMoves(int[] avg)
        {
            List<int> moves = new List<int>();

            //1100 - Moving 1
            int[] avgClone = avg.ToList().ToArray();
            int moves1 = 0;
            for (int i = 0; i < avgClone.Length; i++)
            {
                if (avgClone[i] == 1)
                {
                    int[] newAvg = avgClone.Take(i).ToArray();
                    int newIndex = i;
                    while (newAvg.Contains(0))
                    {
                        int aux = avgClone[newIndex - 1];
                        avgClone[newIndex - 1] = avgClone[newIndex];
                        avgClone[newIndex] = aux;

                        newIndex--;                        
                        newAvg = avgClone.Take(newIndex).ToArray();

                        moves1++;
                    }
                }
            }

            //1100 - Moving 0
            avgClone = avg.ToList().ToArray();
            int moves2 = 0;
            for (int i = avgClone.Length - 1; i >= 0; i--)
            {
                if (avgClone[i] == 0)
                {
                    int[] newAvg = avgClone.Skip(i + 1).ToArray();
                    int newIndex = i;
                    while (newAvg.Contains(1))
                    {
                        int aux = avgClone[newIndex + 1];
                        avgClone[newIndex + 1] = avgClone[newIndex];
                        avgClone[newIndex] = aux;

                        newIndex++;
                        newAvg = avgClone.Skip(newIndex + 1).ToArray();

                        moves2++;
                    }
                }
            }

            //0011 - Moving 1
            avgClone = avg.ToList().ToArray();
            int moves3 = 0;
            for (int i = avgClone.Length - 1; i >= 0; i--)
            {
                if (avgClone[i] == 1)
                {
                    int[] newAvg = avgClone.Skip(i + 1).ToArray();
                    int newIndex = i;
                    while (newAvg.Contains(0))
                    {
                        int aux = avgClone[newIndex + 1];
                        avgClone[newIndex + 1] = avgClone[newIndex];
                        avgClone[newIndex] = aux;

                        newIndex++;
                        newAvg = avgClone.Skip(newIndex + 1).ToArray();

                        moves3++;
                    }
                }
            }

            //0011 - Moving 0
            avgClone = avg.ToList().ToArray();
            int moves4 = 0;
            for (int i = 0; i < avgClone.Length; i++)
            {
                if (avgClone[i] == 0)
                {
                    int[] newAvg = avgClone.Take(i).ToArray();
                    int newIndex = i;
                    while (newAvg.Contains(1))
                    {
                        int aux = avgClone[newIndex - 1];
                        avgClone[newIndex - 1] = avgClone[newIndex];
                        avgClone[newIndex] = aux;

                        newIndex--;
                        newAvg = avgClone.Take(newIndex).ToArray();

                        moves4++;
                    }
                }
            }

            moves.Add(moves1);
            moves.Add(moves2);
            moves.Add(moves3);
            moves.Add(moves4);

            return moves.Min();
        }
    }
}
