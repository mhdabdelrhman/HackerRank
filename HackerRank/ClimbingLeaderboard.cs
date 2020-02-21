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

class ClimbingLeaderboard
{

    // Complete the climbingLeaderboard function below.
    static int[] climbingLeaderboard(int[] scores, int[] alice)
    {

        var results = new int[alice.Length];

        var ranks = new int[scores.Length];
        var rank = 1;

        for (int i = 0; i < scores.Length; i++)
        {
            ranks[i] = rank;
            if (i != scores.Length - 1 && scores[i + 1] < scores[i])
                rank++;
        }

        for (int i = 0; i < alice.Length; i++)
        {
            var aliceScore = alice[i];
            var startIndex = 0;
            var endIndex = scores.Length - 1;

            while (true)
            {
                var maxScore = scores[startIndex];
                var minScore = scores[endIndex];

                if (aliceScore >= maxScore)
                {
                    results[i] = ranks[startIndex];
                    break;
                }

                if (aliceScore < minScore)
                {
                    results[i] = ranks[endIndex] + 1;
                    break;
                }

                if (aliceScore == minScore)
                {
                    results[i] = ranks[endIndex];
                    break;
                }

                if(endIndex-startIndex <= 1)
                {
                    results[i] = ranks[endIndex];
                    break;
                }

                var midelIndex = (startIndex + endIndex) / 2;
                var midelScore = scores[midelIndex];

                if (aliceScore <= midelScore)
                {
                    startIndex = midelIndex;
                }
                else
                {
                    endIndex = midelIndex;
                }
            }
        }

        return results;
    }

    static void Main(string[] args)
    {
        int scoresCount = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int aliceCount = Convert.ToInt32(Console.ReadLine());

        int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp))
        ;
        int[] result = climbingLeaderboard(scores, alice);

        Console.WriteLine(string.Join("\n", result));
       
    }
}
