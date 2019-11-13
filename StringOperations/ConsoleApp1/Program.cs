using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char cChar = 'A';
            string sString = "a";
            Console.WriteLine(Convert.ToInt32(cChar));
            Console.WriteLine(Convert.ToInt32(Convert.ToChar(sString)));
            Console.ReadKey();
        }
    }
}
