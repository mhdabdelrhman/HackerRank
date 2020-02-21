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
using System.Threading.Tasks;

class MatrixLayerRotation
{
    // Need Optimizing

    // Complete the matrixRotation function below.
    static void moveRowLeft(int startI, int endI, int j, List<List<int>> matrix)
    {
        for (int i = startI; i < endI; i++)
        {
            matrix[j][i] = matrix[j][i + 1];
        }
    }
    static void moveRowRight(int startI, int endI, int j, List<List<int>> matrix)
    {
        for (int i = endI; i > startI; i--)
        {
            matrix[j][i] = matrix[j][i - 1];
        }
    }

    static void moveColumnUp(int startJ, int endJ, int i, List<List<int>> matrix)
    {
        for (int j = startJ; j < endJ; j++)
        {
            matrix[j][i] = matrix[j + 1][i];
        }
    }

    static void moveColumnDown(int startJ, int endJ, int i, List<List<int>> matrix)
    {
        for (int j = endJ; j > startJ; j--)
        {
            matrix[j][i] = matrix[j - 1][i];
        }
    }

    static void rotateRing(int startI, int endI, int startJ, int endJ, List<List<int>> matrix, int r)
    {
        if (startI == endI && startJ == endJ)
            return;
        for (int k = 0; k < r; k++)
        {
            var temp = matrix[startJ][startI];
            moveRowLeft(startI, endI, startJ, matrix);
            moveColumnUp(startJ, endJ, endI, matrix);
            moveRowRight(startI, endI, endJ, matrix);
            moveColumnDown(startJ, endJ, startI, matrix);
            if (startJ != endJ)
                matrix[startJ + 1][startI] = temp;
            else
                matrix[startJ][startI + 1] = temp;
        }
    }
    static void matrixRotation(List<List<int>> matrix, int r)
    {
        if (matrix.Any())
        {
            var m = matrix.Count;
            var n = matrix[0].Count;
            var m_midel = m / 2;
            var n_midel = n / 2;
            for (int i = 0; i < Math.Min(m_midel, n_midel); i++)
            {
                rotateRing(i, n - 1 - i, i, m - 1 - i, matrix, r) ;
            }
        }
        matrix.ForEach(row => Console.WriteLine(string.Join(" ", row)));
    }

    static void Main(string[] args)
    {
        string[] mnr = Console.ReadLine().TrimEnd().Split(' ');

        int m = Convert.ToInt32(mnr[0]);

        int n = Convert.ToInt32(mnr[1]);

        int r = Convert.ToInt32(mnr[2]);

        List<List<int>> matrix = new List<List<int>>();

        for (int i = 0; i < m; i++)
        {
            matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
        }

        matrixRotation(matrix, r);
    }
}
