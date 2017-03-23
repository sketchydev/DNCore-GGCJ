﻿using System;
using System.IO;
using System.Collections.Generic;

namespace GGCJ
{
    class Program
    {
        static void Main(string[] args)
        {
            var input =
              FileUtils.ReadFileToStringArray(@"c:\temp\GGCJ_2016\Inputs\A-large.in");            
            var currentCase = 1;
            var caseCount = int.Parse(FileUtils.GetCountOfCases(input));
            var output = new string[caseCount];
            while (currentCase <= caseCount)
            {
                var result=string.Empty;
                //MAGIC GOES HERE  
                //MAGIC ENDS HERE  
                Console.WriteLine("Case #{0}: {1}", currentCase, result);
                output[currentCase - 1] = $"Case #{currentCase}: {result}";                
                currentCase += 1;
            }
           // FileUtils.WriteStringArrayToFile(output,@"c:\temp\GGCJ_\Outputs\.out");
            Console.ReadKey();
      }
    }



    public static class FileUtils
    {
        public static string[] ReadFileToStringArray(string filename)
        {
            return File.ReadAllLines(filename);
        }
        public static string[] GetRecordSet(int start, int length, string[] input)
        {
            var output = new string[length];
            var pointer = 0;
            for (var i = start; i < start + length; i++)
            {
                output[pointer] = input[i];
                pointer++;
            }
            return output;
        }
        public static string GetCountOfCases(string[] input)
        {
            return input[0];
        }
        public static void WriteStringArrayToFile(string[] data, string filename)
        {
            try { File.Delete(filename); }
            catch
            {/*Intentionally empty*/}
            
            var outputFile = File.Create(filename);
            using(var  sw = new StreamWriter(outputFile)){
                foreach (var row in data)
                {
                    sw.WriteLine(row);
                }
            };
        }

        public static void WriteListToFile(List<string> data, string filename)
        {
            try { File.Delete(filename); }
            catch
            {/*Intentionally empty*/}
            var outputFile = File.Create(filename);
            using(var sw = new StreamWriter(outputFile)){
                foreach (var row in data)
                {
                    sw.WriteLine(row);
                }
            };
        }
    }
}
