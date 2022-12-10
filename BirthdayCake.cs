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
public class birthdayCake
{

    /*
     * Complete the 'birthdayCakeCandles' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY candles as parameter.
     */

    // public static int birthdayCakeCandles(List<int> candles)
    public static void bCC()
    {
        int[] b={3,2,1,3};
        List<int> candles=new List<int>(b) ;
        int a=candles.Count;
        int h=candles.Max();
        int check=0;
        for (int i=0;i<a;i++)
        {
          if(candles[i]==h)
          {
              check++;
          }             
        }
        // return check;
        Console.WriteLine(check);
    }
}