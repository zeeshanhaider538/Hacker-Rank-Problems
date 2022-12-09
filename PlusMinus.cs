// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void plusMinus()
    {
        int[] arr={-4,3,-9,0,4,1};
        float  pst=0f;
        float ngt=0f;
        float zr=0f;
        float a=0f;
        float b=0f;
        float c=0f;
        int l=arr.Length;
        for (int i=0;i<l;i++)
        {
            if(arr[i] > 0){
                pst++;
            }
            else if(arr[i] < 0){
                ngt++;
            }
            else{
                zr++;
            }
        }
       a=pst/l;
        b=Math.Abs(ngt/l);
        c=(zr/l);
        string acon=Convert.ToString(a);
        while (acon.Length<8){
            acon = acon + "0";
        }
        decimal ac=Convert.ToDecimal(acon);
        Console.WriteLine(ac);
        Console.WriteLine(Math.Round(b,6));
        Console.WriteLine(Math.Round(c,6)); 
    }
    }