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

class FormingMagicSquare
{
    // Not working yet
    // Complete the formingMagicSquare function below.
    static int formingMagicSquare(int[][] s)
    {
        //var n = s.GetLength(0);
        //var constant = (n * (n * n + 1)) / 2;

        //var sumsRows = new int[n];
        //var sumsColumns = new int[n];
        //var sumsPrimary = 0;
        //var sumsSecoundary = 0;

        //for (int i = 0; i < n; i++)
        //{
        //    sumsRows[i] = 0;
        //    sumsColumns[i] = 0;

        //    for (int j = 0; j < n; j++)
        //    {
        //        sumsRows[i] += s[i][j];
        //        sumsColumns[i] += s[j][i];
        //        if (i == j)
        //        {
        //            sumsPrimary += s[i][j];
        //        }

        //        if (i + j == n - 1)
        //        {
        //            sumsSecoundary += s[i][j];
        //        }
        //    }
        //}

        //var changesRows = 0;
        //var changesColumns = 0;
        //var changesPrimary = Math.Abs(sumsPrimary - constant);
        //var changesSecondary = Math.Abs(sumsSecoundary - constant);
        //for (int i = 0; i < n; i++)
        //{
        //    changesRows += Math.Abs(constant - sumsRows[i]);
        //    changesColumns += Math.Abs(constant - sumsColumns[i]);
        //}

        //return Math.Max(changesRows, Math.Max(changesColumns, Math.Max(changesPrimary, changesSecondary)));
        return 0;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] s = new int[3][];

        for (int i = 0; i < 3; i++)
        {
            s[i] = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
        }

        int result = formingMagicSquare(s);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
