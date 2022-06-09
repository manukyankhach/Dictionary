using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,int> myDictionary = new MyDictionary<string,int>();
            myDictionary.Add("test1", 1);
            myDictionary.Add("test2", 2);
            Console.WriteLine(myDictionary);
            Console.ReadLine();
        }
    }
}
