using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries
{
   public static class FileProvider
    {

        public static string GetValue(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            var value = reader.ReadToEnd();
            reader.Close();
            return value;

        }

        public static void SaveToFile(string fileName, string value)
        {
            StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8);
            writer.WriteLine(value);
            writer.Close();

        }

    }
}
