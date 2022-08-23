using Azure.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice
{
    public  class Practice
    {

    }

    public class Learning
    {
        public void Method1()
        {
            Console.WriteLine("hey this is class Learning");
            string? abc = null;
            //string? aa = abc;
            string xyz = string.Empty;
        }
        
    }

    public static class Extnsn
    {
        public static string countt(this string str )
        {
            return str.Length.ToString();
        }

        public static string ConvertWhitespacesToSingleSpaces(this string value)
        {
            value = Regex.Replace(value, @"\s+", " ");
            return value;
        }
    }
}
