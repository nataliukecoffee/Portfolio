using MDPyramidLibrary;
using System;
using System.Collections.Generic;

namespace MDPyramid
{
    internal class Program
    {
        private static List<Result> findResults(List<List<int>> inputList)
        {
            List<Result> results = new List<Result>();
            for (int i = 0; i < inputList.Count; i++)
            {
                if (i == 0)
                {
                    PyramidResearch.generateFirstresults(inputList[i], results);
                }
                else
                {
                    List<Result> newResults = new List<Result>();
                    foreach (Result result in results)
                    {
                        List<Result> tempResults = PyramidResearch.findNextNumbersResults(inputList[i], result);
                        if (tempResults != null)
                        {
                            newResults.AddRange(tempResults);
                        }
                    }

                    results.Clear();

                    results.AddRange(newResults);

                }
            }
            return results;
        }

        private static Result findMaxResult(List<Result> results)
        {
            int max = 0;
            int maxIndex = -1;
            for (int i = 0; i < results.Count; i++)
            {
                if (maxIndex == -1 || max < results[i].Sum)
                {
                    max = results[i].Sum;
                    maxIndex = i;
                }
            }

            if (maxIndex != -1)
            {
                return results[maxIndex];
            }

            return null;
        }

        private static void printResult(Result result)
        {
            if (result != null)
            {
                Console.WriteLine("Max sum: " + result.Sum);
                Console.WriteLine("Path: " + result.getRoute());
            }
            else
            {
                Console.WriteLine("Bottom of pyramid didn't reached.");
            }
        }


            public static void Main(string[] args)
        {
            List<List<int>> inputList = ReadInput.readInputFromFile(@"..\..\input.txt");
            Console.WriteLine();
            Console.WriteLine("Output:");
            printResult(findMaxResult(findResults(inputList)));
        }
    }
}
