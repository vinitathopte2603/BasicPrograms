using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class ReplaceString
    {
        public static void ReplaceStringResult()
        {
            try
            {
                Console.WriteLine("Enter user name");
                string userName = Console.ReadLine();

                Utility.ReplaceString(userName);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
