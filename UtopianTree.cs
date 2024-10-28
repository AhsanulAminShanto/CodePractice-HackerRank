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

class Result
{

    /*
     * Complete the 'utopianTree' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static int utopianTree(int n)
    {
        // float x=n/2;
        // if (x % 1 != 0){
        // x = (float)Math.Ceiling(x);
        // }
        // int y= (int)x;
        int init=1;
        if(n>0){
        for (int i=0;i<n;i++)
        {
            // Console.WriteLine(x);
            // int init=1;
            // if(n>0)
            // {
                init=2*init;
                i++;
                if(i==n)
                {
                    break;
                }
                else{
                    init =init+1;
                }
                
            }
            // else{
            //     int m = 0;
            // }
        }
        // }
      return init;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int result = Result.utopianTree(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
