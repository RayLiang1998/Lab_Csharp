using Lab_Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C#!");
            Console.Write("Please enter your name: ");
            string Name = Console.ReadLine();
            Console.Write("Your name is ");
            Console.WriteLine(Name);
            Console.WriteLine("Hello " + Name);

            MyFirstClass mfc = new MyFirstClass();
            mfc.method03();
            mfc.method04();

            Console.ReadKey();
        }
    }
}
