using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class TwoDArray
    {
        public static void Array()
        {
            Console.WriteLine("Enter the number of rows and colums ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int columns = Convert.ToInt32(Console.ReadLine());
            Utility.TwoDimArray(rows, columns);
        }
    }
}
