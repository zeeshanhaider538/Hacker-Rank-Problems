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

public class strongPassword
{

    /*
     * Complete the 'minimumNumber' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. STRING password
     */

    // public static int minimumNumber(int n, string password)
    public static void minimumNumber()
    {
        // string password=Console.ReadLine();
        // int n=Convert.ToInt32(Console.Read());
        string password="shAnu#1";
        bool lc= false;
        bool uc= false;
        bool num= false;
        bool spc= false;
        int k=0;
        string numbers = "0123456789";
        string lower_case = "abcdefghijklmnopqrstuvwxyz";
        string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string special_characters = "!@#$%^&*()-+";
        if(password.Length>=6)
        {
            for (int i=0;i<password.Length;i++){
                for(int j=0;j<numbers.Length;j++){
                    if(password[i]==numbers[j]){
                        num=true;
                    }
                }
            }
            for (int i=0;i<password.Length;i++){
                for(int j=0;j<upper_case.Length;j++){
                    if(password[i]==upper_case[j]){
                        uc=true;
                    }
                }
            }
            for (int i=0;i<password.Length;i++){
                for(int j=0;j<lower_case.Length;j++){
                    if(password[i]==lower_case[j]){
                        lc=true;
                    }
                }
            }
            for (int i=0;i<password.Length;i++){
                for(int j=0;j<special_characters.Length;j++){
                    if(password[i]==special_characters[j]){
                        spc=true;
                    }
                }
            }
            int need = 0;
            if(lc==true){
                need++;
            }
            if(uc==true){
                need++;
            }
            if(num==true){
                need++;
            }
            if(spc==true){
                need++;
            }
            if(need<4){
                k=4-need;
            }
            // return k;
            Console.WriteLine(k);
        }
        else
        {
            k=6 - password.Length;
            // return k;
            Console.WriteLine(k);
        }
    }

}