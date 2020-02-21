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

class BirthdayCakeCandles
{

    // Complete the birthdayCakeCandles function below.
    static int birthdayCakeCandles(int[] ar)
    {
        var dic = new Dictionary<int, int>();
        for (int i = 0; i < ar.Length; i++)
        {
            if (!dic.ContainsKey(ar[i]))
                dic[ar[i]] = 1;
            else
                dic[ar[i]] = dic[ar[i]] + 1;
        }
        return dic.Max(x => x.Value);
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = birthdayCakeCandles(ar);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
