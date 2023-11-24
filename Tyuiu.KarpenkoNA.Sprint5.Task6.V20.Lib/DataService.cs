using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KarpenkoNA.Sprint5.Task6.V20.Lib
{
    public class DataService : ISprint5Task6V20
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string[] text;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    text = line.Split(' ');
                    foreach (string word in text)
                    {
                        int lenght = word.Length;
                        if (lenght == 6)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
            
        }
    }
}
