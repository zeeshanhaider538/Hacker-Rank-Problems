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

public class HackerRank_String
{

    /*
     * Complete the 'hackerrankInString' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    // public static string hackerrankInString(string s)
    public static void hackerrankInString()
    {
        string s="hhaacckkekraraannk";
        string result="NO";
        string g="hackerrank";
        int h=g.Length;
        if(h<=s.Length){
            for(int i=0;i<h;i++){
                for (int j=0;j<s.Length;j++){
                    if (g[i]==s[j]){
                        result="YES";
                    }
                    else{
                        result="NO";
                        continue;
                    }
                }
            }
            Console.WriteLine(result);
        }
        else{
            // return result;
            Console.WriteLine(result);
        }
        // return result;
    }

}

// class Solution
// {
//     public static void Main(string[] args)
//     {
//         TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//         int q = Convert.ToInt32(Console.ReadLine().Trim());

//         for (int qItr = 0; qItr < q; qItr++)
//         {
//             string s = Console.ReadLine();

//             string result = Result.hackerrankInString(s);

//             textWriter.WriteLine(result);
//         }

//         textWriter.Flush();
//         textWriter.Close();
//     }
// }