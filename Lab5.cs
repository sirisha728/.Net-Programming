using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();
            myList.Add("1.siri");
            myList.Add("2.Lakshmi");
            myList.Add("3.Vani");
            myList.Add("4.Sita");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");
            myList.Sort();
            Console.WriteLine("\n After sorting");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");
            myList.Remove("Sita");
            Console.WriteLine("\n Removing of Sita");
            foreach (string s in myList)
                Console.WriteLine(s.ToString() + " ");
            myList.Insert(2, "Thulasi");
            Console.WriteLine("\n Inserting of Thulasi at index position 2");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");
        }
    }
}
