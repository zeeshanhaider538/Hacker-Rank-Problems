using System;

public class stairCase
{
    public static void stc()
    {
        char a='#';
        int i;
        int k=0;
        int j=6;
        for(i=1;i<7;i++)
        {
            while(j>i)
            {
                Console.Write(" ");
                j--;
            }
            while(k<i)
            {
                Console.Write(a);
                k++;

            }
            
            Console.WriteLine("\n");
            j=6;
            k=0;
        }
    }
}