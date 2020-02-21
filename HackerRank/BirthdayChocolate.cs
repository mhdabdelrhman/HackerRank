﻿using System.CodeDom.Compiler;
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

static class BirthdayChocolate
{

    // Complete the birthday function below.
    static int birthday(List<int> s, int d, int m)
    {
        var result = 0;
        var sum = 0;
        var count = 0;

        for (int i = 0; i < s.Count; i++)
        {
            sum += s[i];

            if (count < m)
            {
                count++;
            }

            if (count == m)
            {
                if (sum == d)
                    result++;

                sum -= s[i - (m - 1)];
                count--;
            }
        }

        return result;
    }

    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        string[] dm = Console.ReadLine().TrimEnd().Split(' ');

        int d = Convert.ToInt32(dm[0]);

        int m = Convert.ToInt32(dm[1]);

        int result = birthday(s, d, m);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
