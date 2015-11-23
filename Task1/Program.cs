using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pen pen = new Pen(10, 1.1);
            pen.printValue();
            Console.WriteLine(pen.write("1234567890"));
            pen.printValue();
            Console.ReadLine();
        }
    }
}
