using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    internal class Program
    {
        public void Add()
        {
            int a, b, c;
            a = 10; b=20; c=a+b;
            Console.WriteLine("Add=" + c);
        }

        public void Mul()
        {
            int a, b, c;
            a = 10; b = 20; c = a * b;
            Console.WriteLine("mul=" + c);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Add();
            p.Mul();
            Console.ReadLine();
        }
    }
}
