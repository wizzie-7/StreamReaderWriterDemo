using System;
using System.IO;

namespace StreamReaderWriterDemo
{
    public class StreamReaderWriterOperations
    {
        public void WriteStream()
        {
            using (StreamWriter sw = File.CreateText(@"D:\wizzie\DOT NET\mytable.txt"))
            {
                sw.WriteLine("Please find the below generated table of 1 to 10");
                sw.WriteLine("");
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        sw.WriteLine("{0}x{1}= {2}", i, j, (i * j));
                    }
                    sw.WriteLine("==============");
                }
                Console.WriteLine("Table successfully written on file.");
            }
        }
        public void ReadStream()
        {
            using (StreamReader sr = File.OpenText(@"D:\wizzie\DOT NET\mytable.txt"))
            {
                string tables = null;

                while ((tables = sr.ReadLine()) != null)
                {
                    Console.WriteLine("{0}", tables);
                }
                Console.WriteLine("Table Printed.");
            }
        }
    }
    class StreamReaderWriterEx
    {
        static void Main(string[] args)
        {
            StreamReaderWriterOperations srwo = new StreamReaderWriterOperations();
            srwo.WriteStream();
            srwo.ReadStream();
        }
    }
}
