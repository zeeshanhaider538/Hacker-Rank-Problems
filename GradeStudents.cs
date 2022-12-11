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

// class Result
public class GradeStudents
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    // public static List<int> gradingStudents(List<int> grades)
    public static void gradingStudents()
    {
        int y=0;
        int[] grades={75,67,40,33};
        // for (int i=0;i<grades.Count;i++)
        for (int i=0;i<grades.Length;i++)
        {
            if(grades[i]>33)
            {
                if(grades[i]%5>=3)
                {
                    y=5-grades[i]%5;
                    grades[i]=grades[i]+y;
                }
            }
        }
        // return grades;
        for(int i=0;i<grades.Length;i++)
        {
            Console.WriteLine(grades[i]);
        }
    }

}