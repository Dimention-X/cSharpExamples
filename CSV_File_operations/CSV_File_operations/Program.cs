using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_File_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\akumar\Desktop\Akhilesh.CSV";
            string delimiter = ",";
            string[][] output = new string[][]
             {
                 new string[] {"Col 1 Row 1","Col 2 Row ","Col 3 Row 1"},
                 new string[] {"Col 1 Row 2","Col 1 Row 2","Col 1 Row 2"}
             };

            int length = output.GetLength(0);
            StringBuilder sb = new StringBuilder();
            for (int index = 0; index < length; index++)
            {
                sb.AppendLine(string.Join(delimiter, output[index]));

            }
            File.WriteAllText(filepath, sb.ToString());
        }
    }
}
