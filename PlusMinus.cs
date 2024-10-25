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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        float CountA=0;
        float CountB=0;
        float CountC=0;
        for(int i=0;i<arr.Count;i++){
            if (arr[i]>0){
                CountA++;
            }
            else if(arr[i]<0){
                CountB++;
            }
            else{
                CountC++;
            }
        }
        // Console.WriteLine(arr.Count);
        // Console.WriteLine(CountA);
        // Console.WriteLine(CountB);
        // Console.WriteLine(CountC);
        float CountP = CountA/arr.Count;
        float CountN = CountB/arr.Count;
        float CountZ = CountC/arr.Count;
        Console.WriteLine(CountP);
        Console.WriteLine(CountN);
        Console.WriteLine(CountZ);

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
