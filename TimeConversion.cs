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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
           // Extract the AM/PM part and the time part
        string period = s.Substring(s.Length - 2);
        string time = s.Substring(0, s.Length - 2);

        // Split the time into hours, minutes, and seconds
        string[] timeParts = time.Split(':');
        int hours = int.Parse(timeParts[0]);
        string minutes = timeParts[1];
        string seconds = timeParts[2];
        if(period=="PM")
        {   if(hours==12){
            hours+=0;
        }
        else{
            hours+=12;
        }}
        else{
            if(hours==12)
            {
                hours=0;
            }
        }
    string formattedHours = hours.ToString("D2");
    return $"{formattedHours}:{minutes}:{seconds}";

}
}
class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
