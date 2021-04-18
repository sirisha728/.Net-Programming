using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = "Z:\\CA261-.NET PROGRAMMING LAB\\Lab6.cs\\Lab6.cs\\bin\\Debug\\lab6.txt";
            Console.WriteLine("WRITING TO A FILE");
            WriteToFile(filepath);
            Console.WriteLine("READING FROM A FILE");
            ReadFromFile(filepath);
        }
        public static void ReadFromFile(string filepath)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(filepath);
            int count = 0;
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
                count++;
            }
            reader.Close();
        }
        public static void WriteToFile(string filepath)
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter(filepath, true);
            string temp = string.Empty;
            Console.WriteLine("enter name[-1 to exit]:");
            do
            {

                temp = Console.ReadLine();
                if (temp != "-1")
                {
                    writer.WriteLine(temp);
                }
            } while (temp != "-1");
            writer.Close();
            Console.ReadLine();
        }
    }
}
