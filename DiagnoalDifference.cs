// using System.CodeDom.Compiler;
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

// class Result
public class DiagnoalDifference
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    // public static int diagonalDifference(List<List<int>> arr)
    public static void diagonalDifference()

    {
        // there you have to firs declare the 2-d array with name arr
        int result=0;
        int a=arr[0][0]+ arr[1][1] + arr[2][2];
        int b=arr[0][2]+ arr[1][1]+ arr[2][0];
        int g=a-b;
        result=Math.Abs(g);
        // return result;
        Console.WriteLine(result);
    }

}

// class Solution
// {
//     public static void Main(string[] args)
//     {
//         TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//         int n = Convert.ToInt32(Console.ReadLine().Trim());

//         List<List<int>> arr = new List<List<int>>();

//         for (int i = 0; i < n; i++)
//         {
//             arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
//         }

//         int result = Result.diagonalDifference(arr);

//         textWriter.WriteLine(result);

//         textWriter.Flush();
//         textWriter.Close();
//     }
// }