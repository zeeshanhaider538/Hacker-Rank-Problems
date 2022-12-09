using System;

public class stairCase
{
    public static void stc()
    {
        // char a='#';
        // int i;
        // int k=0;
        // int j=6;
        // for(i=1;i<7;i++)
        // {
        //     while(j>i)
        //     {
        //         Console.Write(" ");
        //         j--;
        //     }
        //     while(k<i)
        //     {
        //         Console.Write(a);
        //         k++;

        //     }
            
        //     Console.WriteLine("\n");
        //     j=6;
        //     k=0;
        // }

        //--------------  Hacker Rank Problem by Taking Input n gives 100% result----------------

        char a='#';
        int n=Convert.ToInt32(Console.ReadLine());
        int i;
        int k=0;
        int j=n;    // taking n as input
        for(i=1;i<n+1;i++)
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
            Console.Write("\n");
            j=n;
            k=0;
        }
    }
}