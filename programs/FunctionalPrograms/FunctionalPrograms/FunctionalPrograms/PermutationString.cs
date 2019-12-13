using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class PermutationString
    {
        public static void StringPermute()
        {
            Console.WriteLine("Enter a string : ");
            string str = Console.ReadLine();
            Utility.StringPermutation(str,0,str.Length-1);
        }
    }
}
