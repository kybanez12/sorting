using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FileHandler
    {
        public int[] ReadFile(string path)
        {
            using (var sr = new StreamReader(path))
            {
                var myArray = sr.ReadToEnd()
                    .Split('\n')
                    .SelectMany(s => s.Split(',')
                        .Select(x => int.Parse(x)))
                    .ToArray<int>();

                return myArray;
            }
        }

        public void WriteFile(string path, string[] sortedArray)
        {
            using (StreamWriter file = new StreamWriter(path))
            {
                foreach (var item in sortedArray)
                {
                    file.WriteLine(item);
                }
            }
        }
    }
}
