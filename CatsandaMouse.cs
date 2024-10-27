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

class Solution {

    // Complete the catAndMouse function below.
    static string catAndMouse(int x, int y, int z) {
    int m = z - x;  // Distance between Cat A and the Mouse
    int n = z - y;  // Distance between Cat B and the Mouse

    if (Math.Abs(m) > Math.Abs(n)) {
        return "Cat B";  // Cat B is closer
    } 
    else if (Math.Abs(m) < Math.Abs(n)) {
        return "Cat A";  // Cat A is closer
    } 
    else {
        return "Mouse C"; // Both cats are equally close to the mouse
    }
}
    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string[] xyz = Console.ReadLine().Split(' ');

            int x = Convert.ToInt32(xyz[0]);

            int y = Convert.ToInt32(xyz[1]);

            int z = Convert.ToInt32(xyz[2]);

            string result = catAndMouse(x, y, z);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
