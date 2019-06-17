using System;
using System.IO;

namespace TxtFileReader_RWoodhouse
{
    class Program
    {
        static void Main(string[] args)
        {
            TxtFileReader(@"mytest.txt");
        }

        static void TxtFileReader(string filePath)
        {
            try
            {
                string[] line = File.ReadAllLines(filePath);
                Console.WriteLine(line[0]);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: \"mytest.txt\" file not found");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: Array line number out of range");
            }
        }
    }
}
