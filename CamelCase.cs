// using System.CodeDom.Compiler;
// using System.Collections.Generic;
// using System.Collections;
// using System.ComponentModel;
// using System.Diagnostics.CodeAnalysis;
// using System.Globalization;
// using System.IO;
// using System.Linq;
// using System.Reflection;
// using System.Runtime.Serialization;
// using System.Text.RegularExpressions;
// using System.Text;
// using System;

public class CamelCase
{

    /*
     * Complete the 'camelcase' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    // public static int camelcase(string s)
    public static void camelcase()
    {
        string s="saveChangesInTheEditor";
        int a=s.Length;
        int result=1;
        for (int i=0;i<a;i++)
        {
            if(char.IsUpper(s[i]))
            {
                result++;
            }
        }
        // return result;
        Console.WriteLine(result);
    }

}

// class Solution
// {
//     public static void Main(string[] args)
//     {
//         TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//         string s = Console.ReadLine();

//         int result = Result.camelcase(s);

//         textWriter.WriteLine(result);

//         textWriter.Flush();
//         textWriter.Close();
//     }
// }
