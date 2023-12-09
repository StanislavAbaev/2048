using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048.Common
{
    public static class FileProvider
    {
        public static void AddData(string data, string path)
        {
            if (!File.Exists(path)) File.Create(path).Dispose();
            using (var sw = new StreamWriter(path, false))
            {
                sw.WriteLine(data);
            }
        }
        public static string GetData(string path)
        {
            if (!File.Exists(path)) File.Create(path).Dispose();
            string value = "";
            using (var sr = new StreamReader(path))
            {
                value += sr.ReadToEnd();
            }

            return value;
        }





    }
}
