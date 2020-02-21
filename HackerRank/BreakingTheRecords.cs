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

class BreakingTheRecords
{

    // Complete the breakingRecords function below.
    static int[] breakingRecords(int[] scores)
    {
        var res = new int[] { 0, 0 };
        var heighScore = int.MinValue;
        var lowScore = int.MaxValue;
        for (int i = 0; i < scores.Length; i++)
        {
            if (scores[i] > heighScore)
            {
                heighScore = scores[i];
                if (i > 0)
                {
                    res[0]++;
                }
            }

            if (scores[i] < lowScore)
            {
                lowScore = scores[i];
                if (i > 0)
                {
                    res[1]++;
                }
            }
        }

        return res;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int[] result = breakingRecords(scores);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
