using System;
using System.Collections.Generic;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.FisherMA.Sprint6.Task6.V9.Lib
{
    public class DataService : ISprint6Task6V9
    {
        public string CollectTextFromFile(string path)
        {
            List<string> lastWords = new List<string>();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        var words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        if (words.Length > 0)
                        {
                            lastWords.Add(words[words.Length - 1]);
                        }
                    }
                }
            }

            return string.Join(" ", lastWords);
        }
    }
}